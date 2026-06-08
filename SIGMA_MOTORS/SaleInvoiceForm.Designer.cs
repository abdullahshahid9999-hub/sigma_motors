namespace SIGMA_MOTORS
{
    partial class SaleInvoiceForm
    {
        private System.ComponentModel.IContainer components = null;

        // Banner
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblCompanyAddress;

        // Invoice header area
        private System.Windows.Forms.Panel pnlInvHeader;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblStatus;

        // Scroll panel (body)
        private System.Windows.Forms.Panel pnlBody;

        // Bill To section
        private System.Windows.Forms.Panel pnlBillTo;
        private System.Windows.Forms.Label lblBillToTitle;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCnic;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;

        // Vehicle section
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.Label lblVehicleTitle;
        private System.Windows.Forms.Label lblLblBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblLblModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblLblVariant;
        private System.Windows.Forms.Label lblVariant;
        private System.Windows.Forms.Label lblLblColour;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblLblYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblLblRegNo;
        private System.Windows.Forms.Label lblRegNo;

        // Price section
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Label lblPriceTitle;
        private System.Windows.Forms.Label lblLblTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblLblDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel pnlNetBar;
        private System.Windows.Forms.Label lblLblNet;
        private System.Windows.Forms.Label lblNetAmount;
        private System.Windows.Forms.Label lblLblPayMethod;
        private System.Windows.Forms.Label lblPaymentMethod;

        // Footer
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Label lblSalesperson;

        // Button bar
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExportHTML;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlBanner = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();

            this.pnlInvHeader = new System.Windows.Forms.Panel();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();

            this.pnlBody = new System.Windows.Forms.Panel();

            this.pnlBillTo = new System.Windows.Forms.Panel();
            this.lblBillToTitle = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCnic = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();

            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.lblVehicleTitle = new System.Windows.Forms.Label();
            this.lblLblBrand = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblLblModel = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblLblVariant = new System.Windows.Forms.Label();
            this.lblVariant = new System.Windows.Forms.Label();
            this.lblLblColour = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblLblYear = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblLblRegNo = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();

            this.pnlPrice = new System.Windows.Forms.Panel();
            this.lblPriceTitle = new System.Windows.Forms.Label();
            this.lblLblTotal = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblLblDiscount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.pnlNetBar = new System.Windows.Forms.Panel();
            this.lblLblNet = new System.Windows.Forms.Label();
            this.lblNetAmount = new System.Windows.Forms.Label();
            this.lblLblPayMethod = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();

            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblThankYou = new System.Windows.Forms.Label();
            this.lblSalesperson = new System.Windows.Forms.Label();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportHTML = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            // ============================================================
            // FORM
            // ============================================================
            this.Text = "Sale Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(750, 780);
            this.MinimumSize = new System.Drawing.Size(700, 650);
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Load += new System.EventHandler(this.SaleInvoiceForm_Load);

            // ============================================================
            // pnlBanner
            // ============================================================
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Height = 70;
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.pnlBanner.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);

            this.lblCompanyName.Text = "SIGMA MOTORS";
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 20f, System.Drawing.FontStyle.Bold);
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(24, 8);
            this.lblCompanyName.AutoSize = true;

            this.lblTagline.Text = "PAKWHEELS VERIFIED DEALER";
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(220, 200, 200);
            this.lblTagline.Location = new System.Drawing.Point(26, 42);
            this.lblTagline.AutoSize = true;

            this.lblCompanyAddress.Text = "Main GT Road, Faisalabad  |  +92-41-XXXXXXX";
            this.lblCompanyAddress.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblCompanyAddress.ForeColor = System.Drawing.Color.FromArgb(220, 200, 200);
            this.lblCompanyAddress.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.lblCompanyAddress.Location = new System.Drawing.Point(420, 28);
            this.lblCompanyAddress.AutoSize = true;

            this.pnlBanner.Controls.Add(this.lblCompanyName);
            this.pnlBanner.Controls.Add(this.lblTagline);
            this.pnlBanner.Controls.Add(this.lblCompanyAddress);

            // ============================================================
            // pnlInvHeader
            // ============================================================
            this.pnlInvHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInvHeader.Height = 62;
            this.pnlInvHeader.BackColor = System.Drawing.Color.White;
            this.pnlInvHeader.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);

            this.lblInvoiceNo.Text = "INV-0001";
            this.lblInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblInvoiceNo.Location = new System.Drawing.Point(24, 10);
            this.lblInvoiceNo.AutoSize = true;

            this.lblInvoiceDate.Text = "Date: --";
            this.lblInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.Gray;
            this.lblInvoiceDate.Location = new System.Drawing.Point(24, 38);
            this.lblInvoiceDate.AutoSize = true;

            this.lblStatus.Text = " Paid ";
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.BackColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(600, 18);
            this.lblStatus.AutoSize = true;
            this.lblStatus.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);

            this.pnlInvHeader.Controls.Add(this.lblInvoiceNo);
            this.pnlInvHeader.Controls.Add(this.lblInvoiceDate);
            this.pnlInvHeader.Controls.Add(this.lblStatus);

            // ============================================================
            // pnlBody (scrollable)
            // ============================================================
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.AutoScroll = true;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);

            // ── pnlBillTo ──────────────────────────────────────────
            this.pnlBillTo.Location = new System.Drawing.Point(0, 0);
            this.pnlBillTo.Width = 680;
            this.pnlBillTo.Height = 110;
            this.pnlBillTo.BackColor = System.Drawing.Color.White;

            this.lblBillToTitle.Text = "BILL TO";
            this.lblBillToTitle.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Bold);
            this.lblBillToTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblBillToTitle.Location = new System.Drawing.Point(0, 0);
            this.lblBillToTitle.AutoSize = true;

            this.lblCustomerName.Text = "--";
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblCustomerName.Location = new System.Drawing.Point(0, 18);
            this.lblCustomerName.AutoSize = true;

            this.lblCnic.Text = "CNIC: --";
            this.lblCnic.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblCnic.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblCnic.Location = new System.Drawing.Point(0, 48);
            this.lblCnic.AutoSize = true;

            this.lblPhone.Text = "Phone: --";
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblPhone.Location = new System.Drawing.Point(200, 48);
            this.lblPhone.AutoSize = true;

            this.lblAddress.Text = "Address: --";
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblAddress.Location = new System.Drawing.Point(0, 72);
            this.lblAddress.AutoSize = true;

            this.pnlBillTo.Controls.Add(this.lblBillToTitle);
            this.pnlBillTo.Controls.Add(this.lblCustomerName);
            this.pnlBillTo.Controls.Add(this.lblCnic);
            this.pnlBillTo.Controls.Add(this.lblPhone);
            this.pnlBillTo.Controls.Add(this.lblAddress);

            // ── pnlVehicle ─────────────────────────────────────────
            this.pnlVehicle.Location = new System.Drawing.Point(0, 120);
            this.pnlVehicle.Width = 680;
            this.pnlVehicle.Height = 140;
            this.pnlVehicle.BackColor = System.Drawing.Color.FromArgb(252, 250, 250);
            this.pnlVehicle.Padding = new System.Windows.Forms.Padding(10);

            this.lblVehicleTitle.Text = "VEHICLE DETAILS";
            this.lblVehicleTitle.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Bold);
            this.lblVehicleTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblVehicleTitle.Location = new System.Drawing.Point(10, 8);
            this.lblVehicleTitle.AutoSize = true;

            int col1 = 10, col2 = 130, col3 = 360, col4 = 490;
            int row1 = 28, row2 = 60, row3 = 92;

            SetFieldPair(this.lblLblBrand = new System.Windows.Forms.Label(), this.lblBrand = new System.Windows.Forms.Label(), "Brand", col1, col2, row1);
            SetFieldPair(this.lblLblModel = new System.Windows.Forms.Label(), this.lblModel = new System.Windows.Forms.Label(), "Model", col3, col4, row1);
            SetFieldPair(this.lblLblVariant = new System.Windows.Forms.Label(), this.lblVariant = new System.Windows.Forms.Label(), "Variant", col1, col2, row2);
            SetFieldPair(this.lblLblColour = new System.Windows.Forms.Label(), this.lblColour = new System.Windows.Forms.Label(), "Colour", col3, col4, row2);
            SetFieldPair(this.lblLblYear = new System.Windows.Forms.Label(), this.lblYear = new System.Windows.Forms.Label(), "Year", col1, col2, row3);
            SetFieldPair(this.lblLblRegNo = new System.Windows.Forms.Label(), this.lblRegNo = new System.Windows.Forms.Label(), "Reg No", col3, col4, row3);

            this.pnlVehicle.Controls.Add(this.lblVehicleTitle);
            this.pnlVehicle.Controls.Add(this.lblLblBrand); this.pnlVehicle.Controls.Add(this.lblBrand);
            this.pnlVehicle.Controls.Add(this.lblLblModel); this.pnlVehicle.Controls.Add(this.lblModel);
            this.pnlVehicle.Controls.Add(this.lblLblVariant); this.pnlVehicle.Controls.Add(this.lblVariant);
            this.pnlVehicle.Controls.Add(this.lblLblColour); this.pnlVehicle.Controls.Add(this.lblColour);
            this.pnlVehicle.Controls.Add(this.lblLblYear); this.pnlVehicle.Controls.Add(this.lblYear);
            this.pnlVehicle.Controls.Add(this.lblLblRegNo); this.pnlVehicle.Controls.Add(this.lblRegNo);

            // ── pnlPrice ───────────────────────────────────────────
            this.pnlPrice.Location = new System.Drawing.Point(0, 275);
            this.pnlPrice.Width = 680;
            this.pnlPrice.Height = 160;
            this.pnlPrice.BackColor = System.Drawing.Color.White;
            this.pnlPrice.Padding = new System.Windows.Forms.Padding(10);

            this.lblPriceTitle.Text = "PAYMENT SUMMARY";
            this.lblPriceTitle.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Bold);
            this.lblPriceTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblPriceTitle.Location = new System.Drawing.Point(10, 8);
            this.lblPriceTitle.AutoSize = true;

            SetPriceRow(this.lblLblTotal = new System.Windows.Forms.Label(), this.lblTotalAmount = new System.Windows.Forms.Label(), "Total Amount", 30, false);
            SetPriceRow(this.lblLblDiscount = new System.Windows.Forms.Label(), this.lblDiscount = new System.Windows.Forms.Label(), "Discount", 56, false);

            this.pnlNetBar.Location = new System.Drawing.Point(10, 78);
            this.pnlNetBar.Width = 650;
            this.pnlNetBar.Height = 36;
            this.pnlNetBar.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);

            this.lblLblNet.Text = "Net Amount";
            this.lblLblNet.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblLblNet.ForeColor = System.Drawing.Color.White;
            this.lblLblNet.Location = new System.Drawing.Point(10, 8);
            this.lblLblNet.AutoSize = true;

            this.lblNetAmount.Text = "Rs 0";
            this.lblNetAmount.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblNetAmount.ForeColor = System.Drawing.Color.White;
            this.lblNetAmount.Location = new System.Drawing.Point(500, 8);
            this.lblNetAmount.AutoSize = true;

            this.pnlNetBar.Controls.Add(this.lblLblNet);
            this.pnlNetBar.Controls.Add(this.lblNetAmount);

            SetPriceRow(this.lblLblPayMethod = new System.Windows.Forms.Label(), this.lblPaymentMethod = new System.Windows.Forms.Label(), "Payment Method", 124, false);

            this.pnlPrice.Controls.Add(this.lblPriceTitle);
            this.pnlPrice.Controls.Add(this.lblLblTotal); this.pnlPrice.Controls.Add(this.lblTotalAmount);
            this.pnlPrice.Controls.Add(this.lblLblDiscount); this.pnlPrice.Controls.Add(this.lblDiscount);
            this.pnlPrice.Controls.Add(this.pnlNetBar);
            this.pnlPrice.Controls.Add(this.lblLblPayMethod); this.pnlPrice.Controls.Add(this.lblPaymentMethod);

            // ── pnlFooter ─────────────────────────────────────────
            this.pnlFooter.Location = new System.Drawing.Point(0, 445);
            this.pnlFooter.Width = 680;
            this.pnlFooter.Height = 50;
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(252, 248, 248);

            this.lblThankYou.Text = "Thank you for choosing SIGMA MOTORS!";
            this.lblThankYou.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Italic);
            this.lblThankYou.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.lblThankYou.Location = new System.Drawing.Point(10, 8);
            this.lblThankYou.AutoSize = true;

            this.lblSalesperson.Text = "Salesperson: --";
            this.lblSalesperson.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSalesperson.ForeColor = System.Drawing.Color.Gray;
            this.lblSalesperson.Location = new System.Drawing.Point(10, 30);
            this.lblSalesperson.AutoSize = true;

            this.pnlFooter.Controls.Add(this.lblThankYou);
            this.pnlFooter.Controls.Add(this.lblSalesperson);

            this.pnlBody.Controls.Add(this.pnlBillTo);
            this.pnlBody.Controls.Add(this.pnlVehicle);
            this.pnlBody.Controls.Add(this.pnlPrice);
            this.pnlBody.Controls.Add(this.pnlFooter);

            // ============================================================
            // pnlButtons
            // ============================================================
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Height = 56;
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);

            this.btnPrint.Text = "Print";
            this.btnPrint.Width = 100;
            this.btnPrint.Height = 34;
            this.btnPrint.Location = new System.Drawing.Point(20, 11);
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            this.btnExportHTML.Text = "Export HTML";
            this.btnExportHTML.Width = 120;
            this.btnExportHTML.Height = 34;
            this.btnExportHTML.Location = new System.Drawing.Point(130, 11);
            this.btnExportHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportHTML.FlatAppearance.BorderSize = 0;
            this.btnExportHTML.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnExportHTML.ForeColor = System.Drawing.Color.White;
            this.btnExportHTML.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.btnExportHTML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportHTML.Click += new System.EventHandler(this.btnExportHTML_Click);

            this.btnClose.Text = "Close";
            this.btnClose.Width = 90;
            this.btnClose.Height = 34;
            this.btnClose.Location = new System.Drawing.Point(560, 11);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.btnClose.FlatAppearance.BorderSize = 1;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.pnlButtons.Controls.Add(this.btnPrint);
            this.pnlButtons.Controls.Add(this.btnExportHTML);
            this.pnlButtons.Controls.Add(this.btnClose);

            // ============================================================
            // ADD TO FORM
            // ============================================================
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlInvHeader);
            this.Controls.Add(this.pnlBanner);
        }

        private void SetFieldPair(System.Windows.Forms.Label lblLabel, System.Windows.Forms.Label lblValue,
            string text, int labelX, int valueX, int y)
        {
            lblLabel.Text = text + ":";
            lblLabel.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            lblLabel.ForeColor = System.Drawing.Color.Gray;
            lblLabel.Location = new System.Drawing.Point(labelX, y);
            lblLabel.AutoSize = true;

            lblValue.Text = "--";
            lblValue.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            lblValue.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblValue.Location = new System.Drawing.Point(valueX, y);
            lblValue.AutoSize = true;
        }

        private void SetPriceRow(System.Windows.Forms.Label lblLabel, System.Windows.Forms.Label lblValue,
            string text, int y, bool bold)
        {
            lblLabel.Text = text;
            lblLabel.Font = new System.Drawing.Font("Segoe UI", 9f);
            lblLabel.ForeColor = System.Drawing.Color.Gray;
            lblLabel.Location = new System.Drawing.Point(10, y);
            lblLabel.AutoSize = true;

            lblValue.Text = "--";
            lblValue.Font = new System.Drawing.Font("Segoe UI", bold ? 11f : 9f,
                bold ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular);
            lblValue.ForeColor = bold ? System.Drawing.Color.FromArgb(139, 0, 0) : System.Drawing.Color.FromArgb(30, 30, 30);
            lblValue.Location = new System.Drawing.Point(520, y);
            lblValue.AutoSize = true;
        }
    }
}