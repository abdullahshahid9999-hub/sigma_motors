using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class GatePassForm : Form
    {
        private const string ConnStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";
        private readonly int _saleId;
        private DataRow _gpRow;

        public GatePassForm(int saleId)
        {
            _saleId = saleId;
            InitializeComponent();
        }

        private void GatePassForm_Load(object sender, EventArgs e)
        {
            LoadGatePass();
        }

        private void LoadGatePass()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();

                    // Check if gate pass exists
                    string checkQuery = "SELECT GATE_PASS_ID FROM GATE_PASSES WHERE SALE_ID = @sid LIMIT 1";
                    var checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@sid", _saleId);
                    object existing = checkCmd.ExecuteScalar();

                    if (existing == null || existing == DBNull.Value)
                    {
                        // Auto-generate gate pass
                        // Get vehicle and employee for this sale
                        var infoCmd = new MySqlCommand(
                            "SELECT VEHICLE_ID, EMPLOYEE_ID FROM SALE_TRANSCTION WHERE SALE_ID = @sid", conn);
                        infoCmd.Parameters.AddWithValue("@sid", _saleId);
                        var reader = infoCmd.ExecuteReader();
                        int vehicleId = 0, employeeId = 0;
                        if (reader.Read())
                        {
                            vehicleId = Convert.ToInt32(reader["VEHICLE_ID"]);
                            employeeId = reader["EMPLOYEE_ID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["EMPLOYEE_ID"]);
                        }
                        reader.Close();

                        DateTime timestamp = DateTime.Now;
                        string qrData = $"SIGMA-GP-{_saleId}-{vehicleId}-{timestamp:yyyyMMddHHmmss}";

                        var insertCmd = new MySqlCommand(@"
                            INSERT INTO GATE_PASSES (VEHICLE_ID, SALE_ID, EMPLOYEE_ID, TIMESTAMP, QR_DATA)
                            VALUES (@vid, @sid, @eid, @ts, @qr)", conn);
                        insertCmd.Parameters.AddWithValue("@vid", vehicleId);
                        insertCmd.Parameters.AddWithValue("@sid", _saleId);
                        insertCmd.Parameters.AddWithValue("@eid", employeeId == 0 ? (object)DBNull.Value : employeeId);
                        insertCmd.Parameters.AddWithValue("@ts", timestamp);
                        insertCmd.Parameters.AddWithValue("@qr", qrData);
                        insertCmd.ExecuteNonQuery();
                    }

                    // Load full gate pass details
                    string query = @"
                        SELECT
                            GP.GATE_PASS_ID,
                            CONCAT('GP-', LPAD(GP.GATE_PASS_ID, 4, '0')) AS GP_No,
                            GP.TIMESTAMP,
                            GP.QR_DATA,
                            V.REGISTRATION_NUMBER,
                            V.COLOUR,
                            V.MANUFACTURE_YEAR,
                            B.BRAND_NAME,
                            M.MODEL_NAME,
                            V2.VARIENT_NAME,
                            C.NAME AS Customer_Name,
                            DATE_FORMAT(ST.SALE_DATE, '%d %M %Y') AS Sale_Date,
                            E.NAME AS Authorized_By
                        FROM GATE_PASSES GP
                        LEFT JOIN VEHICLE V ON GP.VEHICLE_ID = V.VEHICLE_ID
                        LEFT JOIN BRANDS B ON V.BRAND_ID = B.BRAND_ID
                        LEFT JOIN MODELS M ON V.MODEL_ID = M.MODEL_ID
                        LEFT JOIN VARIENTS V2 ON V.VARIENT_ID = V2.VARIENT_ID
                        LEFT JOIN SALE_TRANSCTION ST ON GP.SALE_ID = ST.SALE_ID
                        LEFT JOIN CUSTOMER C ON ST.CUSTOMER_ID = C.CUSTOMER_ID
                        LEFT JOIN EMPLOYEE E ON GP.EMPLOYEE_ID = E.EMPLOYEE_ID
                        WHERE GP.SALE_ID = @sid
                        LIMIT 1";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@sid", _saleId);

                    var adapter = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Could not load gate pass.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        return;
                    }

                    _gpRow = dt.Rows[0];
                    PopulateFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading gate pass: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFields()
        {
            if (_gpRow == null) return;

            lblGPNo.Text = _gpRow["GP_No"].ToString();
            lblTimestamp.Text = "Issued: " + Convert.ToDateTime(_gpRow["TIMESTAMP"]).ToString("dd MMM yyyy  HH:mm:ss");
            lblQRData.Text = _gpRow["QR_DATA"].ToString();

            lblCustomerName.Text = _gpRow["Customer_Name"].ToString();
            lblSaleDate.Text = _gpRow["Sale_Date"].ToString();
            lblAuthorizedBy.Text = _gpRow["Authorized_By"].ToString();

            lblBrand.Text = _gpRow["BRAND_NAME"].ToString();
            lblModel.Text = _gpRow["MODEL_NAME"].ToString();
            lblVariant.Text = _gpRow["VARIENT_NAME"].ToString();
            lblColour.Text = _gpRow["COLOUR"].ToString();
            lblYear.Text = _gpRow["MANUFACTURE_YEAR"].ToString();
            lblRegNo.Text = _gpRow["REGISTRATION_NUMBER"].ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            var ppd = new PrintPreviewDialog
            {
                Document = pd,
                Width = 900,
                Height = 700
            };
            ppd.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            if (_gpRow == null) return;
            Graphics g = e.Graphics;
            float pageW = e.PageBounds.Width;
            float y = 30f;

            // Dark red banner
            var bannerBrush = new SolidBrush(Color.FromArgb(139, 0, 0));
            g.FillRectangle(bannerBrush, 40, (int)y, (int)(pageW - 80), 60);
            g.DrawString("SIGMA MOTORS", new Font("Segoe UI", 20, FontStyle.Bold), Brushes.White, 55, y + 8);
            g.DrawString("PAKWHEELS VERIFIED DEALER", new Font("Segoe UI", 9), Brushes.White, 55, y + 36);
            g.DrawString("Main GT Road, Faisalabad  |  +92-41-XXXXXXX",
                new Font("Segoe UI", 8), Brushes.White, (float)(pageW - 320), y + 25);
            y += 75;

            // Gate Pass Title bar
            g.FillRectangle(new SolidBrush(Color.FromArgb(240, 240, 240)), 40, (int)y, (int)(pageW - 80), 40);
            g.DrawString("VEHICLE GATE PASS", new Font("Segoe UI", 14, FontStyle.Bold),
                new SolidBrush(Color.FromArgb(139, 0, 0)), 55, y + 8);
            g.DrawString(_gpRow["GP_No"].ToString(), new Font("Segoe UI", 12, FontStyle.Bold),
                Brushes.Black, (float)(pageW - 180), y + 10);
            y += 55;

            g.DrawString("Issued: " + Convert.ToDateTime(_gpRow["TIMESTAMP"]).ToString("dd MMM yyyy  HH:mm:ss"),
                new Font("Segoe UI", 9), new SolidBrush(Color.Gray), 40, y);
            y += 25;

            g.DrawLine(new Pen(Color.FromArgb(200, 200, 200)), 40, y, pageW - 40, y);
            y += 15;

            // Customer section
            g.DrawString("CUSTOMER INFORMATION", new Font("Segoe UI", 8, FontStyle.Bold), new SolidBrush(Color.Gray), 40, y);
            y += 18;

            string[,] custFields = {
                { "Customer Name", _gpRow["Customer_Name"].ToString() },
                { "Sale Date", _gpRow["Sale_Date"].ToString() },
                { "Authorized By", _gpRow["Authorized_By"].ToString() }
            };
            for (int i = 0; i < custFields.GetLength(0); i++)
            {
                g.DrawString(custFields[i, 0] + ":", new Font("Segoe UI", 9), new SolidBrush(Color.Gray), 40, y);
                g.DrawString(custFields[i, 1], new Font("Segoe UI", 9, FontStyle.Bold), Brushes.Black, 180, y);
                y += 20;
            }
            y += 10;

            g.DrawLine(new Pen(Color.FromArgb(200, 200, 200)), 40, y, pageW - 40, y);
            y += 15;

            // Vehicle section
            g.DrawString("VEHICLE DETAILS", new Font("Segoe UI", 8, FontStyle.Bold), new SolidBrush(Color.Gray), 40, y);
            y += 18;

            string[,] vehFields = {
                { "Brand", _gpRow["BRAND_NAME"].ToString() },
                { "Model", _gpRow["MODEL_NAME"].ToString() },
                { "Variant", _gpRow["VARIENT_NAME"].ToString() },
                { "Colour", _gpRow["COLOUR"].ToString() },
                { "Year", _gpRow["MANUFACTURE_YEAR"].ToString() },
                { "Reg No", _gpRow["REGISTRATION_NUMBER"].ToString() }
            };
            for (int i = 0; i < vehFields.GetLength(0); i++)
            {
                g.DrawString(vehFields[i, 0] + ":", new Font("Segoe UI", 9), new SolidBrush(Color.Gray), 40, y);
                g.DrawString(vehFields[i, 1], new Font("Segoe UI", 9, FontStyle.Bold), Brushes.Black, 180, y);
                y += 20;
            }
            y += 20;

            g.DrawLine(new Pen(Color.FromArgb(200, 200, 200)), 40, y, pageW - 40, y);
            y += 15;

            // QR Data
            g.DrawString("VERIFICATION CODE", new Font("Segoe UI", 8, FontStyle.Bold), new SolidBrush(Color.Gray), 40, y);
            y += 18;
            g.FillRectangle(new SolidBrush(Color.FromArgb(245, 245, 245)), 40, (int)y, (int)(pageW - 80), 30);
            g.DrawString(_gpRow["QR_DATA"].ToString(), new Font("Courier New", 9, FontStyle.Bold),
                new SolidBrush(Color.FromArgb(139, 0, 0)), 50, y + 8);
            y += 45;

            // Signature line
            g.DrawLine(new Pen(Color.Black, 1.5f), (float)(pageW - 250), y + 30, (float)(pageW - 50), y + 30);
            g.DrawString("Authorized Signature", new Font("Segoe UI", 8), new SolidBrush(Color.Gray),
                (float)(pageW - 240), y + 36);

            g.DrawString("SIGMA MOTORS — Main GT Road, Faisalabad",
                new Font("Segoe UI", 8, FontStyle.Italic), new SolidBrush(Color.Gray), 40, y + 40);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}