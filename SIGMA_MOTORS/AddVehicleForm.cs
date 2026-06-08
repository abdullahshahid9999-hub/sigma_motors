using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class AddVehicleForm : Form
    {
        string connString = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public AddVehicleForm()
        {
            InitializeComponent();
            LoadDropdowns();
        }

        private void LoadDropdowns()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                // Brand load karein
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT BRAND_ID, BRAND_NAME FROM BRANDS", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBrand.DataSource = dt;
                cmbBrand.DisplayMember = "BRAND_NAME";
                cmbBrand.ValueMember = "BRAND_ID";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Manual ID entry for testing (Ya auto-increment set karein database mein)
                    string query = @"INSERT INTO VEHICLE (VEHICLE_ID, BRAND_ID, MODEL_ID, VARIENT_ID, COLOUR, MANUFACTURE_YEAR, PRICE, STATUS) 
                                     VALUES ((SELECT IFNULL(MAX(VEHICLE_ID), 0) + 1 FROM VEHICLE V), @bid, 1, 1, @col, @yr, @pr, 'Available')";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@bid", cmbBrand.SelectedValue);
                    cmd.Parameters.AddWithValue("@col", txtColour.Text);
                    cmd.Parameters.AddWithValue("@yr", txtYear.Text);
                    cmd.Parameters.AddWithValue("@pr", txtPrice.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle Added Successfully!");
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {

        }
    }
}