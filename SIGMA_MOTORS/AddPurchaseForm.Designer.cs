namespace SIGMA_MOTORS
{
    partial class AddPurchaseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var darkRed = System.Drawing.Color.FromArgb(139, 0, 0);
            var sectionRed = System.Drawing.Color.FromArgb(190, 0, 0);
            var bg = System.Drawing.Color.FromArgb(245, 245, 245);
            var segoe = new System.Drawing.Font("Segoe UI", 9.5F);
            var segoeBold = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubHeader = new System.Windows.Forms.Label();

            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.lblSupSection = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();

            this.pnlVehicle = new System.Windows.Forms.Panel();
            this.lblVehSection = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.lblVarient = new System.Windows.Forms.Label();
            this.cmbVarient = new System.Windows.Forms.ComboBox();
            this.lblColour = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();

            this.pnlPrice = new System.Windows.Forms.Panel();
            this.lblPriceSection = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ═══════════════════════════════════════════
            //  FORM  — wider to fit two columns properly
            // ═══════════════════════════════════════════
            this.Text = "New Purchase Order";
            this.ClientSize = new System.Drawing.Size(700, 590);
            this.BackColor = bg;
            this.Font = segoe;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Load += new System.EventHandler(this.AddPurchaseForm_Load);

            // ── HEADER ────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 58;
            this.pnlHeader.BackColor = darkRed;

            this.lblHeader.Text = "New Purchase Order";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(16, 6);
            this.lblHeader.Size = new System.Drawing.Size(450, 26);

            this.lblSubHeader.Text = "Vehicle will be automatically added to Inventory";
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubHeader.ForeColor = System.Drawing.Color.FromArgb(255, 200, 200);
            this.lblSubHeader.Location = new System.Drawing.Point(18, 35);
            this.lblSubHeader.Size = new System.Drawing.Size(450, 18);

            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblSubHeader);

            // ── Layout constants ───────────────────────
            // Two-column grid: left col starts at x=10, right col at x=355
            // Each column: label width=100, control width=220
            int PW = 660;   // panel width
            int PX = 18;    // panel x on form
            int LW = 105;   // label width
            int CW = 215;   // combo/text width per column
            int COL2 = 355;   // second column x inside panel
            int RH = 32;    // row height step
            int IY = 28;    // first row y inside panel (below section bar)

            // ══════════════════════════════════════════
            //  SECTION 1 — SUPPLIER
            // ══════════════════════════════════════════
            int py = 66;   // panel y on form (below header gap)

            // Section bar label (INSIDE panel at top)
            this.lblSupSection.Text = "  Supplier Details";
            this.lblSupSection.Location = new System.Drawing.Point(0, 0);
            this.lblSupSection.Size = new System.Drawing.Size(PW, 24);
            this.lblSupSection.BackColor = sectionRed;
            this.lblSupSection.ForeColor = System.Drawing.Color.White;
            this.lblSupSection.Font = segoeBold;

            // Row: Supplier | Date
            L(this.lblSupplier, "Supplier :", 10, IY + 4);
            C(this.cmbSupplier, 10 + LW, IY, CW);
            L(this.lblDate, "Date :", COL2, IY + 4);
            T(this.txtDate, COL2 + LW, IY, CW, true);

            this.pnlSupplier.Location = new System.Drawing.Point(PX, py);
            this.pnlSupplier.Size = new System.Drawing.Size(PW, IY + RH + 4);
            this.pnlSupplier.BackColor = System.Drawing.Color.White;
            this.pnlSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSupplier.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSupSection,
                this.lblSupplier, this.cmbSupplier,
                this.lblDate,     this.txtDate
            });

            py += this.pnlSupplier.Height + 8;

            // ══════════════════════════════════════════
            //  SECTION 2 — VEHICLE
            // ══════════════════════════════════════════
            this.lblVehSection.Text = "  Vehicle Details";
            this.lblVehSection.Location = new System.Drawing.Point(0, 0);
            this.lblVehSection.Size = new System.Drawing.Size(PW, 24);
            this.lblVehSection.BackColor = sectionRed;
            this.lblVehSection.ForeColor = System.Drawing.Color.White;
            this.lblVehSection.Font = segoeBold;

            int ry = IY;

            // Row 1: Brand | Model
            L(this.lblBrand, "Brand :", 10, ry + 4);
            C(this.cmbBrand, 10 + LW, ry, CW);
            L(this.lblModel, "Model :", COL2, ry + 4);
            C(this.cmbModel, COL2 + LW, ry, CW);
            ry += RH;

            // Row 2: Variant | Colour
            L(this.lblVarient, "Variant :", 10, ry + 4);
            C(this.cmbVarient, 10 + LW, ry, CW);
            L(this.lblColour, "Colour :", COL2, ry + 4);
            T(this.txtColour, COL2 + LW, ry, CW, false);
            ry += RH;

            // Row 3: Year | Reg No.
            L(this.lblYear, "Year :", 10, ry + 4);
            T(this.txtYear, 10 + LW, ry, CW, false);
            L(this.lblRegNo, "Reg No. :", COL2, ry + 4);
            T(this.txtRegNo, COL2 + LW, ry, CW, false);
            ry += RH;

            // Row 4: Engine | Body (readonly — auto-filled)
            L(this.lblEngine, "Engine :", 10, ry + 4);
            T(this.txtEngine, 10 + LW, ry, CW, true);
            L(this.lblBody, "Body :", COL2, ry + 4);
            T(this.txtBody, COL2 + LW, ry, CW, true);
            ry += RH;

            // Row 5: Origin (readonly — auto-filled)
            L(this.lblOrigin, "Origin :", 10, ry + 4);
            T(this.txtOrigin, 10 + LW, ry, CW, true);
            ry += RH;

            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);

            this.pnlVehicle.Location = new System.Drawing.Point(PX, py);
            this.pnlVehicle.Size = new System.Drawing.Size(PW, ry + 4);
            this.pnlVehicle.BackColor = System.Drawing.Color.White;
            this.pnlVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVehicle.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblVehSection,
                this.lblBrand,   this.cmbBrand,   this.lblModel,   this.cmbModel,
                this.lblVarient, this.cmbVarient, this.lblColour,  this.txtColour,
                this.lblYear,    this.txtYear,    this.lblRegNo,   this.txtRegNo,
                this.lblEngine,  this.txtEngine,  this.lblBody,    this.txtBody,
                this.lblOrigin,  this.txtOrigin
            });

            py += this.pnlVehicle.Height + 8;

            // ══════════════════════════════════════════
            //  SECTION 3 — PRICE
            // ══════════════════════════════════════════
            this.lblPriceSection.Text = "  Purchase Price";
            this.lblPriceSection.Location = new System.Drawing.Point(0, 0);
            this.lblPriceSection.Size = new System.Drawing.Size(PW, 24);
            this.lblPriceSection.BackColor = sectionRed;
            this.lblPriceSection.ForeColor = System.Drawing.Color.White;
            this.lblPriceSection.Font = segoeBold;

            L(this.lblPrice, "Price (PKR) :", 10, IY + 2);
            T(this.txtPrice, 10 + LW, IY - 2, PW - LW - 30, false);
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtPrice.ForeColor = darkRed;

            this.pnlPrice.Location = new System.Drawing.Point(PX, py);
            this.pnlPrice.Size = new System.Drawing.Size(PW, IY + RH);
            this.pnlPrice.BackColor = System.Drawing.Color.White;
            this.pnlPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrice.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblPriceSection, this.lblPrice, this.txtPrice
            });

            py += this.pnlPrice.Height + 12;

            // ── BUTTONS ───────────────────────────────
            this.btnSave.Text = "Create Purchase Order";
            this.btnSave.Location = new System.Drawing.Point(PX, py);
            this.btnSave.Size = new System.Drawing.Size(220, 38);
            this.btnSave.BackColor = darkRed;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(PX + 230, py);
            this.btnCancel.Size = new System.Drawing.Size(110, 38);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Auto-resize form height to fit content
            this.ClientSize = new System.Drawing.Size(700, py + 50);

            // ── ADD TO FORM ───────────────────────────
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlSupplier,
                this.pnlVehicle,
                this.pnlPrice,
                this.btnSave,
                this.btnCancel,
                this.pnlHeader   // header LAST = docks top correctly
            });

            this.ResumeLayout(false);
        }

        // ── Layout helpers ─────────────────────────────────────────────────────
        private void L(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(100, 20);
            lbl.ForeColor = System.Drawing.Color.FromArgb(55, 55, 55);
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        }

        private void T(System.Windows.Forms.TextBox txt, int x, int y, int w, bool ro)
        {
            txt.Location = new System.Drawing.Point(x, y);
            txt.Size = new System.Drawing.Size(w, 24);
            txt.ReadOnly = ro;
            txt.BackColor = ro
                ? System.Drawing.Color.FromArgb(235, 235, 235)
                : System.Drawing.Color.White;
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        }

        private void C(System.Windows.Forms.ComboBox cmb, int x, int y, int w)
        {
            cmb.Location = new System.Drawing.Point(x, y);
            cmb.Size = new System.Drawing.Size(w, 24);
            cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmb.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        }

        // ── Field declarations ─────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader, pnlSupplier, pnlVehicle, pnlPrice;
        private System.Windows.Forms.Label lblHeader, lblSubHeader;
        private System.Windows.Forms.Label lblSupSection, lblVehSection, lblPriceSection;
        private System.Windows.Forms.Label lblSupplier, lblDate;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblBrand, lblModel, lblVarient, lblColour;
        private System.Windows.Forms.ComboBox cmbBrand, cmbModel, cmbVarient;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label lblYear, lblRegNo, lblEngine, lblBody, lblOrigin;
        private System.Windows.Forms.TextBox txtYear, txtRegNo, txtEngine, txtBody, txtOrigin;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave, btnCancel;
    }
}