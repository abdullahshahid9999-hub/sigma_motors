using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class EditSupplierForm : Form
    {
        private readonly string _connStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";
        private readonly int _supplierId;

        public EditSupplierForm(int supplierId)
        {
            _supplierId = supplierId;
            InitializeComponent();
            LoadSupplier();
        }

        private void LoadSupplier()
        {
            try
            {
                using (var conn = new MySqlConnection(_connStr))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "SELECT COMPANY_NAME, PHONE_NUMBER, NTN, ADDRESS, IS_ACTIVE FROM SUPPLIER WHERE SUPPLIER_ID=@id",
                        conn);
                    cmd.Parameters.AddWithValue("@id", _supplierId);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            txtCompanyName.Text = rdr["COMPANY_NAME"]?.ToString();
                            txtPhone.Text = rdr["PHONE_NUMBER"]?.ToString();
                            txtNTN.Text = rdr["NTN"]?.ToString();
                            txtAddress.Text = rdr["ADDRESS"]?.ToString();
                            chkIsActive.Checked = rdr["IS_ACTIVE"] != DBNull.Value && Convert.ToBoolean(rdr["IS_ACTIVE"]);
                        }
                        else
                        {
                            MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var sql = @"UPDATE SUPPLIER SET
                                    COMPANY_NAME=@name, PHONE_NUMBER=@phone,
                                    NTN=@ntn, ADDRESS=@addr, IS_ACTIVE=@active
                                WHERE SUPPLIER_ID=@id";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", txtCompanyName.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@ntn", txtNTN.Text.Trim());
                    cmd.Parameters.AddWithValue("@addr", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@active", chkIsActive.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", _supplierId);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                ShowErr("A supplier with this Company Name already exists.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            chkIsActive.Checked = !chkIsActive.Checked;
            UpdateToggleButton();
        }

        private void UpdateToggleButton()
        {
            if (chkIsActive.Checked)
            {
                btnToggleActive.Text = "Set Inactive";
                btnToggleActive.BackColor = System.Drawing.Color.FromArgb(180, 0, 0);
            }
            else
            {
                btnToggleActive.Text = "Set Active";
                btnToggleActive.BackColor = System.Drawing.Color.FromArgb(0, 150, 0);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}