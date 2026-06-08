namespace SIGMA_MOTORS
{
    partial class InvoicesForm
    {
        private System.ComponentModel.IContainer components = null;

        // Stat card controls
        private System.Windows.Forms.Panel pnlStatTotalInvoices;
        private System.Windows.Forms.Label lblStatTitleTotal;
        private System.Windows.Forms.Label lblTotalInvoices;

        private System.Windows.Forms.Panel pnlStatThisMonth;
        private System.Windows.Forms.Label lblStatTitleMonth;
        private System.Windows.Forms.Label lblThisMonth;

        private System.Windows.Forms.Panel pnlStatRevenue;
        private System.Windows.Forms.Label lblStatTitleRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;

        // Toolbar
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewInvoice;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnRefresh;

        // Stats row
        private System.Windows.Forms.Panel pnlStats;

        // Grid
        private System.Windows.Forms.DataGridView dgvInvoices;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── Panels ──────────────────────────────────────────────
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.pnlStatTotalInvoices = new System.Windows.Forms.Panel();
            this.pnlStatThisMonth = new System.Windows.Forms.Panel();
            this.pnlStatRevenue = new System.Windows.Forms.Panel();

            // ── Labels ───────────────────────────────────────────────
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblStatTitleTotal = new System.Windows.Forms.Label();
            this.lblTotalInvoices = new System.Windows.Forms.Label();
            this.lblStatTitleMonth = new System.Windows.Forms.Label();
            this.lblThisMonth = new System.Windows.Forms.Label();
            this.lblStatTitleRevenue = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();

            // ── TextBox / Buttons ────────────────────────────────────
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewInvoice = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            // ── Grid ─────────────────────────────────────────────────
            this.dgvInvoices = new System.Windows.Forms.DataGridView();

            // ============================================================
            // FORM
            // ============================================================
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.Load += new System.EventHandler(this.InvoicesForm_Load);

            // ============================================================
            // pnlHeader
            // ============================================================
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 55;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);

            this.lblHeader.Text = "Invoices";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlHeader.Controls.Add(this.lblHeader);

            // ============================================================
            // pnlStats
            // ============================================================
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Height = 90;
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlStats.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);

            // Stat card: Total Invoices
            this.pnlStatTotalInvoices.Width = 180;
            this.pnlStatTotalInvoices.Height = 70;
            this.pnlStatTotalInvoices.Location = new System.Drawing.Point(20, 10);
            this.pnlStatTotalInvoices.BackColor = System.Drawing.Color.White;
            this.pnlStatTotalInvoices.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);

            this.lblStatTitleTotal.Text = "TOTAL INVOICES";
            this.lblStatTitleTotal.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Bold);
            this.lblStatTitleTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblStatTitleTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatTitleTotal.Height = 22;

            this.lblTotalInvoices.Text = "0";
            this.lblTotalInvoices.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblTotalInvoices.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.lblTotalInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlStatTotalInvoices.Controls.Add(this.lblTotalInvoices);
            this.pnlStatTotalInvoices.Controls.Add(this.lblStatTitleTotal);

            // Stat card: This Month
            this.pnlStatThisMonth.Width = 180;
            this.pnlStatThisMonth.Height = 70;
            this.pnlStatThisMonth.Location = new System.Drawing.Point(215, 10);
            this.pnlStatThisMonth.BackColor = System.Drawing.Color.White;
            this.pnlStatThisMonth.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);

            this.lblStatTitleMonth.Text = "THIS MONTH";
            this.lblStatTitleMonth.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Bold);
            this.lblStatTitleMonth.ForeColor = System.Drawing.Color.Gray;
            this.lblStatTitleMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatTitleMonth.Height = 22;

            this.lblThisMonth.Text = "0";
            this.lblThisMonth.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold);
            this.lblThisMonth.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.lblThisMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThisMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlStatThisMonth.Controls.Add(this.lblThisMonth);
            this.pnlStatThisMonth.Controls.Add(this.lblStatTitleMonth);

            // Stat card: Total Revenue
            this.pnlStatRevenue.Width = 220;
            this.pnlStatRevenue.Height = 70;
            this.pnlStatRevenue.Location = new System.Drawing.Point(410, 10);
            this.pnlStatRevenue.BackColor = System.Drawing.Color.White;
            this.pnlStatRevenue.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);

            this.lblStatTitleRevenue.Text = "TOTAL REVENUE (PAID)";
            this.lblStatTitleRevenue.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Bold);
            this.lblStatTitleRevenue.ForeColor = System.Drawing.Color.Gray;
            this.lblStatTitleRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatTitleRevenue.Height = 22;

            this.lblTotalRevenue.Text = "Rs 0";
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.lblTotalRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pnlStatRevenue.Controls.Add(this.lblTotalRevenue);
            this.pnlStatRevenue.Controls.Add(this.lblStatTitleRevenue);

            this.pnlStats.Controls.Add(this.pnlStatTotalInvoices);
            this.pnlStats.Controls.Add(this.pnlStatThisMonth);
            this.pnlStats.Controls.Add(this.pnlStatRevenue);

            // ============================================================
            // pnlToolbar
            // ============================================================
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Height = 50;
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);

            this.txtSearch.Width = 280;
            this.txtSearch.Height = 32;
            this.txtSearch.Location = new System.Drawing.Point(15, 9);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Text = "Search by Customer or Invoice ID...";
            this.txtSearch.GotFocus += new System.EventHandler(this.txtSearch_GotFocus);
            this.txtSearch.LostFocus += new System.EventHandler(this.txtSearch_LostFocus);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);

            this.btnSearch.Text = "Search";
            this.btnSearch.Width = 80;
            this.btnSearch.Height = 32;
            this.btnSearch.Location = new System.Drawing.Point(305, 9);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnViewInvoice.Text = "View Invoice";
            this.btnViewInvoice.Width = 110;
            this.btnViewInvoice.Height = 32;
            this.btnViewInvoice.Location = new System.Drawing.Point(405, 9);
            this.btnViewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInvoice.FlatAppearance.BorderSize = 0;
            this.btnViewInvoice.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnViewInvoice.ForeColor = System.Drawing.Color.White;
            this.btnViewInvoice.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnViewInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);

            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.Width = 100;
            this.btnExportCSV.Height = 32;
            this.btnExportCSV.Location = new System.Drawing.Point(525, 9);
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnExportCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportCSV.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.btnExportCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);

            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Width = 80;
            this.btnRefresh.Height = 32;
            this.btnRefresh.Location = new System.Drawing.Point(635, 9);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.btnSearch);
            this.pnlToolbar.Controls.Add(this.btnViewInvoice);
            this.pnlToolbar.Controls.Add(this.btnExportCSV);
            this.pnlToolbar.Controls.Add(this.btnRefresh);

            // ============================================================
            // dgvInvoices
            // ============================================================
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.dgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvInvoices.RowHeadersVisible = false;
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.RowTemplate.Height = 36;
            this.dgvInvoices.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.dgvInvoices.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellDoubleClick);
            this.dgvInvoices.DataError += (s, e) => e.Cancel = true;

            // ============================================================
            // ADD TO FORM
            // ============================================================
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlHeader);
        }
    }
}