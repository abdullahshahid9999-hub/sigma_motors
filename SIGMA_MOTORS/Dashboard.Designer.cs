namespace SIGMA_MOTORS
{
    partial class Dashboard
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
            // ── Top bar ──────────────────────────────────────────────────────────
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnPower = new System.Windows.Forms.Button();

            // ── Sidebar ──────────────────────────────────────────────────────────
            this.panelSide = new System.Windows.Forms.Panel();

            // Logo area inside sidebar
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblLogoSub = new System.Windows.Forms.Label();

            // Nav buttons
            this.btnDash = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();

            // ── Main content ─────────────────────────────────────────────────────
            this.MainContentPanel = new System.Windows.Forms.Panel();

            this.panelTop.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelSide.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════════════════════════════════
            this.Text = "Sigma Motors — ERP";
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.Dashboard_Load);

            // ════════════════════════════════════════════════════════════════════
            //  TOP BAR
            // ════════════════════════════════════════════════════════════════════
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 62;
            this.panelTop.Name = "panelTop";

            this.lblTitle.Text = "SIGMA MOTORS  |  FAISALABAD  |  PAKWHEELS VERIFIED DEALER";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 17);
            this.lblTitle.Size = new System.Drawing.Size(680, 28);
            this.lblTitle.AutoSize = false;

            this.panelUser.Anchor = System.Windows.Forms.AnchorStyles.Top
                                  | System.Windows.Forms.AnchorStyles.Right;
            this.panelUser.Location = new System.Drawing.Point(880, 6);
            this.panelUser.Size = new System.Drawing.Size(390, 50);
            this.panelUser.BackColor = System.Drawing.Color.Transparent;
            this.panelUser.Name = "panelUser";

            this.picUser.Location = new System.Drawing.Point(6, 4);
            this.picUser.Size = new System.Drawing.Size(42, 42);
            this.picUser.BackColor = System.Drawing.Color.White;
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.Name = "picUser";

            this.lblUserName.Text = "User ▼";
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(56, 14);
            this.lblUserName.Size = new System.Drawing.Size(270, 22);
            this.lblUserName.AutoSize = false;
            this.lblUserName.Name = "lblUserName";

            this.btnPower.Text = "⏻";
            this.btnPower.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnPower.ForeColor = System.Drawing.Color.White;
            this.btnPower.BackColor = System.Drawing.Color.Transparent;
            this.btnPower.Location = new System.Drawing.Point(340, 5);
            this.btnPower.Size = new System.Drawing.Size(44, 42);
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.FlatAppearance.BorderSize = 0;
            this.btnPower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(100, 0, 0);
            this.btnPower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPower.Name = "btnPower";
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);

            this.panelUser.Controls.AddRange(new System.Windows.Forms.Control[]
                { picUser, lblUserName, btnPower });
            this.panelTop.Controls.AddRange(new System.Windows.Forms.Control[]
                { lblTitle, panelUser });

            // ════════════════════════════════════════════════════════════════════
            //  SIDEBAR
            // ════════════════════════════════════════════════════════════════════
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Width = 220;
            this.panelSide.Name = "panelSide";

            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Size = new System.Drawing.Size(220, 90);
            this.pnlLogo.Name = "pnlLogo";

            this.picLogo.Location = new System.Drawing.Point(10, 8);
            this.picLogo.Size = new System.Drawing.Size(72, 52);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Name = "picLogo";

            this.lblLogoSub.Text = "MOTORS ERP v1.0";
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(140, 140, 140);
            this.lblLogoSub.Location = new System.Drawing.Point(90, 38);
            this.lblLogoSub.Size = new System.Drawing.Size(120, 16);
            this.lblLogoSub.Name = "lblLogoSub";

            var lblLogoName = new System.Windows.Forms.Label();
            lblLogoName.Text = "SIGMA MOTORS";
            lblLogoName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblLogoName.ForeColor = System.Drawing.Color.White;
            lblLogoName.Location = new System.Drawing.Point(90, 18);
            lblLogoName.Size = new System.Drawing.Size(120, 18);

            this.pnlLogo.Controls.AddRange(new System.Windows.Forms.Control[]
                { picLogo, lblLogoName, lblLogoSub });

            // ── Nav Buttons ──────────────────────────────────────────────────────
            int bw = 220, bh = 54;

            SetNavBtn(btnDash, "btnDash", "🏠   Dashboard", 0, bw, bh);
            SetNavBtn(btnInventory, "btnInventory", "🚗   Inventory", 1, bw, bh);
            SetNavBtn(btnSales, "btnSales", "💰   Sales Dept", 2, bw, bh);
            SetNavBtn(btnPurchase, "btnPurchase", "📦   Purchase", 3, bw, bh);
            SetNavBtn(btnCustomer, "btnCustomer", "👤   Customers", 4, bw, bh);
            SetNavBtn(btnSupplier, "btnSupplier", "🏭   Suppliers", 5, bw, bh);
            SetNavBtn(btnEmployee, "btnEmployee", "👔   Employees", 6, bw, bh);
            SetNavBtn(btnReports, "btnReports", "📊   Reports", 7, bw, bh);
            SetNavBtn(btnInvoices, "btnInvoices", "🧾   Invoices", 8, bw, bh);

            btnDash.Click += new System.EventHandler(this.Navigation_Click);
            btnInventory.Click += new System.EventHandler(this.Navigation_Click);
            btnSales.Click += new System.EventHandler(this.Navigation_Click);
            btnPurchase.Click += new System.EventHandler(this.Navigation_Click);
            btnCustomer.Click += new System.EventHandler(this.Navigation_Click);
            btnSupplier.Click += new System.EventHandler(this.Navigation_Click);
            btnEmployee.Click += new System.EventHandler(this.Navigation_Click);
            btnReports.Click += new System.EventHandler(this.Navigation_Click);
            btnInvoices.Click += new System.EventHandler(this.Navigation_Click);

            var pnlSep = new System.Windows.Forms.Panel();
            pnlSep.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            pnlSep.Location = new System.Drawing.Point(0, 90);
            pnlSep.Size = new System.Drawing.Size(220, 1);

            this.panelSide.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                pnlLogo, pnlSep,
                btnDash, btnInventory, btnSales, btnPurchase,
                btnCustomer, btnSupplier, btnEmployee, btnReports, btnInvoices
            });

            // ════════════════════════════════════════════════════════════════════
            //  MAIN CONTENT PANEL
            // ════════════════════════════════════════════════════════════════════
            this.MainContentPanel.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainContentPanel_Paint);

            // ════════════════════════════════════════════════════════════════════
            //  ADD TO FORM
            // ════════════════════════════════════════════════════════════════════
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);

            this.panelTop.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelSide.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void SetNavBtn(System.Windows.Forms.Button btn, string name,
            string text, int index, int w, int h)
        {
            int logoHeight = 91;
            btn.Name = name;
            btn.Text = text;
            btn.Location = new System.Drawing.Point(0, logoHeight + index * h);
            btn.Size = new System.Drawing.Size(w, h);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btn.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            btn.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.TabIndex = index;
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Button btnDash, btnInventory, btnSales, btnPurchase;
        private System.Windows.Forms.Button btnCustomer, btnSupplier, btnEmployee, btnReports;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Panel MainContentPanel;
    }
}