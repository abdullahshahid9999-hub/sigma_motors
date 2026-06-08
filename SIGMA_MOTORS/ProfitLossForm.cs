using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class ProfitLossForm : Form
    {
        private readonly string ConnStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public ProfitLossForm()
        {
            InitializeComponent();
        }

        private void ProfitLossForm_Load(object sender, EventArgs e)
        {
            // Populate months
            cmbMonth.Items.Clear();
            string[] months = { "January","February","March","April","May","June",
                                 "July","August","September","October","November","December" };
            foreach (var m in months) cmbMonth.Items.Add(m);
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;

            // Populate years
            cmbYear.Items.Clear();
            for (int y = DateTime.Now.Year; y >= 2020; y--)
                cmbYear.Items.Add(y.ToString());
            cmbYear.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex < 0 || cmbYear.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a month and year.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int month = cmbMonth.SelectedIndex + 1;
            int year = int.Parse(cmbYear.SelectedItem.ToString());

            try
            {
                decimal revenue = 0, cost = 0;

                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();

                    // Revenue = sum of (price - discount) from sales in that month/year
                    string revQ = @"SELECT IFNULL(SUM(PRICE - DISCOUNT), 0)
                                    FROM SALE_TRANSCTION
                                    WHERE MONTH(SALE_DATE) = @month AND YEAR(SALE_DATE) = @year";
                    var revCmd = new MySqlCommand(revQ, conn);
                    revCmd.Parameters.AddWithValue("@month", month);
                    revCmd.Parameters.AddWithValue("@year", year);
                    revenue = Convert.ToDecimal(revCmd.ExecuteScalar());

                    // Cost = sum of price from completed purchase orders in that month/year
                    string costQ = @"SELECT IFNULL(SUM(PRICE), 0)
                                     FROM PURCHASE_ORDERS
                                     WHERE STATUS = 'Completed'
                                     AND MONTH(PURCHASE_DATE) = @month AND YEAR(PURCHASE_DATE) = @year";
                    var costCmd = new MySqlCommand(costQ, conn);
                    costCmd.Parameters.AddWithValue("@month", month);
                    costCmd.Parameters.AddWithValue("@year", year);
                    cost = Convert.ToDecimal(costCmd.ExecuteScalar());
                }

                decimal profit = revenue - cost;
                bool isProfit = profit >= 0;

                // Update UI
                string period = cmbMonth.SelectedItem.ToString() + " " + year;
                lblPeriod.Text = "Period: " + period;
                lblPeriod.Visible = true;

                lblRevenueValue.Text = "Rs " + revenue.ToString("N0");
                lblCostValue.Text = "Rs " + cost.ToString("N0");

                lblProfitLabel.Text = isProfit ? "Net Profit" : "Net Loss";
                lblProfitValue.Text = (isProfit ? "+" : "-") + "Rs " + Math.Abs(profit).ToString("N0");
                lblProfitValue.ForeColor = isProfit ? System.Drawing.Color.FromArgb(0, 150, 0) : System.Drawing.Color.FromArgb(180, 0, 0);
                lblProfitLabel.ForeColor = isProfit ? System.Drawing.Color.FromArgb(0, 150, 0) : System.Drawing.Color.FromArgb(180, 0, 0);

                pnlResults.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}