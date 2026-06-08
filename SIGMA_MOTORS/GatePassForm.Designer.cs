namespace SIGMA_MOTORS
{
    partial class GatePassForm
    {
        private System.ComponentModel.IContainer components = null;

        // Banner
        private System.Windows.Forms.Panel pnlBanner;
        private System.Windows.Forms.Label lblBannerTitle;
        private System.Windows.Forms.Label lblBannerTagline;
        private System.Windows.Forms.Label lblBannerAddress;

        // Title bar
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblGPTitle;
        private System.Windows.Forms.Label lblGPNo;
        private System.Windows.Forms.Label lblTimestamp;

        // Body
        private System.Windows.Forms.Panel pnlBody;

        // Customer section
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustSectionTitle;
        private System.Windows.Forms.Label lblLblCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblLblSaleDate;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.Label lblLblAuthorizedBy;
        private System.Windows.Forms.Label lblAuthorizedBy;

        // Vehicle section
        private System.Windows.Forms.Panel pnlVehicle;
        private System.Windows.Forms.Label lblVehicleSectionTitle;
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

        // QR Data section
        private System.Windows.Forms.Panel pnlQR;
        private System.Windows.Forms.Label lblQRTitle;
        private System.Windows.Forms.Label lblQRData;

        // Button bar
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnPrint;
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
            this.lblBannerTitle = new System.Windows.Forms.Label();
            this.lblBannerTagline = new System.Windows.Forms.Label();
            this.lblBannerAddress = new System.Windows.Forms.Label();

            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblGPTitle = new System.Windows.Forms.Label();
            this.lblGPNo = new System.Windows.Forms.Label();
            this.lblTimestamp = new System.Windows.Forms.Label();

            this.pnlBody = new System.Windows.Forms.Panel();

            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.lblCustSectionTitle = new System.Windows.Forms.Label();
            this.lblLblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblLblSaleDate = new System.Windows.Forms.Label();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.lblLblAuthorizedBy = new System.Windows.Forms.Label();
            this.lblAuthorizedBy = new System.Windows.Forms.Label();

            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.lblVehicleSectionTitle = new System.Windows.Forms.Label();
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

            this.pnlQR = new System.Windows.Forms.Panel();
            this.lblQRTitle = new System.Windows.Forms.Label();
            this.lblQRData = new System.Windows.Forms.Label();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            // ============================================================
            // FORM
            // ============================================================
            this.Text = "Gate Pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(680, 700);
            this.MinimumSize = new System.Drawing.Size(640, 600);
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Load += new System.EventHandler(this.GatePassForm_Load);

            // ============================================================
            // pnlBanner
            // ============================================================
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Height = 70;
            this.pnlBanner.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);

            this.lblBannerTitle.Text = "SIGMA MOTORS";
            this.lblBannerTitle.Font = new System.Drawing.Font("Segoe UI", 20f, System.Drawing.FontStyle.Bold);
            this.lblBannerTitle.ForeColor = System.Drawing.Color.White;
            this.lblBannerTitle.Location = new System.Drawing.Point(24, 8);
            this.lblBannerTitle.AutoSize = true;

            this.lblBannerTagline.Text = "PAKWHEELS VERIFIED DEALER";
            this.lblBannerTagline.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblBannerTagline.ForeColor = System.Drawing.Color.FromArgb(220, 200, 200);
            this.lblBannerTagline.Location = new System.Drawing.Point(26, 42);
            this.lblBannerTagline.AutoSize = true;

            this.lblBannerAddress.Text = "Main GT Road, Faisalabad  |  +92-41-XXXXXXX";
            this.lblBannerAddress.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblBannerAddress.ForeColor = System.Drawing.Color.FromArgb(220, 200, 200);
            this.lblBannerAddress.Location = new System.Drawing.Point(380, 28);
            this.lblBannerAddress.AutoSize = true;

            this.pnlBanner.Controls.Add(this.lblBannerTitle);
            this.pnlBanner.Controls.Add(this.lblBannerTagline);
            this.pnlBanner.Controls.Add(this.lblBannerAddress);

            // ============================================================
            // pnlTitleBar
            // ============================================================
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Height = 60;
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            this.lblGPTitle.Text = "VEHICLE GATE PASS";
            this.lblGPTitle.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblGPTitle.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.lblGPTitle.Location = new System.Drawing.Point(24, 10);
            this.lblGPTitle.AutoSize = true;

            this.lblGPNo.Text = "GP-0001";
            this.lblGPNo.Font = new System.Drawing.Font("Segoe UI", 13f, System.Drawing.FontStyle.Bold);
            this.lblGPNo.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblGPNo.Location = new System.Drawing.Point(480, 10);
            this.lblGPNo.AutoSize = true;

            this.lblTimestamp.Text = "Issued: --";
            this.lblTimestamp.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblTimestamp.ForeColor = System.Drawing.Color.Gray;
            this.lblTimestamp.Location = new System.Drawing.Point(24, 38);
            this.lblTimestamp.AutoSize = true;

            this.pnlTitleBar.Controls.Add(this.lblGPTitle);
            this.pnlTitleBar.Controls.Add(this.lblGPNo);
            this.pnlTitleBar.Controls.Add(this.lblTimestamp);

            // ============================================================
            // pnlBody
            // ============================================================
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.AutoScroll = true;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);

            // ── Customer Section ──────────────────────────────────
            this.pnlCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomer.Width = 620;
            this.pnlCustomer.Height = 95;
            this.pnlCustomer.BackColor = System.Drawing.Color.FromArgb(252, 250, 250);

            this.lblCustSectionTitle.Text = "CUSTOMER INFORMATION";
            this.lblCustSectionTitle.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Bold);
            this.lblCustSectionTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblCustSectionTitle.Location = new System.Drawing.Point(10, 8);
            this.lblCustSectionTitle.AutoSize = true;

            AddGPFieldPair(this.lblLblCustomerName = new System.Windows.Forms.Label(),
                this.lblCustomerName = new System.Windows.Forms.Label(), "Customer", 10, 160, 30);
            AddGPFieldPair(this.lblLblSaleDate = new System.Windows.Forms.Label(),
                this.lblSaleDate = new System.Windows.Forms.Label(), "Sale Date", 10, 160, 55);
            AddGPFieldPair(this.lblLblAuthorizedBy = new System.Windows.Forms.Label(),
                this.lblAuthorizedBy = new System.Windows.Forms.Label(), "Authorized By", 340, 490, 30);

            this.pnlCustomer.Controls.Add(this.lblCustSectionTitle);
            this.pnlCustomer.Controls.Add(this.lblLblCustomerName); this.pnlCustomer.Controls.Add(this.lblCustomerName);
            this.pnlCustomer.Controls.Add(this.lblLblSaleDate); this.pnlCustomer.Controls.Add(this.lblSaleDate);
            this.pnlCustomer.Controls.Add(this.lblLblAuthorizedBy); this.pnlCustomer.Controls.Add(this.lblAuthorizedBy);

            // ── Vehicle Section ───────────────────────────────────
            this.pnlVehicle.Location = new System.Drawing.Point(0, 110);
            this.pnlVehicle.Width = 620;
            this.pnlVehicle.Height = 140;
            this.pnlVehicle.BackColor = System.Drawing.Color.White;

            this.lblVehicleSectionTitle.Text = "VEHICLE DETAILS";
            this.lblVehicleSectionTitle.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Bold);
            this.lblVehicleSectionTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblVehicleSectionTitle.Location = new System.Drawing.Point(10, 8);
            this.lblVehicleSectionTitle.AutoSize = true;

            int c1 = 10, c2 = 130, c3 = 330, c4 = 460;
            AddGPFieldPair(this.lblLblBrand = new System.Windows.Forms.Label(), this.lblBrand = new System.Windows.Forms.Label(), "Brand", c1, c2, 28);
            AddGPFieldPair(this.lblLblModel = new System.Windows.Forms.Label(), this.lblModel = new System.Windows.Forms.Label(), "Model", c3, c4, 28);
            AddGPFieldPair(this.lblLblVariant = new System.Windows.Forms.Label(), this.lblVariant = new System.Windows.Forms.Label(), "Variant", c1, c2, 56);
            AddGPFieldPair(this.lblLblColour = new System.Windows.Forms.Label(), this.lblColour = new System.Windows.Forms.Label(), "Colour", c3, c4, 56);
            AddGPFieldPair(this.lblLblYear = new System.Windows.Forms.Label(), this.lblYear = new System.Windows.Forms.Label(), "Year", c1, c2, 84);
            AddGPFieldPair(this.lblLblRegNo = new System.Windows.Forms.Label(), this.lblRegNo = new System.Windows.Forms.Label(), "Reg No", c3, c4, 84);

            this.pnlVehicle.Controls.Add(this.lblVehicleSectionTitle);
            this.pnlVehicle.Controls.Add(this.lblLblBrand); this.pnlVehicle.Controls.Add(this.lblBrand);
            this.pnlVehicle.Controls.Add(this.lblLblModel); this.pnlVehicle.Controls.Add(this.lblModel);
            this.pnlVehicle.Controls.Add(this.lblLblVariant); this.pnlVehicle.Controls.Add(this.lblVariant);
            this.pnlVehicle.Controls.Add(this.lblLblColour); this.pnlVehicle.Controls.Add(this.lblColour);
            this.pnlVehicle.Controls.Add(this.lblLblYear); this.pnlVehicle.Controls.Add(this.lblYear);
            this.pnlVehicle.Controls.Add(this.lblLblRegNo); this.pnlVehicle.Controls.Add(this.lblRegNo);

            // ── QR Data Section ───────────────────────────────────
            this.pnlQR.Location = new System.Drawing.Point(0, 265);
            this.pnlQR.Width = 620;
            this.pnlQR.Height = 56;
            this.pnlQR.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);

            this.lblQRTitle.Text = "VERIFICATION CODE";
            this.lblQRTitle.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Bold);
            this.lblQRTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblQRTitle.Location = new System.Drawing.Point(10, 6);
            this.lblQRTitle.AutoSize = true;

            this.lblQRData.Text = "--";
            this.lblQRData.Font = new System.Drawing.Font("Courier New", 9f, System.Drawing.FontStyle.Bold);
            this.lblQRData.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.lblQRData.Location = new System.Drawing.Point(10, 26);
            this.lblQRData.AutoSize = true;

            this.pnlQR.Controls.Add(this.lblQRTitle);
            this.pnlQR.Controls.Add(this.lblQRData);

            this.pnlBody.Controls.Add(this.pnlCustomer);
            this.pnlBody.Controls.Add(this.pnlVehicle);
            this.pnlBody.Controls.Add(this.pnlQR);

            // ============================================================
            // pnlButtons
            // ============================================================
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Height = 56;
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            this.btnPrint.Text = "Print Gate Pass";
            this.btnPrint.Width = 140;
            this.btnPrint.Height = 34;
            this.btnPrint.Location = new System.Drawing.Point(20, 11);
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            this.btnClose.Text = "Close";
            this.btnClose.Width = 90;
            this.btnClose.Height = 34;
            this.btnClose.Location = new System.Drawing.Point(540, 11);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 1;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.pnlButtons.Controls.Add(this.btnPrint);
            this.pnlButtons.Controls.Add(this.btnClose);

            // ============================================================
            // ADD TO FORM
            // ============================================================
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlBanner);
        }

        private void AddGPFieldPair(System.Windows.Forms.Label lblLabel, System.Windows.Forms.Label lblValue,
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
    }
}