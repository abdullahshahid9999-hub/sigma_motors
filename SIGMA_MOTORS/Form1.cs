using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form load hote hi cursor username box mein jayega
        private void Form1_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        // Username focus effects
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = Color.Black;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.Gray;
            txtUsername.ForeColor = Color.White;
        }

        // Password focus effects
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.Black;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.Gray;
            txtPassword.ForeColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check empty fields
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Fields cannot be empty.");
                return;
            }

            string connString = "Server=localhost;Port=3306;Database=SIGMA_MOTORS;Uid=root;Pwd=Pakistan@1947;";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                // EMPLOYEE_ID aur NAME bhi fetch kar rahe hain SessionManager ke liye
                string query = @"SELECT EMPLOYEE_ID, NAME, ROLE 
                                 FROM EMPLOYEE 
                                 WHERE LOGIN_ID = @user 
                                   AND PASSWORD = @pass 
                                   AND IS_ACTIVE = 1";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                    try
                    {
                        connection.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            // Session mein employee ki info save karo
                            SessionManager.EmployeeId = Convert.ToInt32(dr["EMPLOYEE_ID"]);
                            SessionManager.EmployeeName = dr["NAME"].ToString();
                            SessionManager.Role = dr["ROLE"].ToString();

                            dr.Close();

                            MessageBox.Show("Welcome " + SessionManager.EmployeeName +
                                            " (" + SessionManager.Role + ")");

                            // Dashboard open karo
                            Dashboard dash = new Dashboard();
                            dash.Show();
                            this.Hide();
                        }
                        else
                        {
                            dr.Close();
                            MessageBox.Show("Invalid Login ID or Password.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }
        }
    }
}