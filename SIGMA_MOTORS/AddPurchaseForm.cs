using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class AddPurchaseForm : Form
    {
        string connString = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";

        public AddPurchaseForm()
        {
            InitializeComponent();
        }

        private void AddPurchaseForm_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            LoadSuppliers();
            LoadBrands();
        }

        // ════════════════════════════════════════════════════════════════════════
        //  DROPDOWN LOADERS
        // ════════════════════════════════════════════════════════════════════════

        private void LoadSuppliers()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                FillCombo(cmbSupplier, conn,
                    "SELECT SUPPLIER_ID, COMPANY_NAME FROM SUPPLIER WHERE IS_ACTIVE = 1",
                    "COMPANY_NAME", "SUPPLIER_ID");
            }
        }

        private void LoadBrands()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                FillCombo(cmbBrand, conn,
                    "SELECT BRAND_ID, BRAND_NAME FROM BRANDS WHERE IS_ACTIVE = 1",
                    "BRAND_NAME", "BRAND_ID");
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBrand.SelectedItem == null) return;
            int brandId = ((ComboItem)cmbBrand.SelectedItem).Value;

            cmbModel.Items.Clear();
            cmbVarient.Items.Clear();
            txtEngine.Text = "";
            txtBody.Text = "";
            txtOrigin.Text = "";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                FillCombo(cmbModel, conn,
                    $"SELECT MODEL_ID, MODEL_NAME FROM MODELS WHERE BRAND_ID = {brandId} AND IS_ACTIVE = 1",
                    "MODEL_NAME", "MODEL_ID");

                // Brand origin
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT COUNTRY_OF_ORIGIN FROM BRANDS WHERE BRAND_ID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", brandId);
                    txtOrigin.Text = cmd.ExecuteScalar()?.ToString() ?? "";
                }
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModel.SelectedItem == null) return;
            int modelId = ((ComboItem)cmbModel.SelectedItem).Value;

            cmbVarient.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                FillCombo(cmbVarient, conn,
                    $"SELECT VARIENT_ID, VARIENT_NAME FROM VARIENTS WHERE MODEL_ID = {modelId} AND IS_ACTIVE = 1",
                    "VARIENT_NAME", "VARIENT_ID");

                // Engine & body
                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT ENGINE_DISPLACEMENT, BODY_TYPE FROM MODELS WHERE MODEL_ID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", modelId);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtEngine.Text = dr["ENGINE_DISPLACEMENT"].ToString() + " cc";
                            txtBody.Text = dr["BODY_TYPE"].ToString();
                        }
                    }
                }
            }
        }

        private void FillCombo(ComboBox cmb, MySqlConnection conn, string query,
            string display, string value)
        {
            cmb.Items.Clear();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                    cmb.Items.Add(new ComboItem
                    {
                        Text = dr[display].ToString(),
                        Value = Convert.ToInt32(dr[value])
                    });
            }
            if (cmb.Items.Count > 0) cmb.SelectedIndex = 0;
        }

        // ════════════════════════════════════════════════════════════════════════
        //  SAVE — Vehicle add to inventory + Purchase Order create
        // ════════════════════════════════════════════════════════════════════════

        private void btnSave_Click(object sender, EventArgs e)
        {
            // ── Validation ───────────────────────────────────────────────────────
            if (cmbSupplier.SelectedItem == null)
            { MessageBox.Show("Please select a Supplier.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (cmbBrand.SelectedItem == null || cmbModel.SelectedItem == null || cmbVarient.SelectedItem == null)
            { MessageBox.Show("Please select Brand, Model and Variant.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrWhiteSpace(txtColour.Text))
            { MessageBox.Show("Please enter Colour.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!int.TryParse(txtYear.Text, out int year) || year < 1990 || year > DateTime.Now.Year + 1)
            { MessageBox.Show("Enter a valid Manufacture Year.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            { MessageBox.Show("Enter a valid Purchase Price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int supplierId = ((ComboItem)cmbSupplier.SelectedItem).Value;
            int brandId = ((ComboItem)cmbBrand.SelectedItem).Value;
            int modelId = ((ComboItem)cmbModel.SelectedItem).Value;
            int varientId = ((ComboItem)cmbVarient.SelectedItem).Value;
            int empId = SessionManager.EmployeeId;
            string regNo = txtRegNo.Text.Trim();

            DialogResult confirm = MessageBox.Show(
                $"Add this vehicle to inventory and create Purchase Order?\n\n" +
                $"Supplier : {cmbSupplier.Text}\n" +
                $"Vehicle  : {cmbBrand.Text} {cmbModel.Text} {cmbVarient.Text}\n" +
                $"Price    : PKR {price:N0}",
                "Confirm Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlTransaction tx = null;

            try
            {
                conn.Open();
                tx = conn.BeginTransaction();

                // ── 1. Insert vehicle into VEHICLE (inventory) ────────────────────
                int vehicleId;
                string insertVehicle = @"
                    INSERT INTO VEHICLE
                        (BRAND_ID, MODEL_ID, VARIENT_ID, REGISTRATION_NUMBER,
                         COLOUR, MANUFACTURE_YEAR, PRICE, STATUS)
                    VALUES
                        (@brand, @model, @varient, @reg,
                         @colour, @year, @price, 'Available')";

                using (MySqlCommand cmd = new MySqlCommand(insertVehicle, conn, tx))
                {
                    cmd.Parameters.AddWithValue("@brand", brandId);
                    cmd.Parameters.AddWithValue("@model", modelId);
                    cmd.Parameters.AddWithValue("@varient", varientId);
                    cmd.Parameters.AddWithValue("@reg", string.IsNullOrEmpty(regNo) ? (object)DBNull.Value : regNo);
                    cmd.Parameters.AddWithValue("@colour", txtColour.Text.Trim());
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.ExecuteNonQuery();
                    vehicleId = (int)cmd.LastInsertedId;
                }

                // ── 2. Create PURCHASE_ORDER ──────────────────────────────────────
                string insertPO = @"
                    INSERT INTO PURCHASE_ORDERS
                        (VEHICLE_ID, SUPPLIER_ID, EMPLOYEE_ID, PRICE, PURCHASE_DATE, STATUS)
                    VALUES
                        (@vid, @sid, @eid, @price, @date, 'Pending')";

                using (MySqlCommand cmd = new MySqlCommand(insertPO, conn, tx))
                {
                    cmd.Parameters.AddWithValue("@vid", vehicleId);
                    cmd.Parameters.AddWithValue("@sid", supplierId);
                    cmd.Parameters.AddWithValue("@eid", empId);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();

                MessageBox.Show(
                    $"Purchase Order created!\nVehicle added to Inventory (ID: {vehicleId})\nStatus: Pending (Finance will update on payment)",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                tx?.Rollback();
                MessageBox.Show("Failed & rolled back.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}