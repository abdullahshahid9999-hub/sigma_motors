using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class AddSales : Form
    {
        // ─── DB Connection ────────────────────────────────────────────────────────
        private string connStr = "Server=localhost;Port=3306;Database=SIGMA_MOTORS;Uid=root;Pwd=Pakistan@1947;";

        // ─── State ────────────────────────────────────────────────────────────────
        private int selectedVehicleId = -1;
        private int selectedCustomerId = -1;

        public AddSales()
        {
            InitializeComponent();
            SetDateTime();
            WireEvents();
            LoadCarAutocomplete();
            LoadCustomerAutocomplete();
        }

        // ════════════════════════════════════════════════════════════════════════
        //  INIT
        // ════════════════════════════════════════════════════════════════════════

        private void SetDateTime()
        {
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += (s, e) => txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
            t.Start();
        }

        private void WireEvents()
        {
            txtDiscount.TextChanged += (s, e) => CalculateSoldPrice();
            txtDemandRight.TextChanged += (s, e) => CalculateSoldPrice();
        }

        // ════════════════════════════════════════════════════════════════════════
        //  AUTOCOMPLETE — CAR (Registration Number)
        // ════════════════════════════════════════════════════════════════════════

        private void LoadCarAutocomplete()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string q = "SELECT REGISTRATION_NUMBER FROM VEHICLE WHERE STATUS = 'Available' AND REGISTRATION_NUMBER IS NOT NULL";
                    using (MySqlCommand cmd = new MySqlCommand(q, conn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                        while (dr.Read())
                            col.Add(dr["REGISTRATION_NUMBER"].ToString());

                        txtCarIdManual.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtCarIdManual.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtCarIdManual.AutoCompleteCustomSource = col;
                    }
                }
            }
            catch { /* silent — autocomplete optional */ }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  AUTOCOMPLETE — CUSTOMER (Name)
        // ════════════════════════════════════════════════════════════════════════

        private void LoadCustomerAutocomplete()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string q = "SELECT NAME FROM CUSTOMER";
                    using (MySqlCommand cmd = new MySqlCommand(q, conn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                        while (dr.Read())
                            col.Add(dr["NAME"].ToString());

                        txtCustSearchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtCustSearchName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtCustSearchName.AutoCompleteCustomSource = col;
                    }
                }
            }
            catch { /* silent */ }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  SEARCH CAR — by Registration Number
        // ════════════════════════════════════════════════════════════════════════

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            string regNo = txtCarIdManual.Text.Trim();
            if (string.IsNullOrEmpty(regNo))
            {
                MessageBox.Show("Please enter a Registration Number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT
                            v.VEHICLE_ID,          v.COLOUR,
                            v.MANUFACTURE_YEAR,    v.PRICE,
                            v.REGISTRATION_NUMBER,
                            b.BRAND_NAME,          b.COUNTRY_OF_ORIGIN,
                            m.MODEL_NAME,          m.BODY_TYPE,
                            m.ENGINE_DISPLACEMENT,
                            vr.VARIENT_NAME
                        FROM VEHICLE   v
                        JOIN BRANDS    b  ON v.BRAND_ID   = b.BRAND_ID
                        JOIN MODELS    m  ON v.MODEL_ID   = m.MODEL_ID
                        JOIN VARIENTS  vr ON v.VARIENT_ID = vr.VARIENT_ID
                        WHERE v.REGISTRATION_NUMBER = @reg
                          AND v.STATUS = 'Available'
                        LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@reg", regNo);
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                selectedVehicleId = Convert.ToInt32(dr["VEHICLE_ID"]);
                                txtCarId.Text = dr["VEHICLE_ID"].ToString();
                                txtBrand.Text = dr["BRAND_NAME"].ToString();
                                txtModel.Text = dr["MODEL_NAME"].ToString();
                                txtVarient.Text = dr["VARIENT_NAME"].ToString();
                                txtColor.Text = dr["COLOUR"].ToString();
                                txtYear.Text = dr["MANUFACTURE_YEAR"].ToString();
                                txtEngine.Text = dr["ENGINE_DISPLACEMENT"].ToString() + " cc";
                                txtBody.Text = dr["BODY_TYPE"].ToString();
                                txtOrigin.Text = dr["COUNTRY_OF_ORIGIN"].ToString();
                                txtDemand.Text = dr["PRICE"].ToString();
                                txtDemandRight.Text = dr["PRICE"].ToString();
                                CalculateSoldPrice();
                            }
                            else
                            {
                                MessageBox.Show("No available vehicle found with this Registration Number.",
                                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearCarFields();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  SEARCH CUSTOMER
        // ════════════════════════════════════════════════════════════════════════

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string name = txtCustSearchName.Text.Trim();
            string cnic = txtCustSearchCnic.Text.Trim();

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(cnic))
            {
                MessageBox.Show("Enter Name or CNIC to search.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT * FROM CUSTOMER
                        WHERE (@name = '' OR NAME LIKE @nameLike)
                          AND (@cnic = '' OR CNIC = @cnic)
                        LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@nameLike", "%" + name + "%");
                        cmd.Parameters.AddWithValue("@cnic", cnic);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                selectedCustomerId = Convert.ToInt32(dr["CUSTOMER_ID"]);
                                txtCustId.Text = dr["CUSTOMER_ID"].ToString();
                                txtCustName.Text = dr["NAME"].ToString();
                                txtCustCnic.Text = dr["CNIC"].ToString();
                                txtCustCell.Text = dr["PHONE_NUMBER"].ToString();
                                txtCustAddress.Text = dr["ADDRESS"].ToString();
                                txtCustEmail.Text = dr["EMAIL"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Customer not found.", "Not Found",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearCustomerFields();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  SOLD PRICE AUTO-CALCULATE
        // ════════════════════════════════════════════════════════════════════════

        private void CalculateSoldPrice()
        {
            decimal demand = 0, discount = 0;
            decimal.TryParse(txtDemandRight.Text, out demand);
            decimal.TryParse(txtDiscount.Text, out discount);
            txtSoldPrice.Text = Math.Max(0, demand - discount).ToString("F2");
        }

        // ════════════════════════════════════════════════════════════════════════
        //  FINALIZE DEAL
        // ════════════════════════════════════════════════════════════════════════

        private void btnFinalizeDeal_Click(object sender, EventArgs e)
        {
            if (selectedVehicleId == -1)
            {
                MessageBox.Show("Please search and select a vehicle first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Please search and select a customer first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtSoldPrice.Text, out decimal soldPrice) || soldPrice <= 0)
            {
                MessageBox.Show("Invalid sold price.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal.TryParse(txtDiscount.Text, out decimal discount);
            decimal.TryParse(txtDemandRight.Text, out decimal demand);

            int empId = SessionManager.EmployeeId;
            string empName = SessionManager.EmployeeName;

            DialogResult confirm = MessageBox.Show(
                $"Finalize sale of Vehicle #{selectedVehicleId} to {txtCustName.Text} for PKR {soldPrice:N0}?",
                "Confirm Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlTransaction tx = null;

            try
            {
                conn.Open();
                tx = conn.BeginTransaction();

                // ── 1. SALE_TRANSCTION insert ─────────────────────────────────────
                int saleId;
                using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO SALE_TRANSCTION
                        (VEHICLE_ID, CUSTOMER_ID, EMPLOYEE_ID, EMPLOYEE_NAME,
                         PRICE, DISCOUNT, SALE_DATE, PAYMENT_STATUS, PAYMENT_METHOD)
                    VALUES
                        (@vid, @cid, @eid, @ename,
                         @price, @discount, @date, 'Paid', 'Cash')", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@vid", selectedVehicleId);
                    cmd.Parameters.AddWithValue("@cid", selectedCustomerId);
                    cmd.Parameters.AddWithValue("@eid", empId);
                    cmd.Parameters.AddWithValue("@ename", empName);
                    cmd.Parameters.AddWithValue("@price", soldPrice);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    cmd.ExecuteNonQuery();
                    saleId = (int)cmd.LastInsertedId;
                }

                // ── 2. VEHICLE status → Sold ──────────────────────────────────────
                using (MySqlCommand cmd = new MySqlCommand(
                    "UPDATE VEHICLE SET STATUS = 'Sold' WHERE VEHICLE_ID = @vid", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@vid", selectedVehicleId);
                    cmd.ExecuteNonQuery();
                }

                // ── 3. GATE_PASSES insert ─────────────────────────────────────────
                string qrData = $"SIGMA|SALE:{saleId}|VEH:{selectedVehicleId}|CUST:{selectedCustomerId}|DATE:{DateTime.Now:yyyyMMdd}";
                using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO GATE_PASSES (VEHICLE_ID, SALE_ID, EMPLOYEE_ID, TIMESTAMP, QR_DATA)
                    VALUES (@vid, @sid, @eid, @ts, @qr)", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@vid", selectedVehicleId);
                    cmd.Parameters.AddWithValue("@sid", saleId);
                    cmd.Parameters.AddWithValue("@eid", empId);
                    cmd.Parameters.AddWithValue("@ts", DateTime.Now);
                    cmd.Parameters.AddWithValue("@qr", qrData);
                    cmd.ExecuteNonQuery();
                }

                // ── 4. INVOICES insert ────────────────────────────────────────────
                using (MySqlCommand cmd = new MySqlCommand(@"
                    INSERT INTO INVOICES
                        (SALE_ID, CUSTOMER_ID, VEHICLE_ID, EMPLOYEE_ID,
                         INVOICE_DATE, TOTAL_AMOUNT, DISCOUNT, NET_AMOUNT, STATUS)
                    VALUES
                        (@sid, @cid, @vid, @eid,
                         @date, @total, @disc, @net, 'Payment Pending')", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@sid", saleId);
                    cmd.Parameters.AddWithValue("@cid", selectedCustomerId);
                    cmd.Parameters.AddWithValue("@vid", selectedVehicleId);
                    cmd.Parameters.AddWithValue("@eid", empId);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@total", demand);
                    cmd.Parameters.AddWithValue("@disc", discount);
                    cmd.Parameters.AddWithValue("@net", soldPrice);
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();

                MessageBox.Show(
                    $"Sale Finalized!\nSale ID : {saleId}\nGate Pass & Invoice created successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAll();
                LoadCarAutocomplete(); // sold car autocomplete se nikal jaye
            }
            catch (Exception ex)
            {
                tx?.Rollback();
                MessageBox.Show("Transaction failed & rolled back.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  CLEAR HELPERS
        // ════════════════════════════════════════════════════════════════════════

        private void ClearCarFields()
        {
            selectedVehicleId = -1;
            txtCarId.Text = txtBrand.Text = txtModel.Text = txtVarient.Text =
            txtColor.Text = txtYear.Text = txtEngine.Text = txtBody.Text =
            txtOrigin.Text = txtDemand.Text = txtDemandRight.Text =
            txtSoldPrice.Text = "";
        }

        private void ClearCustomerFields()
        {
            selectedCustomerId = -1;
            txtCustId.Text = txtCustName.Text = txtCustCnic.Text =
            txtCustCell.Text = txtCustAddress.Text = txtCustEmail.Text = "";
        }

        private void ClearAll()
        {
            ClearCarFields();
            ClearCustomerFields();
            txtCarIdManual.Text = "";
            txtCustSearchName.Text = "";
            txtCustSearchCnic.Text = "";
            txtDiscount.Text = "";
            SetDateTime();
        }
    }
}