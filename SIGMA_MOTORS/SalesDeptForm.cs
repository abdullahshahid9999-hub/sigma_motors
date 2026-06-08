using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class SalesDeptForm : Form
    {
        // Connection String
        string connStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public SalesDeptForm()
        {
            InitializeComponent();

            // Events ko manually link kar rahe hain taake button 100% chale
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);

            LoadRecentSales(); // Form load hotay hi data dikhay ga
        }

        // --- Data Loading Logic ---
        private void LoadRecentSales()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string query = @"
                        SELECT 
                            s.SALE_ID AS 'Sales ID', 
                            c.NAME AS 'CUSTOMER NAME', 
                            b.BRAND_NAME AS 'CAR BRAND', 
                            m.MODEL_NAME AS 'CAR MODEL', 
                            v.VARIENT_NAME AS 'CAR VARIANT', 
                            s.EMPLOYEE_NAME AS 'EMPLOYEE', 
                            s.SALE_DATE AS 'SALE DATE', 
                            s.PAYMENT_STATUS AS 'PAYMENT STATUS'
                        FROM SALE_TRANSCTION s
                        JOIN CUSTOMER c ON s.CUSTOMER_ID = c.CUSTOMER_ID
                        JOIN VEHICLE vh ON s.VEHICLE_ID = vh.VEHICLE_ID
                        JOIN BRANDS b ON vh.BRAND_ID = b.BRAND_ID
                        JOIN MODELS m ON vh.MODEL_ID = m.MODEL_ID
                        JOIN VARIENTS v ON vh.VARIENT_ID = v.VARIENT_ID
                        ORDER BY s.SALE_DATE DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Sales: " + ex.Message);
            }
        }

        // --- Add Sales Button Logic ---
        private void btnAddSales_Click(object sender, EventArgs e)
        {
            // AddSales form ka object
            AddSales salesForm = new AddSales();

            // Modal window ke taur par kholna
            salesForm.ShowDialog();

            // FIX: Function ka sahi naam call karein taake refresh ho
            LoadRecentSales();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}