using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class AddEmployeeForm : Form
    {
        private const string ConnStr =
            "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.ForeColor == Color.Gray ? "" : txtName.Text.Trim();
            string cnic = txtCnic.ForeColor == Color.Gray ? "" : txtCnic.Text.Trim();
            string role = txtRole.ForeColor == Color.Gray ? "" : txtRole.Text.Trim();
            string loginId = txtLoginId.ForeColor == Color.Gray ? "" : txtLoginId.Text.Trim();
            string password = txtPassword.ForeColor == Color.Gray ? "" : txtPassword.Text.Trim();
            bool isActive = chkIsActive.Checked;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Full name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(cnic, @"^\d{13}$"))
            {
                MessageBox.Show("CNIC must be exactly 13 numeric digits.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(loginId))
            {
                MessageBox.Show("Login ID is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();
                    const string sql =
                        "INSERT INTO EMPLOYEE (NAME, CNIC, ROLE, LOGIN_ID, PASSWORD, IS_ACTIVE) " +
                        "VALUES (@name, @cnic, @role, @loginId, @password, @isActive)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@cnic", cnic);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@loginId", loginId);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@isActive", isActive);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Employee added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ── Name ─────────────────────────────────────────────────────────────
        private void txtName_GotFocus(object sender, EventArgs e)
        {
            if (txtName.ForeColor == Color.Gray)
            { txtName.Text = ""; txtName.ForeColor = Color.Black; }
        }
        private void txtName_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { txtName.Text = "Full Name"; txtName.ForeColor = Color.Gray; }
        }

        // ── CNIC ─────────────────────────────────────────────────────────────
        private void txtCnic_GotFocus(object sender, EventArgs e)
        {
            if (txtCnic.ForeColor == Color.Gray)
            { txtCnic.Text = ""; txtCnic.ForeColor = Color.Black; }
        }
        private void txtCnic_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCnic.Text))
            { txtCnic.Text = "13-digit CNIC"; txtCnic.ForeColor = Color.Gray; }
        }

        // ── Role ─────────────────────────────────────────────────────────────
        private void txtRole_GotFocus(object sender, EventArgs e)
        {
            if (txtRole.ForeColor == Color.Gray)
            { txtRole.Text = ""; txtRole.ForeColor = Color.Black; }
        }
        private void txtRole_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRole.Text))
            { txtRole.Text = "Role"; txtRole.ForeColor = Color.Gray; }
        }

        // ── Login ID ─────────────────────────────────────────────────────────
        private void txtLoginId_GotFocus(object sender, EventArgs e)
        {
            if (txtLoginId.ForeColor == Color.Gray)
            { txtLoginId.Text = ""; txtLoginId.ForeColor = Color.Black; }
        }
        private void txtLoginId_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoginId.Text))
            { txtLoginId.Text = "Login ID"; txtLoginId.ForeColor = Color.Gray; }
        }

        // ── Password ─────────────────────────────────────────────────────────
        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            if (txtPassword.ForeColor == Color.Gray)
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }
        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }
    }
}