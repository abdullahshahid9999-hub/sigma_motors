using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGMA_MOTORS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Pehle connection check karein ge, agar successful hua to hi Form open hoga
            if (TestDatabaseConnection())
            {
                Application.Run(new Form1());
            }
            else
            {
                // Agar connection fail hua to application band ho jaye gi
                Application.Exit();
            }
        }

        // Database connection test karne ka alag function
        static bool TestDatabaseConnection()
        {
            string connString = "Server=localhost;Port=3306;Database=SIGMA_MOTORS;Uid=root;Pwd=Pakistan@1947;";

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    // Agar console open na bhi ho, Windows Forms me yeh message box show ho jaye ga
                    MessageBox.Show("Database Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"General Error: {ex.Message}", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}