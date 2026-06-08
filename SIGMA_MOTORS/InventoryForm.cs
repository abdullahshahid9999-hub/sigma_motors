using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class InventoryForm : Form
    {
        string connString = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            // Status filter dropdown populate
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Sold");
            cmbStatus.SelectedIndex = 0;

            LoadInventoryData();
        }

        // ════════════════════════════════════════════════════════════════════════
        //  LOAD DATA
        // ════════════════════════════════════════════════════════════════════════

        private void LoadInventoryData()
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
                            V.VEHICLE_ID            AS 'ID',
                            B.BRAND_NAME            AS 'Brand',
                            M.MODEL_NAME            AS 'Model',
                            VR.VARIENT_NAME         AS 'Variant',
                            V.REGISTRATION_NUMBER   AS 'Reg No.',
                            V.COLOUR                AS 'Colour',
                            V.MANUFACTURE_YEAR      AS 'Year',
                            M.ENGINE_DISPLACEMENT   AS 'Engine (cc)',
                            M.BODY_TYPE             AS 'Body',
                            V.PRICE                 AS 'Price (PKR)',
                            V.STATUS                AS 'Status'
                        FROM VEHICLE V
                        JOIN BRANDS   B  ON V.BRAND_ID   = B.BRAND_ID
                        JOIN MODELS   M  ON V.MODEL_ID   = M.MODEL_ID
                        JOIN VARIENTS VR ON V.VARIENT_ID = VR.VARIENT_ID
                        WHERE 1=1";

                    if (!string.IsNullOrEmpty(search))
                        query += " AND (B.BRAND_NAME LIKE @search OR M.MODEL_NAME LIKE @search OR V.REGISTRATION_NUMBER LIKE @search)";

                    if (status != "All")
                        query += " AND V.STATUS = @status";

                    query += " ORDER BY V.VEHICLE_ID DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                    da.SelectCommand.Parameters.AddWithValue("@status", status);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvInventory.DataSource = dt;

                    // ── Style status column ──────────────────────────────────────
                    StyleGrid();
                    UpdateSummary(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Inventory Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  GRID STYLING
        // ════════════════════════════════════════════════════════════════════════

        private void StyleGrid()
        {
            if (dgvInventory.Columns.Count == 0) return;

            // Color-code Status column
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.Cells["Status"].Value?.ToString() == "Available")
                    row.Cells["Status"].Style.ForeColor = System.Drawing.Color.Green;
                else if (row.Cells["Status"].Value?.ToString() == "Sold")
                    row.Cells["Status"].Style.ForeColor = System.Drawing.Color.Red;

                row.Cells["Status"].Style.Font =
                    new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            }
        }

        private void UpdateSummary(DataTable dt)
        {
            int total = dt.Rows.Count;
            int available = 0, sold = 0;
            foreach (DataRow r in dt.Rows)
            {
                if (r["Status"].ToString() == "Available") available++;
                else if (r["Status"].ToString() == "Sold") sold++;
            }
            lblSummary.Text = $"Total: {total}   |   Available: {available}   |   Sold: {sold}";
        }

        // ════════════════════════════════════════════════════════════════════════
        //  EVENTS — Search & Filter
        // ════════════════════════════════════════════════════════════════════════

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadInventoryData();
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) => LoadInventoryData();
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbStatus.SelectedIndex = 0;
            LoadInventoryData();
        }

        // ════════════════════════════════════════════════════════════════════════
        //  ADD VEHICLE
        // ════════════════════════════════════════════════════════════════════════

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleForm addForm = new AddVehicleForm();
            addForm.ShowDialog();
            LoadInventoryData();
        }

        // ════════════════════════════════════════════════════════════════════════
        //  EDIT VEHICLE — opens EditVehicleForm
        // ════════════════════════════════════════════════════════════════════════

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vehicle to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int vehicleId = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["ID"].Value);
            EditVehicleForm editForm = new EditVehicleForm(vehicleId);
            editForm.ShowDialog();
            LoadInventoryData();
        }

        // Double-click on row also opens edit
        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            dgvInventory.Rows[e.RowIndex].Selected = true;
            btnEdit_Click(sender, e);
        }

        // ════════════════════════════════════════════════════════════════════════
        //  DELETE VEHICLE
        // ════════════════════════════════════════════════════════════════════════

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vehicle to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgvInventory.SelectedRows[0].Cells["ID"].Value.ToString();
            string brand = dgvInventory.SelectedRows[0].Cells["Brand"].Value.ToString();
            string model = dgvInventory.SelectedRows[0].Cells["Model"].Value.ToString();
            string status = dgvInventory.SelectedRows[0].Cells["Status"].Value.ToString();

            if (status == "Sold")
            {
                MessageBox.Show("Cannot delete a Sold vehicle. Sale records exist for it.", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Delete {brand} {model} (ID: {id})?\nThis cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(
                            "DELETE FROM VEHICLE WHERE VEHICLE_ID = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Vehicle deleted successfully.", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventoryData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  EXPORT TO EXCEL (CSV — Excel automatically opens it)
        // ════════════════════════════════════════════════════════════════════════

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvInventory.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel CSV (*.csv)|*.csv";
            sfd.FileName = $"Inventory_{DateTime.Now:yyyyMMdd_HHmm}.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // Header row
                        for (int c = 0; c < dgvInventory.Columns.Count; c++)
                        {
                            sw.Write(dgvInventory.Columns[c].HeaderText);
                            if (c < dgvInventory.Columns.Count - 1) sw.Write(",");
                        }
                        sw.WriteLine();

                        // Data rows
                        foreach (DataGridViewRow row in dgvInventory.Rows)
                        {
                            for (int c = 0; c < dgvInventory.Columns.Count; c++)
                            {
                                string val = row.Cells[c].Value?.ToString() ?? "";
                                // Escape commas
                                if (val.Contains(",")) val = $"\"{val}\"";
                                sw.Write(val);
                                if (c < dgvInventory.Columns.Count - 1) sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Exported successfully!\n" + sfd.FileName, "Export Done",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  UNUSED (kept for designer compatibility)
        // ════════════════════════════════════════════════════════════════════════
        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}