namespace SIGMA_MOTORS
{
    partial class EditPurchaseStatusForm
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
            var sectionRed = System.Drawing.Color.FromArgb(200, 0, 0);
            var bg = System.Drawing.Color.FromArgb(245, 245, 245);
            var segoe = new System.Drawing.Font("Segoe UI", 9.5F);
            var segoeBold = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.lblPoIdLbl = new System.Windows.Forms.Label();
            this.lblPoId = new System.Windows.Forms.Label();
            this.lblVehicleLbl = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblSupLbl = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblPriceLbl = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDateLbl = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCurrentLbl = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.cmbNewStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ── Form ──────────────────────────────────────────────────────────
            this.Text = "Update Purchase Status";
            this.ClientSize = new System.Drawing.Size(480, 430);
            this.BackColor = bg;
            this.Font = segoe;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Load += new System.EventHandler(this.EditPurchaseStatusForm_Load);

            // ── Header panel (docked top) ──────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 50;
            this.pnlHeader.BackColor = darkRed;

            this.lblHeader.Text = "Update Purchase Order Status";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlHeader.Controls.Add(this.lblHeader);

            // ── Info section panel ─────────────────────────────────────────────
            // Panel position is relative to form client area (below header)
            this.pnlInfo.Location = new System.Drawing.Point(20, 62);
            this.pnlInfo.Size = new System.Drawing.Size(440, 220);
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Section title bar INSIDE pnlInfo at top
            this.lblInfoTitle.Text = "  Order Details";
            this.lblInfoTitle.Location = new System.Drawing.Point(0, 0);
            this.lblInfoTitle.Size = new System.Drawing.Size(440, 24);
            this.lblInfoTitle.BackColor = sectionRed;
            this.lblInfoTitle.ForeColor = System.Drawing.Color.White;
            this.lblInfoTitle.Font = segoeBold;

            // Rows INSIDE pnlInfo (y relative to pnlInfo top)
            int lx = 10, vx = 145, vw = 275, ry = 30, rs = 30;

            SetRow(this.lblPoIdLbl, "PO ID :", lx, ry);
            SetVal(this.lblPoId, "—", vx, ry, vw);
            ry += rs;
            SetRow(this.lblVehicleLbl, "Vehicle :", lx, ry);
            SetVal(this.lblVehicle, "—", vx, ry, vw);
            ry += rs;
            SetRow(this.lblSupLbl, "Supplier :", lx, ry);
            SetVal(this.lblSupplier, "—", vx, ry, vw);
            ry += rs;
            SetRow(this.lblPriceLbl, "Purchase Price :", lx, ry);
            SetVal(this.lblPrice, "—", vx, ry, vw);
            this.lblPrice.Font = segoeBold;
            this.lblPrice.ForeColor = darkRed;
            ry += rs;
            SetRow(this.lblDateLbl, "Date :", lx, ry);
            SetVal(this.lblDate, "—", vx, ry, vw);
            ry += rs;
            SetRow(this.lblCurrentLbl, "Current Status :", lx, ry);
            SetVal(this.lblCurrent, "—", vx, ry, vw);
            this.lblCurrent.Font = segoeBold;
            this.lblCurrent.ForeColor = System.Drawing.Color.FromArgb(180, 100, 0);

            // Add all row labels and value labels INTO pnlInfo
            this.pnlInfo.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblInfoTitle,
                this.lblPoIdLbl,    this.lblPoId,
                this.lblVehicleLbl, this.lblVehicle,
                this.lblSupLbl,     this.lblSupplier,
                this.lblPriceLbl,   this.lblPrice,
                this.lblDateLbl,    this.lblDate,
                this.lblCurrentLbl, this.lblCurrent
            });

            // ── Update section panel ───────────────────────────────────────────
            this.pnlUpdate.Location = new System.Drawing.Point(20, 295);
            this.pnlUpdate.Size = new System.Drawing.Size(440, 65);
            this.pnlUpdate.BackColor = System.Drawing.Color.White;
            this.pnlUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblUpdateTitle.Text = "  Change Status";
            this.lblUpdateTitle.Location = new System.Drawing.Point(0, 0);
            this.lblUpdateTitle.Size = new System.Drawing.Size(440, 24);
            this.lblUpdateTitle.BackColor = sectionRed;
            this.lblUpdateTitle.ForeColor = System.Drawing.Color.White;
            this.lblUpdateTitle.Font = segoeBold;

            this.lblNewStatus.Text = "New Status :";
            this.lblNewStatus.Location = new System.Drawing.Point(10, 34);
            this.lblNewStatus.Size = new System.Drawing.Size(120, 22);
            this.lblNewStatus.ForeColor = System.Drawing.Color.FromArgb(55, 55, 55);

            this.cmbNewStatus.Location = new System.Drawing.Point(145, 31);
            this.cmbNewStatus.Size = new System.Drawing.Size(200, 24);
            this.cmbNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNewStatus.Font = segoe;

            this.pnlUpdate.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblUpdateTitle, this.lblNewStatus, this.cmbNewStatus
            });

            // ── Buttons ───────────────────────────────────────────────────────
            this.btnUpdate.Text = "Update Status";
            this.btnUpdate.Location = new System.Drawing.Point(20, 375);
            this.btnUpdate.Size = new System.Drawing.Size(180, 38);
            this.btnUpdate.BackColor = darkRed;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(210, 375);
            this.btnClose.Size = new System.Drawing.Size(110, 38);
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ── Add all to form ───────────────────────────────────────────────
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlInfo,
                this.pnlUpdate,
                this.btnUpdate,
                this.btnClose,
                this.pnlHeader   // header last = docks on top correctly
            });

            this.ResumeLayout(false);
        }

        private void SetRow(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(130, 20);
            lbl.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        }

        private void SetVal(System.Windows.Forms.Label lbl, string text, int x, int y, int w)
        {
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(w, 20);
            lbl.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        }

        // ── Field declarations ─────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader, pnlInfo, pnlUpdate;
        private System.Windows.Forms.Label lblHeader, lblInfoTitle, lblUpdateTitle;
        private System.Windows.Forms.Label lblPoIdLbl, lblPoId;
        private System.Windows.Forms.Label lblVehicleLbl, lblVehicle;
        private System.Windows.Forms.Label lblSupLbl, lblSupplier;
        private System.Windows.Forms.Label lblPriceLbl, lblPrice;
        private System.Windows.Forms.Label lblDateLbl, lblDate;
        private System.Windows.Forms.Label lblCurrentLbl, lblCurrent;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.ComboBox cmbNewStatus;
        private System.Windows.Forms.Button btnUpdate, btnClose;
    }
}