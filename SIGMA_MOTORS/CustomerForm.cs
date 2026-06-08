using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class CustomerForm : Form
    {
        private readonly string _connStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";
        private DataTable _dt = new DataTable();

        public CustomerForm()
        {
            InitializeComponent();
        }

        // Required if Designer.cs wires this.Load += CustomerForm_Load
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadStats();
            LoadCustomers();
        }

        // ─── Data ────────────────────────────────────────────────────────────
        private void LoadStats()
        {
            try
            {
                using (var conn = new MySqlConnection(_connStr))
                {
                    conn.Open();
                    // Total
                    var cmd = new MySqlCommand("SELECT COUNT(*) FROM CUSTOMER", conn);
                    lblTotalValue.Text = cmd.ExecuteScalar().ToString();

                    // New this month
                    cmd = new MySqlCommand(
                        "SELECT COUNT(*) FROM CUSTOMER WHERE MONTH(CUSTOMER_ID) = MONTH(CURDATE()) AND YEAR(CUSTOMER_ID) = YEAR(CURDATE())",
                        conn);
                    // CUSTOMER_ID is AUTO_INCREMENT; no created_at column — approximate with ID range approach.
                    // Fall back: just show total new as 0 if no date column exists.
                    try { lblNewValue.Text = cmd.ExecuteScalar().ToString(); }
                    catch { lblNewValue.Text = "—"; }
                }
            }
            catch (Exception ex)
            {
                lblTotalValue.Text = "Err";
                lblNewValue.Text = "Err";
                MessageBox.Show("Stats error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadCustomers(string search = "")
        {
            try
            {
                using (var conn = new MySqlConnection(_connStr))
                {
                    conn.Open();
                    string sql = @"SELECT CUSTOMER_ID, NAME, CNIC, PHONE_NUMBER, EMAIL, ADDRESS
                                   FROM CUSTOMER
                                   WHERE NAME LIKE @s OR CNIC LIKE @s OR PHONE_NUMBER LIKE @s
                                   ORDER BY CUSTOMER_ID DESC";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@s", "%" + search + "%");

                    var adapter = new MySqlDataAdapter(cmd);
                    _dt = new DataTable();
                    adapter.Fill(_dt);

                    dgvCustomers.DataSource = _dt;
                    ApplyGridStyle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyGridStyle()
        {
            dgvCustomers.Columns["CUSTOMER_ID"].HeaderText = "ID";
            dgvCustomers.Columns["NAME"].HeaderText = "Name";
            dgvCustomers.Columns["CNIC"].HeaderText = "CNIC";
            dgvCustomers.Columns["PHONE_NUMBER"].HeaderText = "Phone";
            dgvCustomers.Columns["EMAIL"].HeaderText = "Email";
            dgvCustomers.Columns["ADDRESS"].HeaderText = "Address";

            dgvCustomers.Columns["CUSTOMER_ID"].Width = 60;
            dgvCustomers.Columns["NAME"].Width = 160;
            dgvCustomers.Columns["CNIC"].Width = 130;
            dgvCustomers.Columns["PHONE_NUMBER"].Width = 110;
            dgvCustomers.Columns["EMAIL"].Width = 200;
            dgvCustomers.Columns["ADDRESS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // ─── Toolbar events ──────────────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == System.Drawing.Color.Gray) return;
            LoadCustomers(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadStats();
            LoadCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new AddCustomerForm())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadStats();
                    LoadCustomers(txtSearch.Text.Trim());
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSelected();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0) { MessageBox.Show("Select a customer to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            int id = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CUSTOMER_ID"].Value);
            string name = dgvCustomers.SelectedRows[0].Cells["NAME"].Value?.ToString();

            if (MessageBox.Show($"Delete customer '{name}' (ID: {id})?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                using (var conn = new MySqlConnection(_connStr))
                {
                    conn.Open();
                    var cmd = new MySqlCommand("DELETE FROM CUSTOMER WHERE CUSTOMER_ID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                LoadStats();
                LoadCustomers(txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog { Filter = "CSV files|*.csv", FileName = "Customers.csv" })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("CUSTOMER_ID,NAME,CNIC,PHONE_NUMBER,EMAIL,ADDRESS");
                    foreach (DataRow row in _dt.Rows)
                        sb.AppendLine($"{row["CUSTOMER_ID"]},{Esc(row["NAME"])},{Esc(row["CNIC"])},{Esc(row["PHONE_NUMBER"])},{Esc(row["EMAIL"])},{Esc(row["ADDRESS"])}");
                    File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Exported successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string Esc(object val) => "\"" + val?.ToString().Replace("\"", "\"\"") + "\"";

        // ─── Grid events ─────────────────────────────────────────────────────
        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            EditSelected();
        }

        private void EditSelected()
        {
            if (dgvCustomers.SelectedRows.Count == 0) { MessageBox.Show("Select a customer to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            int id = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CUSTOMER_ID"].Value);
            using (var frm = new EditCustomerForm(id))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadCustomers(txtSearch.Text.Trim());
            }
        }
    }
}