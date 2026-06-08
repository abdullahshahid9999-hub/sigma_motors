namespace SIGMA_MOTORS
{
    partial class PurchaseForm
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
            // Panels
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();

            // Stat cards
            this.cardTotal = new System.Windows.Forms.Panel();
            this.lblStatTotal = new System.Windows.Forms.Label();
            this.cardPending = new System.Windows.Forms.Panel();
            this.lblStatPending = new System.Windows.Forms.Label();
            this.cardCompleted = new System.Windows.Forms.Panel();
            this.lblStatCompleted = new System.Windows.Forms.Label();
            this.cardAmount = new System.Windows.Forms.Panel();
            this.lblStatAmount = new System.Windows.Forms.Label();
            this.cardDue = new System.Windows.Forms.Panel();
            this.lblStatDue = new System.Windows.Forms.Label();

            // Toolbar
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblStatusFil = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAddPurchase = new System.Windows.Forms.Button();
            this.btnEditStatus = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            // Grid
            this.dgvPurchase = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════════════════════════════════
            this.Text = "Purchase Orders — Sigma Motors";
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.PurchaseForm_Load);

            // ════════════════════════════════════════════════════════════════════
            //  HEADER
            // ════════════════════════════════════════════════════════════════════
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(1100, 50);

            this.lblTitle.Text = "Purchase Orders";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.pnlHeader.Controls.Add(this.lblTitle);

            // ════════════════════════════════════════════════════════════════════
            //  STATS PANEL
            // ════════════════════════════════════════════════════════════════════
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlStats.Location = new System.Drawing.Point(0, 50);
            this.pnlStats.Size = new System.Drawing.Size(1100, 90);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;

            // Card definitions: text, bg, fg, x
            BuildCard(cardTotal, lblStatTotal, "Total Orders\n—",
                System.Drawing.Color.FromArgb(139, 0, 0), System.Drawing.Color.White, 16);
            BuildCard(cardPending, lblStatPending, "Pending\n—",
                System.Drawing.Color.FromArgb(255, 193, 7), System.Drawing.Color.FromArgb(80, 60, 0), 230);
            BuildCard(cardCompleted, lblStatCompleted, "Completed\n—",
                System.Drawing.Color.FromArgb(40, 167, 69), System.Drawing.Color.White, 444);
            BuildCard(cardAmount, lblStatAmount, "Total Value\n—",
                System.Drawing.Color.FromArgb(0, 123, 255), System.Drawing.Color.White, 658);
            BuildCard(cardDue, lblStatDue, "Payment Due\n—",
                System.Drawing.Color.FromArgb(220, 53, 69), System.Drawing.Color.White, 872);

            this.pnlStats.Controls.AddRange(new System.Windows.Forms.Control[]
                { cardTotal, cardPending, cardCompleted, cardAmount, cardDue });

            // ════════════════════════════════════════════════════════════════════
            //  TOOLBAR
            // ════════════════════════════════════════════════════════════════════
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 140);
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 56);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;

            this.lblSearch.Text = "Search:";
            this.lblSearch.Location = new System.Drawing.Point(16, 18);
            this.lblSearch.Size = new System.Drawing.Size(50, 20);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtSearch.Location = new System.Drawing.Point(68, 15);
            this.txtSearch.Size = new System.Drawing.Size(210, 24);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.lblStatusFil.Text = "Status:";
            this.lblStatusFil.Location = new System.Drawing.Point(292, 18);
            this.lblStatusFil.Size = new System.Drawing.Size(48, 20);
            this.lblStatusFil.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.cmbStatus.Location = new System.Drawing.Point(342, 15);
            this.cmbStatus.Size = new System.Drawing.Size(130, 24);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);

            // Buttons
            MakeBtn(btnAddPurchase, "+ New Purchase", System.Drawing.Color.FromArgb(139, 0, 0), 488, 13, 140, 32);
            MakeBtn(btnEditStatus, "✎ Update Status", System.Drawing.Color.FromArgb(0, 102, 204), 636, 13, 130, 32);
            MakeBtn(btnExport, "⬇ Export", System.Drawing.Color.FromArgb(100, 100, 100), 774, 13, 110, 32);
            MakeBtn(btnRefresh, "↺ Refresh", System.Drawing.Color.FromArgb(60, 60, 60), 892, 13, 100, 32);

            btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            btnEditStatus.Click += new System.EventHandler(this.btnEditStatus_Click);
            btnExport.Click += new System.EventHandler(this.btnExport_Click);
            btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.pnlToolbar.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblSearch, txtSearch, lblStatusFil, cmbStatus,
                btnAddPurchase, btnEditStatus, btnExport, btnRefresh
            });

            // ════════════════════════════════════════════════════════════════════
            //  DATAGRIDVIEW
            // ════════════════════════════════════════════════════════════════════
            this.dgvPurchase.Location = new System.Drawing.Point(0, 196);
            this.dgvPurchase.Size = new System.Drawing.Size(1100, 456);
            this.dgvPurchase.Anchor = System.Windows.Forms.AnchorStyles.Top
                                       | System.Windows.Forms.AnchorStyles.Left
                                       | System.Windows.Forms.AnchorStyles.Right
                                       | System.Windows.Forms.AnchorStyles.Bottom;

            this.dgvPurchase.AllowUserToAddRows = false;
            this.dgvPurchase.AllowUserToDeleteRows = false;
            this.dgvPurchase.ReadOnly = true;
            this.dgvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchase.MultiSelect = false;
            this.dgvPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchase.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchase.RowHeadersVisible = false;
            this.dgvPurchase.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.dgvPurchase.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.dgvPurchase.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPurchase.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvPurchase.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.dgvPurchase.ColumnHeadersHeight = 32;
            this.dgvPurchase.EnableHeadersVisualStyles = false;

            this.dgvPurchase.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 252);
            this.dgvPurchase.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPurchase.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 248, 248);
            this.dgvPurchase.RowTemplate.Height = 28;
            this.dgvPurchase.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);

            this.dgvPurchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellContentClick);
            this.dgvPurchase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellDoubleClick);

            // ════════════════════════════════════════════════════════════════════
            //  ADD ALL
            // ════════════════════════════════════════════════════════════════════
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                pnlHeader, pnlStats, pnlToolbar, dgvPurchase
            });

            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Stat Card Builder ────────────────────────────────────────────────────
        private void BuildCard(System.Windows.Forms.Panel card, System.Windows.Forms.Label lbl,
            string text, System.Drawing.Color bg, System.Drawing.Color fg, int x)
        {
            card.BackColor = bg;
            card.Location = new System.Drawing.Point(x, 10);
            card.Size = new System.Drawing.Size(200, 68);
            card.Cursor = System.Windows.Forms.Cursors.Default;

            // Rounded feel via padding
            lbl.Text = text;
            lbl.ForeColor = fg;
            lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            card.Controls.Add(lbl);
        }

        // ── Button Builder ───────────────────────────────────────────────────────
        private void MakeBtn(System.Windows.Forms.Button btn, string text,
            System.Drawing.Color color, int x, int y, int w, int h)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(w, h);
            btn.BackColor = color;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        // Declarations
        private System.Windows.Forms.Panel pnlHeader, pnlStats, pnlToolbar, pnlFooter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel cardTotal, cardPending, cardCompleted, cardAmount, cardDue;
        private System.Windows.Forms.Label lblStatTotal, lblStatPending, lblStatCompleted, lblStatAmount, lblStatDue;
        private System.Windows.Forms.Label lblSearch, lblStatusFil;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddPurchase, btnEditStatus, btnExport, btnRefresh;
        private System.Windows.Forms.DataGridView dgvPurchase;
    }
}