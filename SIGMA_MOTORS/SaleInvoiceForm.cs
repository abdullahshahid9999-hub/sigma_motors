using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class SaleInvoiceForm : Form
    {
        private const string ConnStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";
        private readonly int _invoiceId;
        private DataRow _invoiceRow;

        public SaleInvoiceForm(int invoiceId)
        {
            _invoiceId = invoiceId;
            InitializeComponent();
        }

        private void SaleInvoiceForm_Load(object sender, EventArgs e)
        {
            LoadInvoice();
        }

        private void LoadInvoice()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT
                            I.INVOICE_ID,
                            CONCAT('INV-', LPAD(I.INVOICE_ID,4,'0')) AS Invoice_No,
                            DATE_FORMAT(I.INVOICE_DATE,'%d %M %Y') AS Invoice_Date,
                            I.STATUS,
                            I.TOTAL_AMOUNT,
                            I.DISCOUNT,
                            I.NET_AMOUNT,
                            C.NAME AS Customer_Name,
                            C.CNIC,
                            C.PHONE_NUMBER,
                            C.ADDRESS,
                            B.BRAND_NAME,
                            M.MODEL_NAME,
                            V2.VARIENT_NAME,
                            V.COLOUR,
                            V.MANUFACTURE_YEAR,
                            V.REGISTRATION_NUMBER,
                            ST.PAYMENT_METHOD,
                            ST.SALE_DATE,
                            E.NAME AS Salesperson
                        FROM INVOICES I
                        LEFT JOIN CUSTOMER C ON I.CUSTOMER_ID = C.CUSTOMER_ID
                        LEFT JOIN VEHICLE V ON I.VEHICLE_ID = V.VEHICLE_ID
                        LEFT JOIN BRANDS B ON V.BRAND_ID = B.BRAND_ID
                        LEFT JOIN MODELS M ON V.MODEL_ID = M.MODEL_ID
                        LEFT JOIN VARIENTS V2 ON V.VARIENT_ID = V2.VARIENT_ID
                        LEFT JOIN SALE_TRANSCTION ST ON I.SALE_ID = ST.SALE_ID
                        LEFT JOIN EMPLOYEE E ON I.EMPLOYEE_ID = E.EMPLOYEE_ID
                        WHERE I.INVOICE_ID = @id";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", _invoiceId);

                    var adapter = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Invoice not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                        return;
                    }

                    _invoiceRow = dt.Rows[0];
                    PopulateFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFields()
        {
            if (_invoiceRow == null) return;

            lblInvoiceNo.Text = _invoiceRow["Invoice_No"].ToString();
            lblInvoiceDate.Text = "Date: " + _invoiceRow["Invoice_Date"].ToString();

            string status = _invoiceRow["STATUS"].ToString();
            lblStatus.Text = " " + status + " ";
            lblStatus.BackColor = status == "Paid" ? Color.FromArgb(34, 139, 34)
                                : status == "Pending" ? Color.OrangeRed
                                : Color.Gray;

            lblCustomerName.Text = _invoiceRow["Customer_Name"].ToString();
            lblCnic.Text = "CNIC: " + _invoiceRow["CNIC"].ToString();
            lblPhone.Text = "Phone: " + _invoiceRow["PHONE_NUMBER"].ToString();
            lblAddress.Text = "Address: " + _invoiceRow["ADDRESS"].ToString();

            lblBrand.Text = _invoiceRow["BRAND_NAME"].ToString();
            lblModel.Text = _invoiceRow["MODEL_NAME"].ToString();
            lblVariant.Text = _invoiceRow["VARIENT_NAME"].ToString();
            lblColour.Text = _invoiceRow["COLOUR"].ToString();
            lblYear.Text = _invoiceRow["MANUFACTURE_YEAR"].ToString();
            lblRegNo.Text = _invoiceRow["REGISTRATION_NUMBER"].ToString();

            decimal total = Convert.ToDecimal(_invoiceRow["TOTAL_AMOUNT"]);
            decimal discount = Convert.ToDecimal(_invoiceRow["DISCOUNT"]);
            decimal net = Convert.ToDecimal(_invoiceRow["NET_AMOUNT"]);

            lblTotalAmount.Text = "Rs " + total.ToString("N0");
            lblDiscount.Text = "Rs " + discount.ToString("N0");
            lblNetAmount.Text = "Rs " + net.ToString("N0");
            lblPaymentMethod.Text = _invoiceRow["PAYMENT_METHOD"].ToString();

            lblSalesperson.Text = "Salesperson: " + _invoiceRow["Salesperson"].ToString();
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
            if (_invoiceRow == null) return;
            Graphics g = e.Graphics;
            float y = 40f;
            float pageW = e.PageBounds.Width;

            // Banner
            var bannerBrush = new SolidBrush(Color.FromArgb(139, 0, 0));
            g.FillRectangle(bannerBrush, 40, (int)y, (int)(pageW - 80), 60);
            g.DrawString("SIGMA MOTORS", new Font("Segoe UI", 20, FontStyle.Bold), Brushes.White, 55, y + 10);
            g.DrawString("PAKWHEELS VERIFIED DEALER", new Font("Segoe UI", 9), Brushes.White, 55, y + 38);
            g.DrawString("Main GT Road, Faisalabad  |  +92-41-XXXXXXX",
                new Font("Segoe UI", 8), Brushes.White, (float)(pageW - 320), y + 25);
            y += 75;

            // Invoice header
            g.DrawString(_invoiceRow["Invoice_No"].ToString(), new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, 40, y);
            g.DrawString("Date: " + _invoiceRow["Invoice_Date"].ToString(), new Font("Segoe UI", 10), Brushes.Gray, 40, y + 24);
            string status = _invoiceRow["STATUS"].ToString();
            var statusBrush = status == "Paid" ? new SolidBrush(Color.FromArgb(34, 139, 34)) : new SolidBrush(Color.OrangeRed);
            g.FillRectangle(statusBrush, (int)(pageW - 130), (int)y, 90, 26);
            g.DrawString(status, new Font("Segoe UI", 10, FontStyle.Bold), Brushes.White, pageW - 122, y + 5);
            y += 60;

            // Divider
            g.DrawLine(new Pen(Color.FromArgb(200, 200, 200)), 40, y, pageW - 40, y);
            y += 15;

            // Bill To
            g.DrawString("BILL TO", new Font("Segoe UI", 8, FontStyle.Bold), new SolidBrush(Color.Gray), 40, y);
            y += 18;
            g.DrawString(_invoiceRow["Customer_Name"].ToString(), new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, 40, y);
            y += 20;
            g.DrawString("CNIC: " + _invoiceRow["CNIC"].ToString(), new Font("Segoe UI", 9), Brushes.Black, 40, y);
            y += 16;
            g.DrawString("Phone: " + _invoiceRow["PHONE_NUMBER"].ToString(), new Font("Segoe UI", 9), Brushes.Black, 40, y);
            y += 16;
            g.DrawString("Address: " + _invoiceRow["ADDRESS"].ToString(), new Font("Segoe UI", 9), Brushes.Black, 40, y);
            y += 30;

            g.DrawLine(new Pen(Color.FromArgb(200, 200, 200)), 40, y, pageW - 40, y);
            y += 15;

            // Vehicle
            g.DrawString("VEHICLE DETAILS", new Font("Segoe UI", 8, FontStyle.Bold), new SolidBrush(Color.Gray), 40, y);
            y += 18;

            string[] vLabels = { "Brand", "Model", "Variant", "Colour", "Year", "Reg No" };
            string[] vValues = {
                _invoiceRow["BRAND_NAME"].ToString(),
                _invoiceRow["MODEL_NAME"].ToString(),
                _invoiceRow["VARIENT_NAME"].ToString(),
                _invoiceRow["COLOUR"].ToString(),
                _invoiceRow["MANUFACTURE_YEAR"].ToString(),
                _invoiceRow["REGISTRATION_NUMBER"].ToString()
            };

            for (int i = 0; i < vLabels.Length; i++)
            {
                g.DrawString(vLabels[i] + ":", new Font("Segoe UI", 9), new SolidBrush(Color.Gray), 40, y);
                g.DrawString(vValues[i], new Font("Segoe UI", 9, FontStyle.Bold), Brushes.Black, 140, y);
                y += 18;
            }
            y += 10;

            g.DrawLine(new Pen(Color.FromArgb(200, 200, 200)), 40, y, pageW - 40, y);
            y += 15;

            // Price box
            g.DrawString("PAYMENT SUMMARY", new Font("Segoe UI", 8, FontStyle.Bold), new SolidBrush(Color.Gray), 40, y);
            y += 18;

            decimal total = Convert.ToDecimal(_invoiceRow["TOTAL_AMOUNT"]);
            decimal discount = Convert.ToDecimal(_invoiceRow["DISCOUNT"]);
            decimal net = Convert.ToDecimal(_invoiceRow["NET_AMOUNT"]);

            DrawPriceRow(g, "Total Amount", "Rs " + total.ToString("N0"), y, pageW, false);
            y += 22;
            DrawPriceRow(g, "Discount", "Rs " + discount.ToString("N0"), y, pageW, false);
            y += 22;
            DrawPriceRow(g, "Net Amount", "Rs " + net.ToString("N0"), y, pageW, true);
            y += 22;
            DrawPriceRow(g, "Payment Method", _invoiceRow["PAYMENT_METHOD"].ToString(), y, pageW, false);
            y += 35;

            g.DrawLine(new Pen(Color.FromArgb(200, 200, 200)), 40, y, pageW - 40, y);
            y += 15;

            // Footer
            g.DrawString("Thank you for choosing SIGMA MOTORS!", new Font("Segoe UI", 10, FontStyle.Italic),
                new SolidBrush(Color.FromArgb(139, 0, 0)), 40, y);
            y += 20;
            g.DrawString("Salesperson: " + _invoiceRow["Salesperson"].ToString(), new Font("Segoe UI", 9), Brushes.Gray, 40, y);
        }

        private void DrawPriceRow(Graphics g, string label, string value, float y, float pageW, bool bold)
        {
            var font = bold ? new Font("Segoe UI", 10, FontStyle.Bold) : new Font("Segoe UI", 9);
            var brush = bold ? new SolidBrush(Color.FromArgb(139, 0, 0)) : Brushes.Black;
            g.DrawString(label, font, new SolidBrush(Color.Gray), 40, y);
            g.DrawString(value, font, brush, pageW - 200, y);
        }

        private void btnExportHTML_Click(object sender, EventArgs e)
        {
            if (_invoiceRow == null) return;

            try
            {
                decimal total = Convert.ToDecimal(_invoiceRow["TOTAL_AMOUNT"]);
                decimal discount = Convert.ToDecimal(_invoiceRow["DISCOUNT"]);
                decimal net = Convert.ToDecimal(_invoiceRow["NET_AMOUNT"]);

                string html = $@"<!DOCTYPE html>
<html>
<head>
<meta charset='utf-8'>
<title>Invoice {_invoiceRow["Invoice_No"]}</title>
<style>
  body {{ font-family: 'Segoe UI', sans-serif; max-width: 800px; margin: 40px auto; background: #f5f5f5; color: #333; }}
  .banner {{ background: #8B0000; color: white; padding: 24px 32px; border-radius: 6px 6px 0 0; }}
  .banner h1 {{ margin: 0; font-size: 28px; }}
  .banner p {{ margin: 4px 0 0; font-size: 13px; opacity: 0.85; }}
  .card {{ background: white; padding: 32px; }}
  .row {{ display: flex; justify-content: space-between; align-items: flex-start; margin-bottom: 20px; }}
  .inv-no {{ font-size: 22px; font-weight: bold; }}
  .badge {{ padding: 4px 14px; border-radius: 4px; color: white; font-weight: bold; font-size: 13px; background: {(_invoiceRow["STATUS"].ToString() == "Paid" ? "#228B22" : "#FF4500")}; }}
  .section-title {{ font-size: 11px; font-weight: bold; color: #888; letter-spacing: 1px; margin-bottom: 8px; }}
  .field-label {{ color: #888; font-size: 13px; }}
  .field-value {{ font-weight: 600; font-size: 13px; }}
  table {{ width: 100%; border-collapse: collapse; margin-top: 8px; }}
  td {{ padding: 8px 4px; }}
  .divider {{ border: none; border-top: 1px solid #eee; margin: 20px 0; }}
  .price-row {{ display: flex; justify-content: space-between; padding: 6px 0; font-size: 14px; }}
  .price-row.net {{ font-size: 16px; font-weight: bold; color: #8B0000; border-top: 2px solid #8B0000; margin-top: 4px; padding-top: 10px; }}
  .footer {{ background: #fafafa; border-top: 3px solid #8B0000; padding: 16px 32px; text-align: center; color: #8B0000; font-style: italic; }}
</style>
</head>
<body>
<div class='banner'>
  <div style='display:flex;justify-content:space-between;align-items:center;'>
    <div><h1>SIGMA MOTORS</h1><p>PAKWHEELS VERIFIED DEALER</p></div>
    <div style='text-align:right;font-size:13px;'>Main GT Road, Faisalabad<br>+92-41-XXXXXXX</div>
  </div>
</div>
<div class='card'>
  <div class='row'>
    <div>
      <div class='inv-no'>{_invoiceRow["Invoice_No"]}</div>
      <div style='color:#888;font-size:13px;margin-top:4px;'>Date: {_invoiceRow["Invoice_Date"]}</div>
    </div>
    <div class='badge'>{_invoiceRow["STATUS"]}</div>
  </div>
  <hr class='divider'>
  <div class='section-title'>BILL TO</div>
  <div style='font-size:18px;font-weight:bold;'>{_invoiceRow["Customer_Name"]}</div>
  <table style='margin-top:8px;'><tr>
    <td class='field-label'>CNIC</td><td class='field-value'>{_invoiceRow["CNIC"]}</td>
    <td class='field-label'>Phone</td><td class='field-value'>{_invoiceRow["PHONE_NUMBER"]}</td>
  </tr><tr>
    <td class='field-label'>Address</td><td class='field-value' colspan='3'>{_invoiceRow["ADDRESS"]}</td>
  </tr></table>
  <hr class='divider'>
  <div class='section-title'>VEHICLE DETAILS</div>
  <table><tr>
    <td class='field-label'>Brand</td><td class='field-value'>{_invoiceRow["BRAND_NAME"]}</td>
    <td class='field-label'>Model</td><td class='field-value'>{_invoiceRow["MODEL_NAME"]}</td>
  </tr><tr>
    <td class='field-label'>Variant</td><td class='field-value'>{_invoiceRow["VARIENT_NAME"]}</td>
    <td class='field-label'>Colour</td><td class='field-value'>{_invoiceRow["COLOUR"]}</td>
  </tr><tr>
    <td class='field-label'>Year</td><td class='field-value'>{_invoiceRow["MANUFACTURE_YEAR"]}</td>
    <td class='field-label'>Reg No</td><td class='field-value'>{_invoiceRow["REGISTRATION_NUMBER"]}</td>
  </tr></table>
  <hr class='divider'>
  <div class='section-title'>PAYMENT SUMMARY</div>
  <div class='price-row'><span>Total Amount</span><span>Rs {total:N0}</span></div>
  <div class='price-row'><span>Discount</span><span>Rs {discount:N0}</span></div>
  <div class='price-row net'><span>Net Amount</span><span>Rs {net:N0}</span></div>
  <div class='price-row' style='margin-top:10px;'><span class='field-label'>Payment Method</span><span class='field-value'>{_invoiceRow["PAYMENT_METHOD"]}</span></div>
</div>
<div class='footer'>
  Thank you for choosing SIGMA MOTORS! &nbsp;|&nbsp; Salesperson: {_invoiceRow["Salesperson"]}
</div>
</body>
</html>";

                string path = Path.Combine(Path.GetTempPath(), $"Invoice_{_invoiceRow["Invoice_No"]}.html");
                File.WriteAllText(path, html);
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HTML export failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}