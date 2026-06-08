namespace SIGMA_MOTORS
{
    partial class EditVehicleForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblVehicleId = new System.Windows.Forms.Label();

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
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════════════════════════════════
            this.Text = "Edit Vehicle";
            this.ClientSize = new System.Drawing.Size(480, 460);
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Load += new System.EventHandler(this.EditVehicleForm_Load);

            // ════════════════════════════════════════════════════════════════════
            //  HEADER
            // ════════════════════════════════════════════════════════════════════
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(480, 52);

            this.lblHeader.Text = "Edit Vehicle Details";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(14, 12);
            this.lblHeader.Size = new System.Drawing.Size(280, 28);

            this.lblVehicleId.Text = "Vehicle ID: —";
            this.lblVehicleId.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblVehicleId.ForeColor = System.Drawing.Color.FromArgb(255, 200, 200);
            this.lblVehicleId.Location = new System.Drawing.Point(340, 18);
            this.lblVehicleId.Size = new System.Drawing.Size(120, 18);

            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[]
                { lblHeader, lblVehicleId });

            // ════════════════════════════════════════════════════════════════════
            //  FIELDS  (x=20, labels width=120, controls width=310)
            // ════════════════════════════════════════════════════════════════════
            int fx = 20, lw = 130, cx = 160, cw = 290, sy = 70, sh = 42;

            MakeLabel(this.lblBrand, "Brand :", fx, sy + sh * 0);
            MakeCombo(this.cmbBrand, cx, sy + sh * 0, cw);

            MakeLabel(this.lblModel, "Model :", fx, sy + sh * 1);
            MakeCombo(this.cmbModel, cx, sy + sh * 1, cw);

            MakeLabel(this.lblVarient, "Variant :", fx, sy + sh * 2);
            MakeCombo(this.cmbVarient, cx, sy + sh * 2, cw);

            MakeLabel(this.lblColour, "Colour :", fx, sy + sh * 3);
            MakeTxt(this.txtColour, cx, sy + sh * 3, cw);

            MakeLabel(this.lblYear, "Manufacture Year :", fx, sy + sh * 4);
            MakeTxt(this.txtYear, cx, sy + sh * 4, cw);

            MakeLabel(this.lblPrice, "Price (PKR) :", fx, sy + sh * 5);
            MakeTxt(this.txtPrice, cx, sy + sh * 5, cw);

            MakeLabel(this.lblRegNo, "Reg. Number :", fx, sy + sh * 6);
            MakeTxt(this.txtRegNo, cx, sy + sh * 6, cw);

            MakeLabel(this.lblStatus, "Status :", fx, sy + sh * 7);
            MakeCombo(this.cmbStatus, cx, sy + sh * 7, cw);

            // ════════════════════════════════════════════════════════════════════
            //  BUTTONS
            // ════════════════════════════════════════════════════════════════════
            this.btnSave.Text = "Save Changes";
            this.btnSave.Location = new System.Drawing.Point(cx, sy + sh * 8 + 8);
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(cx + 150, sy + sh * 8 + 8);
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ════════════════════════════════════════════════════════════════════
            //  ADD ALL
            // ════════════════════════════════════════════════════════════════════
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                pnlHeader,
                lblBrand,   cmbBrand,
                lblModel,   cmbModel,
                lblVarient, cmbVarient,
                lblColour,  txtColour,
                lblYear,    txtYear,
                lblPrice,   txtPrice,
                lblRegNo,   txtRegNo,
                lblStatus,  cmbStatus,
                btnSave,    btnCancel
            });

            this.ResumeLayout(false);
        }

        // ── Helpers ──────────────────────────────────────────────────────────────
        private void MakeLabel(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y + 6);
            lbl.Size = new System.Drawing.Size(130, 20);
            lbl.ForeColor = System.Drawing.Color.FromArgb(55, 55, 55);
        }

        private void MakeTxt(System.Windows.Forms.TextBox txt, int x, int y, int w)
        {
            txt.Location = new System.Drawing.Point(x, y);
            txt.Size = new System.Drawing.Size(w, 24);
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt.BackColor = System.Drawing.Color.White;
        }

        private void MakeCombo(System.Windows.Forms.ComboBox cmb, int x, int y, int w)
        {
            cmb.Location = new System.Drawing.Point(x, y);
            cmb.Size = new System.Drawing.Size(w, 24);
            cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        #endregion

        // Declarations
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader, lblVehicleId;
        private System.Windows.Forms.Label lblBrand, lblModel, lblVarient;
        private System.Windows.Forms.ComboBox cmbBrand, cmbModel, cmbVarient, cmbStatus;
        private System.Windows.Forms.Label lblColour, lblYear, lblPrice, lblRegNo, lblStatus;
        private System.Windows.Forms.TextBox txtColour, txtYear, txtPrice, txtRegNo;
        private System.Windows.Forms.Button btnSave, btnCancel;
    }
}