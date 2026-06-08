namespace SIGMA_MOTORS
{
    partial class AddCustomerForm
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

            this.SuspendLayout();

            // ── Form ──────────────────────────────────────────────────────────
            this.Text = "Add Customer";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = bg;
            this.ClientSize = new System.Drawing.Size(420, 480);
            this.Font = segoe;

            // ── Header ────────────────────────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 50;
            this.pnlHeader.BackColor = darkRed;

            this.lblHeader.Text = "Add New Customer";
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlHeader.Controls.Add(this.lblHeader);

            // ── Body ──────────────────────────────────────────────────────────
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.BackColor = bg;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_Paint);

            // Build fields inside pnlBody using padding-relative coords
            int y = 15;

            // Full Name
            this.lblName.Text = "Full Name *";
            this.lblName.Location = new System.Drawing.Point(30, y);
            this.lblName.Size = new System.Drawing.Size(355, 18);
            this.lblName.Font = segoeBold;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            y += 20;
            this.txtName.Location = new System.Drawing.Point(30, y);
            this.txtName.Size = new System.Drawing.Size(355, 28);
            this.txtName.Font = segoe;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.BackColor = System.Drawing.Color.White;
            y += 34;

            // CNIC
            this.lblCNIC.Text = "CNIC (13 digits) *";
            this.lblCNIC.Location = new System.Drawing.Point(30, y);
            this.lblCNIC.Size = new System.Drawing.Size(355, 18);
            this.lblCNIC.Font = segoeBold;
            this.lblCNIC.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            y += 20;
            this.txtCNIC.Location = new System.Drawing.Point(30, y);
            this.txtCNIC.Size = new System.Drawing.Size(355, 28);
            this.txtCNIC.Font = segoe;
            this.txtCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCNIC.BackColor = System.Drawing.Color.White;
            this.txtCNIC.MaxLength = 13;
            y += 34;

            // Phone
            this.lblPhone.Text = "Phone Number (11 digits) *";
            this.lblPhone.Location = new System.Drawing.Point(30, y);
            this.lblPhone.Size = new System.Drawing.Size(355, 18);
            this.lblPhone.Font = segoeBold;
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            y += 20;
            this.txtPhone.Location = new System.Drawing.Point(30, y);
            this.txtPhone.Size = new System.Drawing.Size(355, 28);
            this.txtPhone.Font = segoe;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.MaxLength = 11;
            y += 34;

            // Email
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new System.Drawing.Point(30, y);
            this.lblEmail.Size = new System.Drawing.Size(355, 18);
            this.lblEmail.Font = segoeBold;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            y += 20;
            this.txtEmail.Location = new System.Drawing.Point(30, y);
            this.txtEmail.Size = new System.Drawing.Size(355, 28);
            this.txtEmail.Font = segoe;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            y += 34;

            // Address
            this.lblAddress.Text = "Address";
            this.lblAddress.Location = new System.Drawing.Point(30, y);
            this.lblAddress.Size = new System.Drawing.Size(355, 18);
            this.lblAddress.Font = segoeBold;
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            y += 20;
            this.txtAddress.Location = new System.Drawing.Point(30, y);
            this.txtAddress.Size = new System.Drawing.Size(355, 28);
            this.txtAddress.Font = segoe;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            y += 40;

            // Save button
            this.btnSave.Text = "Save Customer";
            this.btnSave.Location = new System.Drawing.Point(30, y);
            this.btnSave.Size = new System.Drawing.Size(160, 36);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.BackColor = darkRed;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Font = segoeBold;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Cancel button
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(205, y);
            this.btnCancel.Size = new System.Drawing.Size(110, 36);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Font = segoeBold;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add ALL controls to pnlBody
            this.pnlBody.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblName,    this.txtName,
                this.lblCNIC,    this.txtCNIC,
                this.lblPhone,   this.txtPhone,
                this.lblEmail,   this.txtEmail,
                this.lblAddress, this.txtAddress,
                this.btnSave,    this.btnCancel
            });

            // Add panels to form (Fill first, then Top — reverse dock order)
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);

            this.ResumeLayout(false);
        }
    }
}