using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class InventoryReportForm : Form
    {
        private readonly string ConnStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public InventoryReportForm()
        {
            InitializeComponent();
        }

        private void InventoryReportForm_Load(object sender, EventArgs e)
        {
            dgvInventory.DataError += (s, ex) => ex.ThrowException = false;

            // Populate Brand combo
            cmbBrand.Items.Add("All");
            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();
                    var cmd = new MySqlCommand("SELECT BRAND_NAME FROM BRANDS ORDER BY BRAND_NAME", conn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        cmbBrand.Items.Add(reader["BRAND_NAME"].ToString());
                }
            }
            catch { }
            cmbBrand.SelectedIndex = 0;

            // Status
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Sold");
            cmbStatus.Items.Add("Reserved");
            cmbStatus.SelectedIndex = 0;

            // Year
            cmbYear.Items.Add("All");
            for (int y = DateTime.Now.Year; y >= 2000; y--)
                cmbYear.Items.Add(y.ToString());
            cmbYear.SelectedIndex = 0;

            LoadReport();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                string brand = cmbBrand.SelectedItem?.ToString() == "All" ? "" : cmbBrand.SelectedItem?.ToString();
                string status = cmbStatus.SelectedItem?.ToString() == "All" ? "" : cmbStatus.SelectedItem?.ToString();
                string year = cmbYear.SelectedItem?.ToString() == "All" ? "" : cmbYear.SelectedItem?.ToString();

                string query = @"
                    SELECT
                        v.VEHICLE_ID AS `ID`,
                        b.BRAND_NAME AS `Brand`,
                        m.MODEL_NAME AS `Model`,
                        va.VARIENT_NAME AS `Variant`,
                        v.COLOUR AS `Colour`,
                        v.MANUFACTURE_YEAR AS `Year`,
                        v.REGISTRATION_NUMBER AS `Reg No`,
                        v.PRICE AS `Price`,
                        v.STATUS AS `Status`
                    FROM VEHICLE v
                    LEFT JOIN BRANDS b ON v.BRAND_ID = b.BRAND_ID
                    LEFT JOIN MODELS m ON v.MODEL_ID = m.MODEL_ID
                    LEFT JOIN VARIENTS va ON v.VARIENT_ID = va.VARIENT_ID
                    WHERE 1=1";

                if (!string.IsNullOrEmpty(brand))
                    query += " AND b.BRAND_NAME = @brand";
                if (!string.IsNullOrEmpty(status))
                    query += " AND v.STATUS = @status";
                if (!string.IsNullOrEmpty(year))
                    query += " AND v.MANUFACTURE_YEAR = @year";

                query += " ORDER BY b.BRAND_NAME, m.MODEL_NAME";

                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(brand)) cmd.Parameters.AddWithValue("@brand", brand);
                    if (!string.IsNullOrEmpty(status)) cmd.Parameters.AddWithValue("@status", status);
                    if (!string.IsNullOrEmpty(year)) cmd.Parameters.AddWithValue("@year", year);

                    var adapter = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    dgvInventory.DataSource = dt;

                    // Stats
                    int total = dt.Rows.Count;
                    int available = 0, sold = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        string s = row["Status"]?.ToString() ?? "";
                        if (s == "Available") available++;
                        else if (s == "Sold") sold++;
                    }
                    lblStats.Text = $"Total: {total}     |     Available: {available}     |     Sold: {sold}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (dgvInventory.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "CSV Files|*.csv";
                dlg.FileName = "InventoryReport_" + DateTime.Now.ToString("yyyyMMdd");
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    for (int i = 0; i < dgvInventory.Columns.Count; i++)
                    {
                        sb.Append(dgvInventory.Columns[i].HeaderText);
                        if (i < dgvInventory.Columns.Count - 1) sb.Append(",");
                    }
                    sb.AppendLine();
                    foreach (DataGridViewRow row in dgvInventory.Rows)
                    {
                        if (row.IsNewRow) continue;
                        for (int i = 0; i < dgvInventory.Columns.Count; i++)
                        {
                            string val = row.Cells[i].Value?.ToString() ?? "";
                            sb.Append("\"" + val.Replace("\"", "\"\"") + "\"");
                            if (i < dgvInventory.Columns.Count - 1) sb.Append(",");
                        }
                        sb.AppendLine();
                    }
                    System.IO.File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);
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