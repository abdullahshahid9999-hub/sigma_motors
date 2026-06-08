using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class AddCustomerForm : Form
    {
        private readonly string _connStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { ShowErr("Name is required."); txtName.Focus(); return false; }

            if (!Regex.IsMatch(txtCNIC.Text.Trim(), @"^\d{13}$"))
            { ShowErr("CNIC must be exactly 13 digits (numbers only)."); txtCNIC.Focus(); return false; }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{11}$"))
            { ShowErr("Phone must be exactly 11 digits (numbers only)."); txtPhone.Focus(); return false; }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) &&
                !Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            { ShowErr("Enter a valid Email address."); txtEmail.Focus(); return false; }

            return true;
        }

        private void ShowErr(string msg) =>
            MessageBox.Show(msg, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                using (var conn = new MySqlConnection(_connStr))
                {
                    conn.Open();
                    // Explicitly NOT inserting CUSTOMER_ID — let AUTO_INCREMENT handle it
                    var sql = @"INSERT INTO CUSTOMER (NAME, CNIC, PHONE_NUMBER, EMAIL, ADDRESS)
                                VALUES (@name, @cnic, @phone, @email, @addr)";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@addr", txtAddress.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Customer added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                ShowErr("A customer with this CNIC already exists.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pnlBody_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
    }
}