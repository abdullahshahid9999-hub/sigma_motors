namespace SIGMA_MOTORS
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;

        // Stat Cards
        private System.Windows.Forms.FlowLayoutPanel flowCards;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblSalesIcon;
        private System.Windows.Forms.Label lblSalesValue;
        private System.Windows.Forms.Label lblSalesTitle;

        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblPurchasesIcon;
        private System.Windows.Forms.Label lblPurchasesValue;
        private System.Windows.Forms.Label lblPurchasesTitle;

        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblRevenueIcon;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblRevenueTitle;

        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblStockIcon;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Label lblStockTitle;

        // Nav section
        private System.Windows.Forms.Panel pnlNavSection;
        private System.Windows.Forms.Label lblNavTitle;
        private System.Windows.Forms.FlowLayoutPanel flowNav;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnPurchaseReport;
        private System.Windows.Forms.Button btnInventoryReport;
        private System.Windows.Forms.Button btnProfitLoss;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.flowCards = new System.Windows.Forms.FlowLayoutPanel();

            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblSalesIcon = new System.Windows.Forms.Label();
            this.lblSalesValue = new System.Windows.Forms.Label();
            this.lblSalesTitle = new System.Windows.Forms.Label();

            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblPurchasesIcon = new System.Windows.Forms.Label();
            this.lblPurchasesValue = new System.Windows.Forms.Label();
            this.lblPurchasesTitle = new System.Windows.Forms.Label();

            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblRevenueIcon = new System.Windows.Forms.Label();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();

            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblStockIcon = new System.Windows.Forms.Label();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.lblStockTitle = new System.Windows.Forms.Label();

            this.pnlNavSection = new System.Windows.Forms.Panel();
            this.lblNavTitle = new System.Windows.Forms.Label();
            this.flowNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnPurchaseReport = new System.Windows.Forms.Button();
            this.btnInventoryReport = new System.Windows.Forms.Button();
            this.btnProfitLoss = new System.Windows.Forms.Button();

            System.Drawing.Color darkRed = System.Drawing.Color.FromArgb(139, 0, 0);
            System.Drawing.Color bg = System.Drawing.Color.FromArgb(245, 245, 245);

            // ── FORM ──────────────────────────────────────────────
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackColor = bg;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Load += new System.EventHandler(this.ReportsForm_Load);

            // ── HEADER ────────────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;
            this.pnlHeader.BackColor = darkRed;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);

            this.lblTitle.Text = "Reports  &  Analytics";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnRefresh.Text = "⟳  Refresh";
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(160, 0, 0);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(100, 0, 0);
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Size = new System.Drawing.Size(110, 34);
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lblTitle);

            // ── CARDS ROW (FlowLayoutPanel) ───────────────────────
            this.flowCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowCards.Height = 130;
            this.flowCards.BackColor = bg;
            this.flowCards.Padding = new System.Windows.Forms.Padding(16, 14, 16, 0);
            this.flowCards.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowCards.WrapContents = false;

            // -- helper: build one card panel --------------------
            // Card 1  (Sales)
            this.pnlCard1.Size = new System.Drawing.Size(218, 100);
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);

            this.lblSalesIcon.Text = "🛒";
            this.lblSalesIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblSalesIcon.AutoSize = true;
            this.lblSalesIcon.Location = new System.Drawing.Point(12, 8);

            this.lblSalesValue.Text = "—";
            this.lblSalesValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblSalesValue.ForeColor = darkRed;
            this.lblSalesValue.AutoSize = true;
            this.lblSalesValue.Location = new System.Drawing.Point(12, 32);

            this.lblSalesTitle.Text = "Sales This Month";
            this.lblSalesTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblSalesTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSalesTitle.AutoSize = true;
            this.lblSalesTitle.Location = new System.Drawing.Point(12, 72);

            this.pnlCard1.Controls.Add(this.lblSalesIcon);
            this.pnlCard1.Controls.Add(this.lblSalesValue);
            this.pnlCard1.Controls.Add(this.lblSalesTitle);

            // Card 2  (Purchases)
            this.pnlCard2.Size = new System.Drawing.Size(218, 100);
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);

            this.lblPurchasesIcon.Text = "📦";
            this.lblPurchasesIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblPurchasesIcon.AutoSize = true;
            this.lblPurchasesIcon.Location = new System.Drawing.Point(12, 8);

            this.lblPurchasesValue.Text = "—";
            this.lblPurchasesValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblPurchasesValue.ForeColor = darkRed;
            this.lblPurchasesValue.AutoSize = true;
            this.lblPurchasesValue.Location = new System.Drawing.Point(12, 32);

            this.lblPurchasesTitle.Text = "Purchases This Month";
            this.lblPurchasesTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblPurchasesTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblPurchasesTitle.AutoSize = true;
            this.lblPurchasesTitle.Location = new System.Drawing.Point(12, 72);

            this.pnlCard2.Controls.Add(this.lblPurchasesIcon);
            this.pnlCard2.Controls.Add(this.lblPurchasesValue);
            this.pnlCard2.Controls.Add(this.lblPurchasesTitle);

            // Card 3  (Revenue)
            this.pnlCard3.Size = new System.Drawing.Size(218, 100);
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);

            this.lblRevenueIcon.Text = "💰";
            this.lblRevenueIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblRevenueIcon.AutoSize = true;
            this.lblRevenueIcon.Location = new System.Drawing.Point(12, 8);

            this.lblRevenueValue.Text = "—";
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblRevenueValue.ForeColor = darkRed;
            this.lblRevenueValue.AutoSize = true;
            this.lblRevenueValue.Location = new System.Drawing.Point(12, 36);

            this.lblRevenueTitle.Text = "Revenue This Month";
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Location = new System.Drawing.Point(12, 72);

            this.pnlCard3.Controls.Add(this.lblRevenueIcon);
            this.pnlCard3.Controls.Add(this.lblRevenueValue);
            this.pnlCard3.Controls.Add(this.lblRevenueTitle);

            // Card 4  (Stock)
            this.pnlCard4.Size = new System.Drawing.Size(218, 100);
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);

            this.lblStockIcon.Text = "🚗";
            this.lblStockIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblStockIcon.AutoSize = true;
            this.lblStockIcon.Location = new System.Drawing.Point(12, 8);

            this.lblStockValue.Text = "—";
            this.lblStockValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblStockValue.ForeColor = darkRed;
            this.lblStockValue.AutoSize = true;
            this.lblStockValue.Location = new System.Drawing.Point(12, 32);

            this.lblStockTitle.Text = "Vehicles In Stock";
            this.lblStockTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblStockTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStockTitle.AutoSize = true;
            this.lblStockTitle.Location = new System.Drawing.Point(12, 72);

            this.pnlCard4.Controls.Add(this.lblStockIcon);
            this.pnlCard4.Controls.Add(this.lblStockValue);
            this.pnlCard4.Controls.Add(this.lblStockTitle);

            this.flowCards.Controls.Add(this.pnlCard1);
            this.flowCards.Controls.Add(this.pnlCard2);
            this.flowCards.Controls.Add(this.pnlCard3);
            this.flowCards.Controls.Add(this.pnlCard4);

            // ── NAV SECTION ───────────────────────────────────────
            this.pnlNavSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavSection.BackColor = bg;
            this.pnlNavSection.Padding = new System.Windows.Forms.Padding(16, 20, 16, 16);

            this.lblNavTitle.Text = "Generate Reports";
            this.lblNavTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblNavTitle.AutoSize = true;
            this.lblNavTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNavTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);

            this.flowNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNav.BackColor = bg;
            this.flowNav.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowNav.WrapContents = true;
            this.flowNav.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);

            // Nav button style
            System.Action<System.Windows.Forms.Button, string> styleNavBtn = (btn, txt) => {
                btn.Text = txt;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = darkRed;
                btn.ForeColor = System.Drawing.Color.White;
                btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                btn.Size = new System.Drawing.Size(210, 56);
                btn.Margin = new System.Windows.Forms.Padding(0, 0, 14, 14);
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            };

            styleNavBtn(this.btnSalesReport, "📊   Sales Report");
            styleNavBtn(this.btnPurchaseReport, "📋   Purchase Report");
            styleNavBtn(this.btnInventoryReport, "🚘   Inventory Report");
            styleNavBtn(this.btnProfitLoss, "📈   Profit && Loss");

            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            this.btnPurchaseReport.Click += new System.EventHandler(this.btnPurchaseReport_Click);
            this.btnInventoryReport.Click += new System.EventHandler(this.btnInventoryReport_Click);
            this.btnProfitLoss.Click += new System.EventHandler(this.btnProfitLoss_Click);

            this.flowNav.Controls.Add(this.btnSalesReport);
            this.flowNav.Controls.Add(this.btnPurchaseReport);
            this.flowNav.Controls.Add(this.btnInventoryReport);
            this.flowNav.Controls.Add(this.btnProfitLoss);

            this.pnlNavSection.Controls.Add(this.flowNav);
            this.pnlNavSection.Controls.Add(this.lblNavTitle);

            // ── ADD TO FORM ───────────────────────────────────────
            this.Controls.Add(this.pnlNavSection);
            this.Controls.Add(this.flowCards);
            this.Controls.Add(this.pnlHeader);
        }
    }
}