namespace SIGMA_MOTORS
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        // Stats
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel pnlCardNew;
        private System.Windows.Forms.Label lblNewTitle;
        private System.Windows.Forms.Label lblNewValue;

        // Toolbar
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;

        // Grid
        private System.Windows.Forms.DataGridView dgvCustomers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var darkRed = System.Drawing.Color.FromArgb(139, 0, 0);
            var bg = System.Drawing.Color.FromArgb(245, 245, 245);
            var segoeUI = new System.Drawing.Font("Segoe UI", 9F);

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlCardTotal = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.pnlCardNew = new System.Windows.Forms.Panel();
            this.lblNewTitle = new System.Windows.Forms.Label();
            this.lblNewValue = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();

            this.SuspendLayout();

            // ── Form ──────────────────────────────────────────────────────────
            this.Text = "Customers";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = bg;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = segoeUI;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Load += new System.EventHandler(this.CustomerForm_Load);

            // ── Header ────────────────────────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 55;
            this.pnlHeader.BackColor = darkRed;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);

            this.lblTitle.Text = "Customers";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlHeader.Controls.Add(this.lblTitle);

            // ── Stats ─────────────────────────────────────────────────────────
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Height = 90;
            this.pnlStats.BackColor = bg;
            this.pnlStats.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);

            BuildStatCard(this.pnlCardTotal, this.lblTotalTitle, this.lblTotalValue, "Total Customers", 0);
            BuildStatCard(this.pnlCardNew, this.lblNewTitle, this.lblNewValue, "New This Month", 180);

            this.pnlStats.Controls.Add(this.pnlCardTotal);
            this.pnlStats.Controls.Add(this.pnlCardNew);

            // ── Toolbar ───────────────────────────────────────────────────────
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Height = 50;
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);

            this.txtSearch.Width = 260;
            this.txtSearch.Height = 30;
            this.txtSearch.Location = new System.Drawing.Point(15, 10);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = segoeUI;
            this.txtSearch.Text = "Search by Name, CNIC, Phone...";
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.GotFocus += (s, e2) => {
                if (this.txtSearch.ForeColor == System.Drawing.Color.Gray)
                { this.txtSearch.Text = ""; this.txtSearch.ForeColor = System.Drawing.Color.Black; }
            };
            this.txtSearch.LostFocus += (s, e2) => {
                if (string.IsNullOrWhiteSpace(this.txtSearch.Text))
                { this.txtSearch.Text = "Search by Name, CNIC, Phone..."; this.txtSearch.ForeColor = System.Drawing.Color.Gray; }
            };
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            int bx = 285;
            SetupButton(this.btnRefresh, "Refresh", bx, darkRed, System.Drawing.Color.White); bx += 100;
            SetupButton(this.btnAdd, "+ Add Customer", bx, darkRed, System.Drawing.Color.White); bx += 140;
            SetupButton(this.btnEdit, "Edit", bx, System.Drawing.Color.FromArgb(0, 120, 215), System.Drawing.Color.White); bx += 80;
            SetupButton(this.btnDelete, "Delete", bx, System.Drawing.Color.FromArgb(180, 0, 0), System.Drawing.Color.White); bx += 90;
            SetupButton(this.btnExport, "Export CSV", bx, System.Drawing.Color.FromArgb(40, 167, 69), System.Drawing.Color.White);

            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            this.pnlToolbar.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.txtSearch, this.btnRefresh, this.btnAdd,
                this.btnEdit, this.btnDelete, this.btnExport
            });

            // ── DataGridView ──────────────────────────────────────────────────
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.BackgroundColor = bg;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.ColumnHeadersHeight = 36;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomers.RowTemplate.Height = 30;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.EnableHeadersVisualStyles = false;

            this.dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = darkRed;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvCustomers.ColumnHeadersDefaultCellStyle.SelectionBackColor = darkRed;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);

            this.dgvCustomers.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.dgvCustomers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 60, 60);
            this.dgvCustomers.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCustomers.DefaultCellStyle.Font = segoeUI;
            this.dgvCustomers.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(252, 240, 240);

            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);

            // ── Assemble ──────────────────────────────────────────────────────
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlHeader);

            this.ResumeLayout(false);
        }

        private void BuildStatCard(System.Windows.Forms.Panel card,
                                   System.Windows.Forms.Label lblT,
                                   System.Windows.Forms.Label lblV,
                                   string title, int x)
        {
            card.Size = new System.Drawing.Size(160, 68);
            card.Location = new System.Drawing.Point(x, 8);
            card.BackColor = System.Drawing.Color.White;
            card.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);

            lblT.Text = title;
            lblT.Dock = System.Windows.Forms.DockStyle.Top;
            lblT.Height = 22;
            lblT.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblT.ForeColor = System.Drawing.Color.Gray;

            lblV.Text = "...";
            lblV.Dock = System.Windows.Forms.DockStyle.Fill;
            lblV.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblV.ForeColor = System.Drawing.Color.FromArgb(139, 0, 0);
            lblV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            card.Controls.Add(lblV);
            card.Controls.Add(lblT);
        }

        private void SetupButton(System.Windows.Forms.Button btn, string text, int x,
                                  System.Drawing.Color back, System.Drawing.Color fore)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(x, 9);
            btn.Height = 30;
            btn.AutoSize = true;
            btn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = back;
            btn.ForeColor = fore;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}