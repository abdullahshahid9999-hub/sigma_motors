using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Ensure MySql.Data NuGet package is installed

namespace SIGMA_MOTORS
{
    public partial class MainDashboardForm : Form
    {
        // 1. Apna password check karein. Agar Workbench ka password 'root' hai to sahi hai.
        string connString = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public MainDashboardForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainDashboardForm_Load);
        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy  |  hh:mm:ss tt");
        }

        public void RefreshDashboard()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Agar yahan tak aa gaya matlab connection OK hai

                    // 1. Total Available Cars
                    MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM VEHICLE WHERE STATUS = 'Available'", conn);
                    lblTotalCars.Text = cmd1.ExecuteScalar().ToString();

                    // 2. Monthly Sales
                    MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM SALE_TRANSCTION WHERE MONTH(SALE_DATE) = MONTH(CURDATE()) AND YEAR(SALE_DATE) = YEAR(CURDATE())", conn);
                    lblSales.Text = cmd2.ExecuteScalar().ToString();

                    // 3. Revenue
                    MySqlCommand cmd3 = new MySqlCommand("SELECT SUM(PRICE) FROM SALE_TRANSCTION WHERE MONTH(SALE_DATE) = MONTH(CURDATE()) AND YEAR(SALE_DATE) = YEAR(CURDATE())", conn);
                    var rev = cmd3.ExecuteScalar();
                    lblRevenue.Text = "Rs. " + (rev == DBNull.Value || rev == null ? "0" : Convert.ToDecimal(rev).ToString("#,##0"));

                    // 4. Expenses
                    MySqlCommand cmd4 = new MySqlCommand("SELECT SUM(PRICE) FROM PURCHASE_ORDERS WHERE MONTH(PURCHASE_DATE) = MONTH(CURDATE()) AND YEAR(PURCHASE_DATE) = YEAR(CURDATE())", conn);
                    var exp = cmd4.ExecuteScalar();
                    lblExpenses.Text = "Rs. " + (exp == DBNull.Value || exp == null ? "0" : Convert.ToDecimal(exp).ToString("#,##0"));

                    // 5. Recent Transactions Grid
                    string query = @"SELECT S.SALE_ID, C.NAME as Customer, V.COLOUR as Car, S.PRICE, S.SALE_DATE 
                                     FROM SALE_TRANSCTION S 
                                     JOIN VEHICLE V ON S.VEHICLE_ID = V.VEHICLE_ID 
                                     JOIN CUSTOMER C ON S.CUSTOMER_ID = C.CUSTOMER_ID 
                                     ORDER BY S.SALE_DATE DESC LIMIT 10";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRecentSales.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // Agar connection fail hua to ye bataye ga kyun hua
                    MessageBox.Show("Database Connection Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Navigation fix takay error khatam ho
        private void Navigation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Contains("Dashboard")) { RefreshDashboard(); }
            // Baki forms jab ban jayenge tab uncomment karna
            // else if (btn.Text.Contains("Inventory")) { loadform(new InventoryForm()); } 
        }
    }
}