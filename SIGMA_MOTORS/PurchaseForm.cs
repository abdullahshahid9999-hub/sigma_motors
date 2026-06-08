using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class PurchaseForm : Form
    {
        string connString = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Cancelled");
            cmbStatus.SelectedIndex = 0;

            LoadData();
        }

        // ════════════════════════════════════════════════════════════════════════
        //  LOAD DATA
        // ════════════════════════════════════════════════════════════════════════

        private void LoadData()
        {
            string search = txtSearch.Text.Trim();
            string status = cmbStatus.SelectedItem?.ToString() ?? "All";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            PO.PURCHASE_ORDER_ID    AS 'PO ID',
                            S.COMPANY_NAME          AS 'Supplier',
                            B.BRAND_NAME            AS 'Brand',
                            M.MODEL_NAME            AS 'Model',
                            VR.VARIENT_NAME         AS 'Variant',
                            V.REGISTRATION_NUMBER   AS 'Reg No.',
                            V.COLOUR                AS 'Colour',
                            V.MANUFACTURE_YEAR      AS 'Year',
                            PO.PRICE                AS 'Purchase Price',
                            PO.PURCHASE_DATE        AS 'Date',
                            PO.STATUS               AS 'Status',
                            E.NAME                  AS 'Added By'
                        FROM PURCHASE_ORDERS PO
                        JOIN VEHICLE   V   ON PO.VEHICLE_ID  = V.VEHICLE_ID
                        JOIN SUPPLIER  S   ON PO.SUPPLIER_ID = S.SUPPLIER_ID
                        JOIN EMPLOYEE  E   ON PO.EMPLOYEE_ID = E.EMPLOYEE_ID
                        JOIN BRANDS    B   ON V.BRAND_ID     = B.BRAND_ID
                        JOIN MODELS    M   ON V.MODEL_ID     = M.MODEL_ID
                        JOIN VARIENTS  VR  ON V.VARIENT_ID   = VR.VARIENT_ID
                        WHERE 1=1";

                    if (!string.IsNullOrEmpty(search))
                        query += @" AND (S.COMPANY_NAME LIKE @s
                                     OR B.BRAND_NAME   LIKE @s
                                     OR M.MODEL_NAME   LIKE @s
                                     OR V.REGISTRATION_NUMBER LIKE @s)";

                    if (status != "All")
                        query += " AND PO.STATUS = @status";

                    query += " ORDER BY PO.PURCHASE_ORDER_ID DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@s", "%" + search + "%");
                    da.SelectCommand.Parameters.AddWithValue("@status", status);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPurchase.DataSource = dt;

                    StyleGrid();
                    UpdateStats(conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  STATS CARDS
        // ════════════════════════════════════════════════════════════════════════

        private void UpdateStats(MySqlConnection conn)
        {
            try
            {
                string q = @"
                    SELECT
                        COUNT(*)                                        AS Total,
                        SUM(CASE WHEN STATUS='Pending'   THEN 1 ELSE 0 END) AS Pending,
                        SUM(CASE WHEN STATUS='Completed' THEN 1 ELSE 0 END) AS Completed,
                        SUM(CASE WHEN STATUS='Cancelled' THEN 1 ELSE 0 END) AS Cancelled,
                        COALESCE(SUM(PRICE),0)                         AS TotalAmount,
                        COALESCE(SUM(CASE WHEN STATUS='Pending' THEN PRICE ELSE 0 END),0) AS PendingAmount
                    FROM PURCHASE_ORDERS";

                using (MySqlCommand cmd = new MySqlCommand(q, conn))
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        lblStatTotal.Text = $"Total Orders\n{dr["Total"]}";
                        lblStatPending.Text = $"Pending\n{dr["Pending"]}";
                        lblStatCompleted.Text = $"Completed\n{dr["Completed"]}";
                        lblStatAmount.Text = $"Total Value\nPKR {Convert.ToDecimal(dr["TotalAmount"]):N0}";
                        lblStatDue.Text = $"Payment Due\nPKR {Convert.ToDecimal(dr["PendingAmount"]):N0}";
                    }
                }
            }
            catch { /* stats optional */ }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  GRID STYLING
        // ════════════════════════════════════════════════════════════════════════

        private void StyleGrid()
        {
            foreach (DataGridViewRow row in dgvPurchase.Rows)
            {
                var cell = row.Cells["Status"];
                switch (cell.Value?.ToString())
                {
                    case "Pending":
                        cell.Style.ForeColor = System.Drawing.Color.FromArgb(180, 100, 0);
                        cell.Style.BackColor = System.Drawing.Color.FromArgb(255, 243, 205);
                        break;
                    case "Completed":
                        cell.Style.ForeColor = System.Drawing.Color.FromArgb(0, 128, 0);
                        cell.Style.BackColor = System.Drawing.Color.FromArgb(212, 237, 218);
                        break;
                    case "Cancelled":
                        cell.Style.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0);
                        cell.Style.BackColor = System.Drawing.Color.FromArgb(248, 215, 218);
                        break;
                }
                if (cell.Value != null)
                    cell.Style.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  EVENTS
        // ════════════════════════════════════════════════════════════════════════

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadData();
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) => LoadData();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbStatus.SelectedIndex = 0;
            LoadData();
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            AddPurchaseForm f = new AddPurchaseForm();
            f.ShowDialog();
            LoadData();
        }

        private void btnEditStatus_Click(object sender, EventArgs e)
        {
            if (dgvPurchase.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a purchase order.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int poId = Convert.ToInt32(dgvPurchase.SelectedRows[0].Cells["PO ID"].Value);
            string currentStatus = dgvPurchase.SelectedRows[0].Cells["Status"].Value.ToString();

            EditPurchaseStatusForm ef = new EditPurchaseStatusForm(poId, currentStatus);
            ef.ShowDialog();
            LoadData();
        }

        private void dgvPurchase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dgvPurchase.Rows[e.RowIndex].Selected = true;
            btnEditStatus_Click(sender, e);
        }

        // ════════════════════════════════════════════════════════════════════════
        //  EXPORT TO CSV
        // ════════════════════════════════════════════════════════════════════════

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvPurchase.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel CSV (*.csv)|*.csv",
                FileName = $"Purchases_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                {
                    for (int c = 0; c < dgvPurchase.Columns.Count; c++)
                    {
                        sw.Write(dgvPurchase.Columns[c].HeaderText);
                        if (c < dgvPurchase.Columns.Count - 1) sw.Write(",");
                    }
                    sw.WriteLine();

                    foreach (DataGridViewRow row in dgvPurchase.Rows)
                    {
                        for (int c = 0; c < dgvPurchase.Columns.Count; c++)
                        {
                            string val = row.Cells[c].Value?.ToString() ?? "";
                            if (val.Contains(",")) val = $"\"{val}\"";
                            sw.Write(val);
                            if (c < dgvPurchase.Columns.Count - 1) sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("Exported!\n" + sfd.FileName, "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}