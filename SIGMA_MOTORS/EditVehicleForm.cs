using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class EditVehicleForm : Form
    {
        string connString = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";
        private int _vehicleId;

        public EditVehicleForm(int vehicleId)
        {
            InitializeComponent();
            _vehicleId = vehicleId;
        }

        private void EditVehicleForm_Load(object sender, EventArgs e)
        {
            LoadDropdowns();
            LoadVehicleData();
        }

        // ════════════════════════════════════════════════════════════════════════
        //  LOAD DROPDOWNS
        // ════════════════════════════════════════════════════════════════════════

        private void LoadDropdowns()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Brands
                    FillCombo(cmbBrand, conn,
                        "SELECT BRAND_ID, BRAND_NAME FROM BRANDS WHERE IS_ACTIVE = 1",
                        "BRAND_NAME", "BRAND_ID");

                    // Models
                    FillCombo(cmbModel, conn,
                        "SELECT MODEL_ID, MODEL_NAME FROM MODELS WHERE IS_ACTIVE = 1",
                        "MODEL_NAME", "MODEL_ID");

                    // Variants
                    FillCombo(cmbVarient, conn,
                        "SELECT VARIENT_ID, VARIENT_NAME FROM VARIENTS WHERE IS_ACTIVE = 1",
                        "VARIENT_NAME", "VARIENT_ID");

                    // Status
                    cmbStatus.Items.Clear();
                    cmbStatus.Items.Add("Available");
                    cmbStatus.Items.Add("Sold");
                    cmbStatus.Items.Add("Reserved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dropdowns: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FillCombo(ComboBox cmb, MySqlConnection conn, string query, string display, string value)
        {
            cmb.Items.Clear();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    cmb.Items.Add(new ComboItem
                    {
                        Text = dr[display].ToString(),
                        Value = Convert.ToInt32(dr[value])
                    });
                }
            }
            if (cmb.Items.Count > 0) cmb.SelectedIndex = 0;
        }

        // ════════════════════════════════════════════════════════════════════════
        //  LOAD VEHICLE DATA
        // ════════════════════════════════════════════════════════════════════════

        private void LoadVehicleData()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT V.*, B.BRAND_NAME, M.MODEL_NAME, VR.VARIENT_NAME
                        FROM VEHICLE V
                        JOIN BRANDS   B  ON V.BRAND_ID   = B.BRAND_ID
                        JOIN MODELS   M  ON V.MODEL_ID   = M.MODEL_ID
                        JOIN VARIENTS VR ON V.VARIENT_ID = VR.VARIENT_ID
                        WHERE V.VEHICLE_ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _vehicleId);
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                // Set dropdowns by value
                                SetCombo(cmbBrand, Convert.ToInt32(dr["BRAND_ID"]));
                                SetCombo(cmbModel, Convert.ToInt32(dr["MODEL_ID"]));
                                SetCombo(cmbVarient, Convert.ToInt32(dr["VARIENT_ID"]));

                                txtColour.Text = dr["COLOUR"].ToString();
                                txtYear.Text = dr["MANUFACTURE_YEAR"].ToString();
                                txtPrice.Text = dr["PRICE"].ToString();
                                txtRegNo.Text = dr["REGISTRATION_NUMBER"].ToString();
                                cmbStatus.Text = dr["STATUS"].ToString();

                                lblVehicleId.Text = "Vehicle ID: " + _vehicleId;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading vehicle: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetCombo(ComboBox cmb, int value)
        {
            foreach (var item in cmb.Items)
            {
                if (item is ComboItem ci && ci.Value == value)
                {
                    cmb.SelectedItem = item;
                    return;
                }
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  SAVE
        // ════════════════════════════════════════════════════════════════════════

        private void btnSave_Click(object sender, EventArgs e)
        {
            // ── Validation ───────────────────────────────────────────────────────
            if (cmbBrand.SelectedItem == null || cmbModel.SelectedItem == null ||
                cmbVarient.SelectedItem == null)
            {
                MessageBox.Show("Please select Brand, Model and Variant.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtColour.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Colour, Year and Price are required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Price must be a valid number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtYear.Text, out int year) || year < 1990 || year > DateTime.Now.Year + 1)
            {
                MessageBox.Show("Enter a valid manufacture year.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int brandId = ((ComboItem)cmbBrand.SelectedItem).Value;
            int modelId = ((ComboItem)cmbModel.SelectedItem).Value;
            int varientId = ((ComboItem)cmbVarient.SelectedItem).Value;
            string status = cmbStatus.SelectedItem?.ToString() ?? "Available";
            string regNo = txtRegNo.Text.Trim();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = @"
                        UPDATE VEHICLE SET
                            BRAND_ID            = @brand,
                            MODEL_ID            = @model,
                            VARIENT_ID          = @varient,
                            COLOUR              = @colour,
                            MANUFACTURE_YEAR    = @year,
                            PRICE               = @price,
                            STATUS              = @status,
                            REGISTRATION_NUMBER = @reg
                        WHERE VEHICLE_ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@brand", brandId);
                        cmd.Parameters.AddWithValue("@model", modelId);
                        cmd.Parameters.AddWithValue("@varient", varientId);
                        cmd.Parameters.AddWithValue("@colour", txtColour.Text.Trim());
                        cmd.Parameters.AddWithValue("@year", year);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@reg", string.IsNullOrEmpty(regNo) ? (object)DBNull.Value : regNo);
                        cmd.Parameters.AddWithValue("@id", _vehicleId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Vehicle updated successfully!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // ── Helper class for ComboBox items ──────────────────────────────────────────
    public class ComboItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public override string ToString() => Text;
    }
}