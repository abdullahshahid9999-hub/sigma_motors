using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class EditCustomerForm : Form
    {
        private readonly string _connStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";
        private readonly int _customerId;

        public EditCustomerForm(int customerId)
        {
            _customerId = customerId;
            InitializeComponent();
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            try
            {
                using (var conn = new MySqlConnection(_connStr))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "SELECT NAME, CNIC, PHONE_NUMBER, EMAIL, ADDRESS FROM CUSTOMER WHERE CUSTOMER_ID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", _customerId);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            txtName.Text = rdr["NAME"]?.ToString();
                            txtCNIC.Text = rdr["CNIC"]?.ToString();
                            txtPhone.Text = rdr["PHONE_NUMBER"]?.ToString();
                            txtEmail.Text = rdr["EMAIL"]?.ToString();
                            txtAddress.Text = rdr["ADDRESS"]?.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private bool Validate()
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
            if (!Validate()) return;
            try
            {
                using (var conn = new MySqlConnection(_connStr))
                {
                    conn.Open();
                    var sql = @"UPDATE CUSTOMER SET
                                    NAME=@name, CNIC=@cnic, PHONE_NUMBER=@phone,
                                    EMAIL=@email, ADDRESS=@addr
                                WHERE CUSTOMER_ID=@id";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@cnic", txtCNIC.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@addr", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", _customerId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                ShowErr("A customer with this CNIC already exists.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}