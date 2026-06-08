namespace SIGMA_MOTORS
{
    partial class EditCustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var darkRed = System.Drawing.Color.FromArgb(139, 0, 0);
            var bg = System.Drawing.Color.FromArgb(245, 245, 245);
            var segoe = new System.Drawing.Font("Segoe UI", 9.5F);
            var segoeBold = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // ── Form ──────────────────────────────────────────────────────────
            this.Text = "Edit Customer";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = bg;
            this.ClientSize = new System.Drawing.Size(420, 460);
            this.Font = segoe;

            // ── Header ────────────────────────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 50;
            this.pnlHeader.BackColor = darkRed;

            this.lblHeader.Text = "Edit Customer";
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlHeader.Controls.Add(this.lblHeader);

            // ── Body ──────────────────────────────────────────────────────────
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.BackColor = bg;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);

            int y = 20;
            AddField(this.pnlBody, this.lblName, "Full Name *", this.txtName, ref y, segoe, segoeBold);
            AddField(this.pnlBody, this.lblCNIC, "CNIC (13 digits) *", this.txtCNIC, ref y, segoe, segoeBold);
            AddField(this.pnlBody, this.lblPhone, "Phone (11 digits) *", this.txtPhone, ref y, segoe, segoeBold);
            AddField(this.pnlBody, this.lblEmail, "Email", this.txtEmail, ref y, segoe, segoeBold);
            AddField(this.pnlBody, this.lblAddress, "Address", this.txtAddress, ref y, segoe, segoeBold);

            // Buttons
            this.btnSave.Text = "Update Customer";
            this.btnSave.Location = new System.Drawing.Point(0, y + 10);
            this.btnSave.Size = new System.Drawing.Size(160, 36);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.BackColor = darkRed;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = segoeBold;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(175, y + 10);
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Font = segoeBold;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.pnlBody.Controls.Add(this.btnSave);
            this.pnlBody.Controls.Add(this.btnCancel);

            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
        }

        private void AddField(System.Windows.Forms.Panel parent,
                               System.Windows.Forms.Label lbl,
                               string labelText,
                               System.Windows.Forms.TextBox txt,
                               ref int y,
                               System.Drawing.Font font,
                               System.Drawing.Font boldFont)
        {
            lbl.Text = labelText;
            lbl.Location = new System.Drawing.Point(0, y);
            lbl.Size = new System.Drawing.Size(350, 18);
            lbl.Font = boldFont;
            lbl.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            parent.Controls.Add(lbl);
            y += 22;

            txt.Location = new System.Drawing.Point(0, y);
            txt.Width = 350;
            txt.Height = 28;
            txt.Font = font;
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt.BackColor = System.Drawing.Color.White;
            parent.Controls.Add(txt);
            y += 36;
        }
    }
}