using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class ReportsForm : Form
    {
        private readonly string ConnStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadStatCards();
        }

        private void LoadStatCards()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();

                    // Sales This Month
                    string salesQ = "SELECT COUNT(*) FROM SALE_TRANSCTION WHERE MONTH(SALE_DATE)=MONTH(CURDATE()) AND YEAR(SALE_DATE)=YEAR(CURDATE())";
                    var salesCmd = new MySqlCommand(salesQ, conn);
                    lblSalesValue.Text = salesCmd.ExecuteScalar().ToString();

                    // Purchases This Month
                    string purchQ = "SELECT COUNT(*) FROM PURCHASE_ORDERS WHERE MONTH(PURCHASE_DATE)=MONTH(CURDATE()) AND YEAR(PURCHASE_DATE)=YEAR(CURDATE())";
                    var purchCmd = new MySqlCommand(purchQ, conn);
                    lblPurchasesValue.Text = purchCmd.ExecuteScalar().ToString();

                    // Revenue This Month
                    string revQ = "SELECT IFNULL(SUM(PRICE - DISCOUNT), 0) FROM SALE_TRANSCTION WHERE MONTH(SALE_DATE)=MONTH(CURDATE()) AND YEAR(SALE_DATE)=YEAR(CURDATE())";
                    var revCmd = new MySqlCommand(revQ, conn);
                    decimal rev = Convert.ToDecimal(revCmd.ExecuteScalar());
                    lblRevenueValue.Text = "Rs " + rev.ToString("N0");

                    // Vehicles In Stock
                    string stockQ = "SELECT COUNT(*) FROM VEHICLE WHERE STATUS='Available'";
                    var stockCmd = new MySqlCommand(stockQ, conn);
                    lblStockValue.Text = stockCmd.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            var frm = new SalesReportForm();
            frm.ShowDialog(this);
        }

        private void btnPurchaseReport_Click(object sender, EventArgs e)
        {
            var frm = new PurchaseReportForm();
            frm.ShowDialog(this);
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            var frm = new InventoryReportForm();
            frm.ShowDialog(this);
        }

        private void btnProfitLoss_Click(object sender, EventArgs e)
        {
            var frm = new ProfitLossForm();
            frm.ShowDialog(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStatCards();
        }
    }
}