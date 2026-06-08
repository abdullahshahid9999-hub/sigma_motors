using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class SupplierForm : Form
    {
        private readonly string _conn = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";
        private DataTable _dt = new DataTable();
        private bool _wired = false;

        public SupplierForm() { InitializeComponent(); }

        // Designer wires: this.Load += SupplierForm_Load
        private void SupplierForm_Load(object sender, EventArgs e) => Boot();

        private void Boot()
        {
            if (!_wired)
            {
                dgvSuppliers.CellFormatting += OnCellFormatting;
                dgvSuppliers.DataError += (s, e) => e.Cancel = true;
                _wired = true;
            }
            LoadStats();
            LoadGrid();
        }

        // ── Stats ─────────────────────────────────────────────────────────────
        private void LoadStats()
        {
            try
            {
                using (var c = new MySqlConnection(_conn))
                {
                    c.Open();
                    lblTotalValue.Text = Scalar("SELECT COUNT(*) FROM SUPPLIER", c);
                    lblActiveValue.Text = Scalar("SELECT COUNT(*) FROM SUPPLIER WHERE IS_ACTIVE=1", c);
                }
            }
            catch { lblTotalValue.Text = lblActiveValue.Text = "—"; }
        }

        private string Scalar(string sql, MySqlConnection c)
            => new MySqlCommand(sql, c).ExecuteScalar().ToString();

        // ── Grid ──────────────────────────────────────────────────────────────
        private void LoadGrid(string search = "")
        {
            try
            {
                using (var c = new MySqlConnection(_conn))
                {
                    c.Open();
                    var cmd = new MySqlCommand(
                        @"SELECT SUPPLIER_ID, COMPANY_NAME, PHONE_NUMBER, NTN, ADDRESS, IS_ACTIVE
                          FROM SUPPLIER
                          WHERE COMPANY_NAME LIKE @s OR PHONE_NUMBER LIKE @s OR NTN LIKE @s
                          ORDER BY SUPPLIER_ID DESC", c);
                    cmd.Parameters.AddWithValue("@s", "%" + search + "%");

                    _dt = new DataTable();
                    new MySqlDataAdapter(cmd).Fill(_dt);

                    // Convert IS_ACTIVE (MySQL tinyint/sbyte) → bool to prevent FormatException
                    if (_dt.Columns.Contains("IS_ACTIVE"))
                    {
                        var bc = new DataColumn("IS_ACTIVE_B", typeof(bool));
                        _dt.Columns.Add(bc);
                        foreach (DataRow r in _dt.Rows)
                            r["IS_ACTIVE_B"] = r["IS_ACTIVE"] != DBNull.Value && Convert.ToBoolean(r["IS_ACTIVE"]);
                        _dt.Columns.Remove("IS_ACTIVE");
                        bc.ColumnName = "IS_ACTIVE";
                    }

                    dgvSuppliers.DataSource = null;
                    dgvSuppliers.DataSource = _dt;
                    SetColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetColumns()
        {
            if (dgvSuppliers.Columns.Count == 0) return;
            Col("SUPPLIER_ID", "ID", 60);
            Col("COMPANY_NAME", "Company Name", 200);
            Col("PHONE_NUMBER", "Phone", 115);
            Col("NTN", "NTN", 120);
            Col("IS_ACTIVE", "Status", 85);
            if (dgvSuppliers.Columns.Contains("ADDRESS"))
                dgvSuppliers.Columns["ADDRESS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Col(string n, string h, int w)
        {
            if (!dgvSuppliers.Columns.Contains(n)) return;
            dgvSuppliers.Columns[n].HeaderText = h;
            dgvSuppliers.Columns[n].Width = w;
        }

        private void OnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            if (dgvSuppliers.Columns[e.ColumnIndex].Name != "IS_ACTIVE") return;
            try
            {
                bool a = Convert.ToBoolean(e.Value);
                e.Value = a ? "Active" : "Inactive";
                e.CellStyle.ForeColor = a ? Color.FromArgb(0, 150, 0) : Color.FromArgb(180, 0, 0);
                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                e.FormattingApplied = true;
            }
            catch { e.FormattingApplied = true; }
        }

        // ── Toolbar events ────────────────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Gray) return;
            LoadGrid(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search by Company, Phone, NTN...";
            txtSearch.ForeColor = Color.Gray;
            LoadStats();
            LoadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var f = new AddSupplierForm())
                if (f.ShowDialog() == DialogResult.OK) Reload();
        }

        private void btnEdit_Click(object sender, EventArgs e) => EditSelected();
        private void btnDelete_Click(object sender, EventArgs e) => DeleteSelected();
        private void btnExport_Click(object sender, EventArgs e) => ExportCsv();

        private void dgvSuppliers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) EditSelected();
        }

        // ── Actions ───────────────────────────────────────────────────────────
        private string SearchText() =>
            txtSearch.ForeColor == Color.Gray ? "" : txtSearch.Text.Trim();

        private void Reload() { LoadStats(); LoadGrid(SearchText()); }

        private void EditSelected()
        {
            if (dgvSuppliers.SelectedRows.Count == 0) { Msg("Select a supplier to edit."); return; }
            int id = ToInt("SUPPLIER_ID");
            using (var f = new EditSupplierForm(id))
                if (f.ShowDialog() == DialogResult.OK) Reload();
        }

        private void DeleteSelected()
        {
            if (dgvSuppliers.SelectedRows.Count == 0) { Msg("Select a supplier to delete."); return; }
            int id = ToInt("SUPPLIER_ID");
            string name = dgvSuppliers.SelectedRows[0].Cells["COMPANY_NAME"].Value?.ToString();
            if (MessageBox.Show($"Delete '{name}'?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                using (var c = new MySqlConnection(_conn))
                {
                    c.Open();
                    var cmd = new MySqlCommand("DELETE FROM SUPPLIER WHERE SUPPLIER_ID=@id", c);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                Reload();
            }
            catch (Exception ex) { MessageBox.Show("Delete failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ExportCsv()
        {
            using (var dlg = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "Suppliers.csv" })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                var sb = new StringBuilder("ID,Company,Phone,NTN,Address,Active\r\n");
                foreach (DataRow r in _dt.Rows)
                    sb.AppendLine($"{r["SUPPLIER_ID"]},{Q(r["COMPANY_NAME"])},{Q(r["PHONE_NUMBER"])},{Q(r["NTN"])},{Q(r["ADDRESS"])},{r["IS_ACTIVE"]}");
                File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);
                Msg("Exported successfully.");
            }
        }

        private int ToInt(string col) => Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells[col].Value);
        private void Msg(string m) => MessageBox.Show(m, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private string Q(object v) => "\"" + v?.ToString().Replace("\"", "\"\"") + "\"";
    }
}