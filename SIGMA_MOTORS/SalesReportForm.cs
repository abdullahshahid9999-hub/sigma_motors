using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class SalesReportForm : Form
    {
        private readonly string ConnStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Paid");
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Partial");
            cmbStatus.SelectedIndex = 0;

            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;

            dgvSales.DataError += (s, ex) => ex.ThrowException = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                string statusFilter = cmbStatus.SelectedItem?.ToString() == "All" ? "" : cmbStatus.SelectedItem?.ToString();

                string query = @"
                    SELECT
                        st.SALE_ID AS `Sale ID`,
                        c.NAME AS `Customer`,
                        CONCAT(b.BRAND_NAME, ' ', m.MODEL_NAME, ' ', v.VARIENT_NAME) AS `Vehicle`,
                        st.PRICE AS `Price`,
                        st.DISCOUNT AS `Discount`,
                        st.PAYMENT_METHOD AS `Payment Method`,
                        DATE_FORMAT(st.SALE_DATE, '%d-%b-%Y') AS `Sale Date`,
                        st.EMPLOYEE_NAME AS `Salesperson`,
                        st.PAYMENT_STATUS AS `Status`
                    FROM SALE_TRANSCTION st
                    LEFT JOIN CUSTOMER c ON st.CUSTOMER_ID = c.CUSTOMER_ID
                    LEFT JOIN VEHICLE vh ON st.VEHICLE_ID = vh.VEHICLE_ID
                    LEFT JOIN BRANDS b ON vh.BRAND_ID = b.BRAND_ID
                    LEFT JOIN MODELS m ON vh.MODEL_ID = m.MODEL_ID
                    LEFT JOIN VARIENTS v ON vh.VARIENT_ID = v.VARIENT_ID
                    WHERE st.SALE_DATE BETWEEN @from AND @to";

                if (!string.IsNullOrEmpty(statusFilter))
                    query += " AND st.PAYMENT_STATUS = @status";

                query += " ORDER BY st.SALE_DATE DESC";

                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date);
                    cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date.AddDays(1).AddSeconds(-1));
                    if (!string.IsNullOrEmpty(statusFilter))
                        cmd.Parameters.AddWithValue("@status", statusFilter);

                    var adapter = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSales.DataSource = dt;

                    // Footer stats
                    int count = dt.Rows.Count;
                    decimal totalRevenue = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        decimal price = row["Price"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Price"]);
                        decimal disc = row["Discount"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Discount"]);
                        totalRevenue += (price - disc);
                    }
                    lblFooter.Text = $"Records: {count}     |     Total Revenue: Rs {totalRevenue:N0}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (dgvSales.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "CSV Files|*.csv";
                dlg.FileName = "SalesReport_" + DateTime.Now.ToString("yyyyMMdd");
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    // Headers
                    for (int i = 0; i < dgvSales.Columns.Count; i++)
                    {
                        sb.Append(dgvSales.Columns[i].HeaderText);
                        if (i < dgvSales.Columns.Count - 1) sb.Append(",");
                    }
                    sb.AppendLine();
                    // Rows
                    foreach (DataGridViewRow row in dgvSales.Rows)
                    {
                        if (row.IsNewRow) continue;
                        for (int i = 0; i < dgvSales.Columns.Count; i++)
                        {
                            string val = row.Cells[i].Value?.ToString() ?? "";
                            sb.Append("\"" + val.Replace("\"", "\"\"") + "\"");
                            if (i < dgvSales.Columns.Count - 1) sb.Append(",");
                        }
                        sb.AppendLine();
                    }
                    File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}