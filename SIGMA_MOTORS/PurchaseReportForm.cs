using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class PurchaseReportForm : Form
    {
        private readonly string ConnStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public PurchaseReportForm()
        {
            InitializeComponent();
        }

        private void PurchaseReportForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Cancelled");
            cmbStatus.SelectedIndex = 0;

            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;

            dgvPurchases.DataError += (s, ex) => ex.ThrowException = false;
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
                        po.PURCHASE_ORDER_ID AS `PO ID`,
                        s.COMPANY_NAME AS `Supplier`,
                        CONCAT(b.BRAND_NAME, ' ', m.MODEL_NAME) AS `Vehicle`,
                        po.PRICE AS `Price`,
                        DATE_FORMAT(po.PURCHASE_DATE, '%d-%b-%Y') AS `Purchase Date`,
                        e.NAME AS `Employee`,
                        po.STATUS AS `Status`
                    FROM PURCHASE_ORDERS po
                    LEFT JOIN SUPPLIER s ON po.SUPPLIER_ID = s.SUPPLIER_ID
                    LEFT JOIN VEHICLE vh ON po.VEHICLE_ID = vh.VEHICLE_ID
                    LEFT JOIN BRANDS b ON vh.BRAND_ID = b.BRAND_ID
                    LEFT JOIN MODELS m ON vh.MODEL_ID = m.MODEL_ID
                    LEFT JOIN EMPLOYEE e ON po.EMPLOYEE_ID = e.EMPLOYEE_ID
                    WHERE po.PURCHASE_DATE BETWEEN @from AND @to";

                if (!string.IsNullOrEmpty(statusFilter))
                    query += " AND po.STATUS = @status";

                query += " ORDER BY po.PURCHASE_DATE DESC";

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

                    dgvPurchases.DataSource = dt;

                    int count = dt.Rows.Count;
                    decimal total = 0;
                    foreach (DataRow row in dt.Rows)
                        total += row["Price"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Price"]);

                    lblFooter.Text = $"Records: {count}     |     Total Cost: Rs {total:N0}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (dgvPurchases.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "CSV Files|*.csv";
                dlg.FileName = "PurchaseReport_" + DateTime.Now.ToString("yyyyMMdd");
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    for (int i = 0; i < dgvPurchases.Columns.Count; i++)
                    {
                        sb.Append(dgvPurchases.Columns[i].HeaderText);
                        if (i < dgvPurchases.Columns.Count - 1) sb.Append(",");
                    }
                    sb.AppendLine();
                    foreach (DataGridViewRow row in dgvPurchases.Rows)
                    {
                        if (row.IsNewRow) continue;
                        for (int i = 0; i < dgvPurchases.Columns.Count; i++)
                        {
                            string val = row.Cells[i].Value?.ToString() ?? "";
                            sb.Append("\"" + val.Replace("\"", "\"\"") + "\"");
                            if (i < dgvPurchases.Columns.Count - 1) sb.Append(",");
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