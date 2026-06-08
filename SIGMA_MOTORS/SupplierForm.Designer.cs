namespace SIGMA_MOTORS
{
    partial class SupplierForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel pnlCardActive;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Label lblActiveValue;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvSuppliers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var DR = System.Drawing.Color.FromArgb(139, 0, 0);   // dark red
            var BG = System.Drawing.Color.FromArgb(245, 245, 245);
            var WHT = System.Drawing.Color.White;
            var GRY = System.Drawing.Color.Gray;
            var SF = new System.Drawing.Font("Segoe UI", 9F);
            var SFB = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlCardTotal = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.pnlCardActive = new System.Windows.Forms.Panel();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.lblActiveValue = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();

            this.SuspendLayout();

            // ── FORM ─────────────────────────────────────────────────────────
            this.Text = "Suppliers";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = BG;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = SF;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Load += new System.EventHandler(this.SupplierForm_Load);

            // ── HEADER ───────────────────────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 55;
            this.pnlHeader.BackColor = DR;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);

            this.lblTitle.Text = "Suppliers";
            this.lblTitle.ForeColor = WHT;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlHeader.Controls.Add(this.lblTitle);

            // ── STATS ─────────────────────────────────────────────────────────
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Height = 90;
            this.pnlStats.BackColor = BG;
            this.pnlStats.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);

            // Card: Total
            this.pnlCardTotal.Size = new System.Drawing.Size(160, 68);
            this.pnlCardTotal.Location = new System.Drawing.Point(0, 8);
            this.pnlCardTotal.BackColor = WHT;
            this.pnlCardTotal.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.lblTotalTitle.Text = "Total Suppliers";
            this.lblTotalTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalTitle.Height = 22;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalTitle.ForeColor = GRY;
            this.lblTotalValue.Text = "...";
            this.lblTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = DR;
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCardTotal.Controls.Add(this.lblTotalValue);
            this.pnlCardTotal.Controls.Add(this.lblTotalTitle);

            // Card: Active
            this.pnlCardActive.Size = new System.Drawing.Size(160, 68);
            this.pnlCardActive.Location = new System.Drawing.Point(180, 8);
            this.pnlCardActive.BackColor = WHT;
            this.pnlCardActive.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.lblActiveTitle.Text = "Active Suppliers";
            this.lblActiveTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActiveTitle.Height = 22;
            this.lblActiveTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblActiveTitle.ForeColor = GRY;
            this.lblActiveValue.Text = "...";
            this.lblActiveValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblActiveValue.ForeColor = DR;
            this.lblActiveValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnlCardActive.Controls.Add(this.lblActiveValue);
            this.pnlCardActive.Controls.Add(this.lblActiveTitle);

            this.pnlStats.Controls.Add(this.pnlCardTotal);
            this.pnlStats.Controls.Add(this.pnlCardActive);

            // ── TOOLBAR ───────────────────────────────────────────────────────
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Height = 50;
            this.pnlToolbar.BackColor = WHT;

            // Search box
            this.txtSearch.Text = "Search by Company, Phone, NTN...";
            this.txtSearch.ForeColor = GRY;
            this.txtSearch.Width = 270;
            this.txtSearch.Height = 30;
            this.txtSearch.Location = new System.Drawing.Point(15, 10);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = SF;
            this.txtSearch.GotFocus += (s, e) => {
                if (this.txtSearch.ForeColor == GRY)
                { this.txtSearch.Text = ""; this.txtSearch.ForeColor = System.Drawing.Color.Black; }
            };
            this.txtSearch.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(this.txtSearch.Text))
                { this.txtSearch.Text = "Search by Company, Phone, NTN..."; this.txtSearch.ForeColor = GRY; }
            };
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // Helper to set button props inline
            int bx = 295;
            this.btnRefresh.Text = "Refresh"; this.btnRefresh.Location = new System.Drawing.Point(bx, 10); bx += 90;
            this.btnAdd.Text = "+ Add Supplier"; this.btnAdd.Location = new System.Drawing.Point(bx, 10); bx += 130;
            this.btnEdit.Text = "Edit"; this.btnEdit.Location = new System.Drawing.Point(bx, 10); bx += 75;
            this.btnDelete.Text = "Delete"; this.btnDelete.Location = new System.Drawing.Point(bx, 10); bx += 85;
            this.btnExport.Text = "Export CSV"; this.btnExport.Location = new System.Drawing.Point(bx, 10);

            foreach (var btn in new System.Windows.Forms.Button[]
                     { this.btnRefresh, this.btnAdd, this.btnEdit, this.btnDelete, this.btnExport })
            {
                btn.Height = 30;
                btn.AutoSize = true;
                btn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.ForeColor = WHT;
                btn.Font = SFB;
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            this.btnRefresh.BackColor = DR;
            this.btnAdd.BackColor = DR;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(180, 0, 0);
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);

            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            this.pnlToolbar.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.txtSearch, this.btnRefresh, this.btnAdd,
                this.btnEdit, this.btnDelete, this.btnExport
            });

            // ── DATAGRIDVIEW ──────────────────────────────────────────────────
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.BackgroundColor = BG;
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuppliers.ColumnHeadersHeight = 36;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuppliers.RowTemplate.Height = 30;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.EnableHeadersVisualStyles = false;

            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = DR;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = WHT;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = SFB;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.SelectionBackColor = DR;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);

            this.dgvSuppliers.DefaultCellStyle.BackColor = WHT;
            this.dgvSuppliers.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.dgvSuppliers.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(200, 60, 60);
            this.dgvSuppliers.DefaultCellStyle.SelectionForeColor = WHT;
            this.dgvSuppliers.DefaultCellStyle.Font = SF;
            this.dgvSuppliers.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dgvSuppliers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(252, 240, 240);

            this.dgvSuppliers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellDoubleClick);

            // ── ASSEMBLE (Fill first, Dock=Top last) ─────────────────────────
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlHeader);

            this.ResumeLayout(false);
        }
    }
}