namespace SIGMA_MOTORS
{
    partial class AddSales
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Declarations ─────────────────────────────────────────────────────
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDiv1 = new System.Windows.Forms.Panel();
            this.pnlDiv2 = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();

            // Left
            this.lblOrManuallyEnter = new System.Windows.Forms.Label();
            this.txtCarIdManual = new System.Windows.Forms.TextBox();
            this.btnSearchCar = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblCarId = new System.Windows.Forms.Label();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblDemand = new System.Windows.Forms.Label();
            this.txtDemand = new System.Windows.Forms.TextBox();
            this.lblVarient = new System.Windows.Forms.Label();
            this.txtVarient = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();

            // Middle
            this.lblCustSearchName = new System.Windows.Forms.Label();
            this.txtCustSearchName = new System.Windows.Forms.TextBox();
            this.lblCustSearchCnic = new System.Windows.Forms.Label();
            this.txtCustSearchCnic = new System.Windows.Forms.TextBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustId = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.lblCustCnic = new System.Windows.Forms.Label();
            this.txtCustCnic = new System.Windows.Forms.TextBox();
            this.lblCustCell = new System.Windows.Forms.Label();
            this.txtCustCell = new System.Windows.Forms.TextBox();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.txtCustEmail = new System.Windows.Forms.TextBox();

            // Right
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblDemandRight = new System.Windows.Forms.Label();
            this.txtDemandRight = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblSoldPrice = new System.Windows.Forms.Label();
            this.txtSoldPrice = new System.Windows.Forms.TextBox();
            this.btnFinalizeDeal = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════════════════════════════════
            this.Text = "Add Sales — Sigma Motors";
            this.ClientSize = new System.Drawing.Size(1080, 460);
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            // ════════════════════════════════════════════════════════════════════
            //  HEADER PANEL
            // ════════════════════════════════════════════════════════════════════
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1080, 42);

            this.lblTitle.Text = "Add Sales";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(14, 8);
            this.lblTitle.Size = new System.Drawing.Size(200, 28);
            this.pnlHeader.Controls.Add(this.lblTitle);

            // ── Dividers ─────────────────────────────────────────────────────────
            this.pnlDiv1.BackColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.pnlDiv1.Location = new System.Drawing.Point(352, 50);
            this.pnlDiv1.Size = new System.Drawing.Size(1, 395);

            this.pnlDiv2.BackColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.pnlDiv2.Location = new System.Drawing.Point(728, 50);
            this.pnlDiv2.Size = new System.Drawing.Size(1, 395);

            // ════════════════════════════════════════════════════════════════════
            //  LEFT COLUMN  (x: 14 .. 350)
            //  Column width = 338, label=65, gap=4, textbox fills rest
            // ════════════════════════════════════════════════════════════════════
            int LX = 14;    // left x
            int LW = 338;   // column width
            int LLW = 65;    // label width
            int LG = 4;     // gap label→text
            int LTW = LW - LLW - LG; // textbox width = 269
            int RY = 58;    // row y start
            int RH = 30;    // row height

            // "Reg No." search row
            this.lblOrManuallyEnter.Text = "Reg No. :";
            this.lblOrManuallyEnter.Location = new System.Drawing.Point(LX, RY + 3);
            this.lblOrManuallyEnter.Size = new System.Drawing.Size(LLW, 18);
            this.lblOrManuallyEnter.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblOrManuallyEnter.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);

            this.txtCarIdManual.Location = new System.Drawing.Point(LX + LLW + LG, RY);
            this.txtCarIdManual.Size = new System.Drawing.Size(LTW, 22);
            this.txtCarIdManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarIdManual.BackColor = System.Drawing.Color.White;

            // Search Car button
            this.btnSearchCar.Text = "Search Car";
            this.btnSearchCar.Location = new System.Drawing.Point(LX, RY + 28);
            this.btnSearchCar.Size = new System.Drawing.Size(LW, 26);
            this.btnSearchCar.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnSearchCar.ForeColor = System.Drawing.Color.White;
            this.btnSearchCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCar.FlatAppearance.BorderSize = 0;
            this.btnSearchCar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCar.Click += new System.EventHandler(this.btnSearchCar_Click);

            // ── Car detail rows ──────────────────────────────────────────────────
            // Each row: two sub-columns. Left sub: label(65)+txt(120). Right sub: label(55)+txt(98)
            int SR = RY + 62; // start row for details
            int SH = 28;      // step

            // Row 1: BRAND | CAR ID
            MakeField(this.lblBrand, "BRAND :", this.txtBrand, LX, SR, 65, 120, true);
            MakeField(this.lblCarId, "CAR ID :", this.txtCarId, LX + 190, SR, 55, 88, true);

            // Row 2: MODEL | DEMAND
            MakeField(this.lblModel, "MODEL :", this.txtModel, LX, SR + SH, 65, 120, true);
            MakeField(this.lblDemand, "DEMAND :", this.txtDemand, LX + 190, SR + SH, 55, 88, true);

            // Row 3: VARIENT (full width)
            MakeField(this.lblVarient, "VARIENT :", this.txtVarient, LX, SR + SH * 2, 65, LTW, true);

            // Row 4: COLOR | YEAR
            MakeField(this.lblColor, "COLOR :", this.txtColor, LX, SR + SH * 3, 65, 120, true);
            MakeField(this.lblYear, "YEAR :", this.txtYear, LX + 190, SR + SH * 3, 55, 88, true);

            // Row 5: ENGINE | BODY
            MakeField(this.lblEngine, "ENGINE :", this.txtEngine, LX, SR + SH * 4, 65, 120, true);
            MakeField(this.lblBody, "BODY :", this.txtBody, LX + 190, SR + SH * 4, 55, 88, true);

            // Row 6: ORIGIN (full width)
            MakeField(this.lblOrigin, "ORIGIN :", this.txtOrigin, LX, SR + SH * 5, 65, LTW, true);

            // ════════════════════════════════════════════════════════════════════
            //  MIDDLE COLUMN  (x: 366 .. 726)
            // ════════════════════════════════════════════════════════════════════
            int MX = 366;
            int MW = 358;   // column width
            int MLW = 72;    // label width

            // Search row: Name | CNIC
            this.lblCustSearchName.Text = "Name :";
            this.lblCustSearchName.Location = new System.Drawing.Point(MX, RY + 3);
            this.lblCustSearchName.Size = new System.Drawing.Size(42, 18);
            this.lblCustSearchName.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtCustSearchName.Location = new System.Drawing.Point(MX + 44, RY);
            this.txtCustSearchName.Size = new System.Drawing.Size(118, 22);
            this.txtCustSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustSearchName.BackColor = System.Drawing.Color.White;

            this.lblCustSearchCnic.Text = "CNIC :";
            this.lblCustSearchCnic.Location = new System.Drawing.Point(MX + 172, RY + 3);
            this.lblCustSearchCnic.Size = new System.Drawing.Size(42, 18);
            this.lblCustSearchCnic.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtCustSearchCnic.Location = new System.Drawing.Point(MX + 216, RY);
            this.txtCustSearchCnic.Size = new System.Drawing.Size(140, 22);
            this.txtCustSearchCnic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustSearchCnic.BackColor = System.Drawing.Color.White;

            // Search Customer button (full width)
            this.btnSearchCustomer.Text = "Search Customer Records";
            this.btnSearchCustomer.Location = new System.Drawing.Point(MX, RY + 28);
            this.btnSearchCustomer.Size = new System.Drawing.Size(MW, 26);
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);

            // ── Customer detail rows ─────────────────────────────────────────────
            int MSR = SR; // same start row as car details

            // Row 1: NAME | CUSTOMER ID
            MakeField(this.lblCustName, "NAME :", this.txtCustName, MX, MSR, MLW, 120, false);
            MakeField(this.lblCustId, "CUSTOMER ID :", this.txtCustId, MX + 210, MSR, 90, 58, true);

            // Row 2: CNIC | CELL
            MakeField(this.lblCustCnic, "CNIC :", this.txtCustCnic, MX, MSR + SH, MLW, 120, false);
            MakeField(this.lblCustCell, "CELL :", this.txtCustCell, MX + 210, MSR + SH, 45, 103, false);

            // Row 3: ADDRESS (full width)
            MakeField(this.lblCustAddress, "ADDRESS :", this.txtCustAddress, MX, MSR + SH * 2, MLW, MW - MLW - LG, false);

            // Row 4: EMAIL (full width)
            MakeField(this.lblCustEmail, "E-MAIL :", this.txtCustEmail, MX, MSR + SH * 3, MLW, MW - MLW - LG, false);

            // ════════════════════════════════════════════════════════════════════
            //  RIGHT COLUMN  (x: 742 .. 1066)
            // ════════════════════════════════════════════════════════════════════
            int RX2 = 742;
            int RW2 = 320;
            int RLW = 72;
            int RTW = RW2 - RLW - LG; // 244

            // Date & Time
            MakeField(this.lblDate, "Date :", this.txtDate, RX2, RY, RLW, RTW, true);
            MakeField(this.lblTime, "Time :", this.txtTime, RX2, RY + 28, RLW, RTW, true);

            // Spacer then deal fields
            MakeField(this.lblDemandRight, "Demand :", this.txtDemandRight, RX2, SR, RLW, RTW, false);
            MakeField(this.lblDiscount, "Discount :", this.txtDiscount, RX2, SR + SH, RLW, RTW, false);

            // Sold Price (highlighted)
            this.lblSoldPrice.Text = "Sold Price";
            this.lblSoldPrice.Location = new System.Drawing.Point(RX2, SR + SH * 2 + 3);
            this.lblSoldPrice.Size = new System.Drawing.Size(RLW, 18);
            this.lblSoldPrice.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.lblSoldPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.txtSoldPrice.Location = new System.Drawing.Point(RX2 + RLW + LG, SR + SH * 2);
            this.txtSoldPrice.Size = new System.Drawing.Size(RTW, 24);
            this.txtSoldPrice.ReadOnly = true;
            this.txtSoldPrice.BackColor = System.Drawing.Color.FromArgb(255, 255, 200);
            this.txtSoldPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoldPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtSoldPrice.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);

            // Finalize Deal button
            this.btnFinalizeDeal.Text = "Finalize Deal";
            this.btnFinalizeDeal.Location = new System.Drawing.Point(RX2, 400);
            this.btnFinalizeDeal.Size = new System.Drawing.Size(RW2, 38);
            this.btnFinalizeDeal.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnFinalizeDeal.ForeColor = System.Drawing.Color.White;
            this.btnFinalizeDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizeDeal.FlatAppearance.BorderSize = 0;
            this.btnFinalizeDeal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFinalizeDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizeDeal.Click += new System.EventHandler(this.btnFinalizeDeal_Click);

            // ════════════════════════════════════════════════════════════════════
            //  ADD ALL CONTROLS
            // ════════════════════════════════════════════════════════════════════
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                pnlHeader, pnlDiv1, pnlDiv2,

                // Left
                lblOrManuallyEnter, txtCarIdManual, btnSearchCar,
                lblBrand,   txtBrand,   lblCarId,  txtCarId,
                lblModel,   txtModel,   lblDemand, txtDemand,
                lblVarient, txtVarient,
                lblColor,   txtColor,   lblYear,   txtYear,
                lblEngine,  txtEngine,  lblBody,   txtBody,
                lblOrigin,  txtOrigin,

                // Middle
                lblCustSearchName, txtCustSearchName,
                lblCustSearchCnic, txtCustSearchCnic,
                btnSearchCustomer,
                lblCustName, txtCustName, lblCustId,      txtCustId,
                lblCustCnic, txtCustCnic, lblCustCell,    txtCustCell,
                lblCustAddress, txtCustAddress,
                lblCustEmail,   txtCustEmail,

                // Right
                lblDate, txtDate, lblTime, txtTime,
                lblDemandRight, txtDemandRight,
                lblDiscount,    txtDiscount,
                lblSoldPrice,   txtSoldPrice,
                btnFinalizeDeal
            });

            this.ResumeLayout(false);
        }

        // ════════════════════════════════════════════════════════════════════════
        //  HELPER — Label + TextBox pair
        // ════════════════════════════════════════════════════════════════════════
        private void MakeField(
            System.Windows.Forms.Label lbl, string labelText,
            System.Windows.Forms.TextBox txt,
            int x, int y, int labelWidth, int textWidth, bool readOnly)
        {
            lbl.Text = labelText;
            lbl.Location = new System.Drawing.Point(x, y + 4);
            lbl.Size = new System.Drawing.Size(labelWidth, 18);
            lbl.ForeColor = System.Drawing.Color.FromArgb(55, 55, 55);

            txt.Location = new System.Drawing.Point(x + labelWidth + 4, y);
            txt.Size = new System.Drawing.Size(textWidth, 22);
            txt.ReadOnly = readOnly;
            txt.BackColor = readOnly
                              ? System.Drawing.Color.FromArgb(235, 235, 235)
                              : System.Drawing.Color.White;
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        #endregion

        // ── Control Declarations ─────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader, pnlDiv1, pnlDiv2;
        private System.Windows.Forms.Label lblTitle;

        // Left
        private System.Windows.Forms.Label lblOrManuallyEnter;
        private System.Windows.Forms.TextBox txtCarIdManual;
        private System.Windows.Forms.Button btnSearchCar;
        private System.Windows.Forms.Label lblBrand, lblCarId, lblModel, lblDemand;
        private System.Windows.Forms.TextBox txtBrand, txtCarId, txtModel, txtDemand;
        private System.Windows.Forms.Label lblVarient, lblColor, lblYear, lblEngine;
        private System.Windows.Forms.TextBox txtVarient, txtColor, txtYear, txtEngine;
        private System.Windows.Forms.Label lblBody, lblOrigin;
        private System.Windows.Forms.TextBox txtBody, txtOrigin;

        // Middle
        private System.Windows.Forms.Label lblCustSearchName, lblCustSearchCnic;
        private System.Windows.Forms.TextBox txtCustSearchName, txtCustSearchCnic;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Label lblCustName, lblCustId, lblCustCnic, lblCustCell;
        private System.Windows.Forms.TextBox txtCustName, txtCustId, txtCustCnic, txtCustCell;
        private System.Windows.Forms.Label lblCustAddress, lblCustEmail;
        private System.Windows.Forms.TextBox txtCustAddress, txtCustEmail;

        // Right
        private System.Windows.Forms.Label lblDate, lblTime;
        private System.Windows.Forms.TextBox txtDate, txtTime;
        private System.Windows.Forms.Label lblDemandRight, lblDiscount, lblSoldPrice;
        private System.Windows.Forms.TextBox txtDemandRight, txtDiscount, txtSoldPrice;
        private System.Windows.Forms.Button btnFinalizeDeal;
    }
}