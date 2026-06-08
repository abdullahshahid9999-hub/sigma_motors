namespace SIGMA_MOTORS
{
    partial class EditEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFieldsSection;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCnic;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFieldsSection = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCnic = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ── pnlHeader ────────────────────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);

            this.lblFormTitle.Text = "Edit Employee";
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);

            this.pnlHeader.Controls.Add(this.lblFormTitle);

            // ── pnlBottom ────────────────────────────────────────────────────
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Height = 60;
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);

            this.btnSave.Text = "Save Changes";
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(195, 14);
            this.btnSave.Size = new System.Drawing.Size(115, 32);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Location = new System.Drawing.Point(320, 14);
            this.btnCancel.Size = new System.Drawing.Size(95, 32);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Controls.Add(this.btnCancel);

            // ── pnlFields ────────────────────────────────────────────────────
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            this.lblFieldsSection.Text = "EMPLOYEE DETAILS";
            this.lblFieldsSection.Location = new System.Drawing.Point(0, 0);
            this.lblFieldsSection.AutoSize = true;
            this.lblFieldsSection.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.lblFieldsSection.ForeColor = System.Drawing.Color.Gray;

            // Name
            this.lblName.Text = "Full Name";
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblName.Location = new System.Drawing.Point(20, 18);
            this.lblName.AutoSize = true;

            this.txtName.Text = "Full Name";
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(20, 36);
            this.txtName.Size = new System.Drawing.Size(390, 28);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.GotFocus += new System.EventHandler(this.txtName_GotFocus);
            this.txtName.LostFocus += new System.EventHandler(this.txtName_LostFocus);

            // CNIC
            this.lblCnic.Text = "CNIC (13 digits, numbers only)";
            this.lblCnic.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCnic.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblCnic.Location = new System.Drawing.Point(20, 78);
            this.lblCnic.AutoSize = true;

            this.txtCnic.Text = "13-digit CNIC";
            this.txtCnic.ForeColor = System.Drawing.Color.Gray;
            this.txtCnic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCnic.Location = new System.Drawing.Point(20, 96);
            this.txtCnic.Size = new System.Drawing.Size(390, 28);
            this.txtCnic.MaxLength = 13;
            this.txtCnic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnic.GotFocus += new System.EventHandler(this.txtCnic_GotFocus);
            this.txtCnic.LostFocus += new System.EventHandler(this.txtCnic_LostFocus);

            // Role
            this.lblRole.Text = "Role";
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblRole.Location = new System.Drawing.Point(20, 138);
            this.lblRole.AutoSize = true;

            this.txtRole.Text = "Role";
            this.txtRole.ForeColor = System.Drawing.Color.Gray;
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRole.Location = new System.Drawing.Point(20, 156);
            this.txtRole.Size = new System.Drawing.Size(390, 28);
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRole.GotFocus += new System.EventHandler(this.txtRole_GotFocus);
            this.txtRole.LostFocus += new System.EventHandler(this.txtRole_LostFocus);

            // Login ID
            this.lblLoginId.Text = "Login ID";
            this.lblLoginId.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblLoginId.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblLoginId.Location = new System.Drawing.Point(20, 198);
            this.lblLoginId.AutoSize = true;

            this.txtLoginId.Text = "Login ID";
            this.txtLoginId.ForeColor = System.Drawing.Color.Gray;
            this.txtLoginId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLoginId.Location = new System.Drawing.Point(20, 216);
            this.txtLoginId.Size = new System.Drawing.Size(390, 28);
            this.txtLoginId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginId.GotFocus += new System.EventHandler(this.txtLoginId_GotFocus);
            this.txtLoginId.LostFocus += new System.EventHandler(this.txtLoginId_LostFocus);

            // Password
            this.lblPassword.Text = "Password";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblPassword.Location = new System.Drawing.Point(20, 258);
            this.lblPassword.AutoSize = true;

            this.txtPassword.Text = "Password";
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(20, 276);
            this.txtPassword.Size = new System.Drawing.Size(390, 28);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.GotFocus += new System.EventHandler(this.txtPassword_GotFocus);
            this.txtPassword.LostFocus += new System.EventHandler(this.txtPassword_LostFocus);

            // Is Active
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.chkIsActive.Location = new System.Drawing.Point(20, 322);
            this.chkIsActive.AutoSize = true;

            this.pnlFields.Controls.Add(this.lblFieldsSection);
            this.pnlFields.Controls.Add(this.lblName);
            this.pnlFields.Controls.Add(this.txtName);
            this.pnlFields.Controls.Add(this.lblCnic);
            this.pnlFields.Controls.Add(this.txtCnic);
            this.pnlFields.Controls.Add(this.lblRole);
            this.pnlFields.Controls.Add(this.txtRole);
            this.pnlFields.Controls.Add(this.lblLoginId);
            this.pnlFields.Controls.Add(this.txtLoginId);
            this.pnlFields.Controls.Add(this.lblPassword);
            this.pnlFields.Controls.Add(this.txtPassword);
            this.pnlFields.Controls.Add(this.chkIsActive);

            // ── Form ─────────────────────────────────────────────────────────
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text = "Edit Employee";
            this.ClientSize = new System.Drawing.Size(440, 490);
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;

            // Fill first, Bottom second, Top last
            this.Controls.Add(this.pnlFields);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);

            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);

            this.ResumeLayout(false);
        }
    }
}