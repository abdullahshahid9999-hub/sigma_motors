using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class EmployeeForm : Form
    {
        private const string ConnStr =
            "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public EmployeeForm()
        {
            InitializeComponent();
            dgvEmployees.DataError += (s, e) => e.Cancel = true;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadStats();
            LoadGrid();
        }

        private void LoadStats()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "SELECT COUNT(*) AS Total, SUM(IS_ACTIVE) AS Active FROM EMPLOYEE", conn))
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            lblTotal.Text = "Total: " + rdr["Total"];
                            lblActive.Text = "Active: " + rdr["Active"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stats error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGrid(string nameFilter = "", string cnicFilter = "")
        {
            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();
                    const string sql =
                        "SELECT EMPLOYEE_ID, NAME, CNIC, ROLE, IS_ACTIVE " +
                        "FROM EMPLOYEE WHERE NAME LIKE @n AND CNIC LIKE @c";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@n", "%" + nameFilter + "%");
                        cmd.Parameters.AddWithValue("@c", "%" + cnicFilter + "%");

                        var adapter = new MySqlDataAdapter(cmd);
                        var dt = new DataTable();
                        adapter.Fill(dt);

                        // Convert IS_ACTIVE to bool DataColumn before binding
                        if (dt.Columns.Contains("IS_ACTIVE"))
                        {
                            int ordinal = dt.Columns["IS_ACTIVE"].Ordinal;
                            var boolCol = new DataColumn("IS_ACTIVE_B", typeof(bool));
                            dt.Columns.Add(boolCol);
                            foreach (DataRow row in dt.Rows)
                                row["IS_ACTIVE_B"] = Convert.ToBoolean(row["IS_ACTIVE"]);
                            dt.Columns.Remove("IS_ACTIVE");
                            boolCol.ColumnName = "IS_ACTIVE";
                            boolCol.SetOrdinal(ordinal);
                        }

                        dgvEmployees.DataSource = dt;

                        if (dgvEmployees.Columns["EMPLOYEE_ID"] != null)
                        {
                            dgvEmployees.Columns["EMPLOYEE_ID"].HeaderText = "ID";
                            dgvEmployees.Columns["EMPLOYEE_ID"].Width = 55;
                        }
                        if (dgvEmployees.Columns["NAME"] != null)
                            dgvEmployees.Columns["NAME"].HeaderText = "Name";
                        if (dgvEmployees.Columns["CNIC"] != null)
                            dgvEmployees.Columns["CNIC"].HeaderText = "CNIC";
                        if (dgvEmployees.Columns["ROLE"] != null)
                            dgvEmployees.Columns["ROLE"].HeaderText = "Role";
                        if (dgvEmployees.Columns["IS_ACTIVE"] != null)
                        {
                            dgvEmployees.Columns["IS_ACTIVE"].HeaderText = "Active";
                            dgvEmployees.Columns["IS_ACTIVE"].Width = 65;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.ForeColor == Color.Gray ? "" : txtSearchName.Text.Trim();
            string cnic = txtSearchCnic.ForeColor == Color.Gray ? "" : txtSearchCnic.Text.Trim();
            LoadGrid(name, cnic);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var f = new AddEmployeeForm())
                f.ShowDialog(this);
            LoadStats();
            LoadGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Select an employee to edit.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EMPLOYEE_ID"].Value);
            using (var f = new EditEmployeeForm(id))
                f.ShowDialog(this);
            LoadStats();
            LoadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Select an employee to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Delete this employee?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EMPLOYEE_ID"].Value);
                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(
                        "DELETE FROM EMPLOYEE WHERE EMPLOYEE_ID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Employee deleted.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStats();
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = "CSV Files|*.csv",
                FileName = "Employees_" + DateTime.Now.ToString("yyyyMMdd")
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            try
            {
                var dt = dgvEmployees.DataSource as DataTable;
                if (dt == null) return;
                using (var sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("ID,Name,CNIC,Role,Is Active");
                    foreach (DataRow row in dt.Rows)
                        sw.WriteLine(
                            $"\"{row["EMPLOYEE_ID"]}\"," +
                            $"\"{row["NAME"]}\"," +
                            $"\"{row["CNIC"]}\"," +
                            $"\"{row["ROLE"]}\"," +
                            $"\"{row["IS_ACTIVE"]}\"");
                }
                MessageBox.Show("Exported successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Search Name placeholder ──────────────────────────────────────────
        private void txtSearchName_GotFocus(object sender, EventArgs e)
        {
            if (txtSearchName.ForeColor == Color.Gray)
            { txtSearchName.Text = ""; txtSearchName.ForeColor = Color.Black; }
        }
        private void txtSearchName_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchName.Text))
            { txtSearchName.Text = "Search by Name..."; txtSearchName.ForeColor = Color.Gray; }
        }

        // ── Search CNIC placeholder ──────────────────────────────────────────
        private void txtSearchCnic_GotFocus(object sender, EventArgs e)
        {
            if (txtSearchCnic.ForeColor == Color.Gray)
            { txtSearchCnic.Text = ""; txtSearchCnic.ForeColor = Color.Black; }
        }
        private void txtSearchCnic_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchCnic.Text))
            { txtSearchCnic.Text = "Search by CNIC..."; txtSearchCnic.ForeColor = Color.Gray; }
        }
    }
}