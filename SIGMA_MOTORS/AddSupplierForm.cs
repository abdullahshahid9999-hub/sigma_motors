using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class AddSupplierForm : Form
    {
        private readonly string _connStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            { ShowErr("Company Name is required."); txtCompanyName.Focus(); return false; }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^\d{11}$"))
            { ShowErr("Phone must be exactly 11 digits (numbers only)."); txtPhone.Focus(); return false; }

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
                    var sql = @"INSERT INTO SUPPLIER (COMPANY_NAME, PHONE_NUMBER, NTN, ADDRESS, IS_ACTIVE)
                                VALUES (@name, @phone, @ntn, @addr, @active)";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", txtCompanyName.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@ntn", txtNTN.Text.Trim());
                    cmd.Parameters.AddWithValue("@addr", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@active", chkIsActive.Checked ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Supplier added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                ShowErr("A supplier with this Company Name already exists.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}