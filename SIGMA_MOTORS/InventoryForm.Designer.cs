namespace SIGMA_MOTORS
{
    partial class InventoryForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════════════════════════════════
            this.Text = "Vehicle Inventory — Sigma Motors";
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.InventoryForm_Load);

            // ════════════════════════════════════════════════════════════════════
            //  HEADER
            // ════════════════════════════════════════════════════════════════════
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1100, 50);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;

            this.lblTitle.Text = "Vehicle Inventory";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 10);
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.pnlHeader.Controls.Add(this.lblTitle);

            // ════════════════════════════════════════════════════════════════════
            //  TOOLBAR PANEL
            // ════════════════════════════════════════════════════════════════════
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlToolbar.Location = new System.Drawing.Point(0, 50);
            this.pnlToolbar.Size = new System.Drawing.Size(1100, 60);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;

            // ── Search ───────────────────────────────────────────────────────────
            this.lblSearch.Text = "Search:";
            this.lblSearch.Location = new System.Drawing.Point(16, 20);
            this.lblSearch.Size = new System.Drawing.Size(50, 20);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtSearch.Location = new System.Drawing.Point(68, 17);
            this.txtSearch.Size = new System.Drawing.Size(220, 24);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // ── Status Filter ────────────────────────────────────────────────────
            this.lblStatus.Text = "Status:";
            this.lblStatus.Location = new System.Drawing.Point(306, 20);
            this.lblStatus.Size = new System.Drawing.Size(48, 20);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.cmbStatus.Location = new System.Drawing.Point(356, 17);
            this.cmbStatus.Size = new System.Drawing.Size(130, 24);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);

            // ── Buttons right side ────────────────────────────────────────────────
            MakeBtn(this.btnAddVehicle, "+ Add Vehicle", System.Drawing.Color.FromArgb(34, 139, 34), 502, 14, 120, 32);
            MakeBtn(this.btnEdit, "✎ Edit", System.Drawing.Color.FromArgb(0, 102, 204), 630, 14, 100, 32);
            MakeBtn(this.btnDelete, "✕ Delete", System.Drawing.Color.FromArgb(180, 0, 0), 738, 14, 100, 32);
            MakeBtn(this.btnExport, "⬇ Export", System.Drawing.Color.FromArgb(100, 100, 100), 846, 14, 110, 32);
            MakeBtn(this.btnRefresh, "↺ Refresh", System.Drawing.Color.FromArgb(60, 60, 60), 964, 14, 100, 32);

            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.pnlToolbar.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblSearch, txtSearch, lblStatus, cmbStatus,
                btnAddVehicle, btnEdit, btnDelete, btnExport, btnRefresh
            });

            // ════════════════════════════════════════════════════════════════════
            //  DATAGRIDVIEW
            // ════════════════════════════════════════════════════════════════════
            this.dgvInventory.Location = new System.Drawing.Point(0, 110);
            this.dgvInventory.Size = new System.Drawing.Size(1100, 475);
            this.dgvInventory.Anchor = System.Windows.Forms.AnchorStyles.Top
                                                    | System.Windows.Forms.AnchorStyles.Left
                                                    | System.Windows.Forms.AnchorStyles.Right
                                                    | System.Windows.Forms.AnchorStyles.Bottom;

            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.Font = new System.Drawing.Font("Segoe UI", 9F);

            // Column header style
            this.dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInventory.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvInventory.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.dgvInventory.ColumnHeadersHeight = 32;
            this.dgvInventory.EnableHeadersVisualStyles = false;

            // Row style
            this.dgvInventory.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 252);
            this.dgvInventory.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 248, 248);
            this.dgvInventory.RowTemplate.Height = 28;
            this.dgvInventory.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);

            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            this.dgvInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellDoubleClick);

            // ════════════════════════════════════════════════════════════════════
            //  FOOTER
            // ════════════════════════════════════════════════════════════════════
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Size = new System.Drawing.Size(1100, 28);

            this.lblSummary.Text = "Loading...";
            this.lblSummary.Location = new System.Drawing.Point(16, 6);
            this.lblSummary.Size = new System.Drawing.Size(600, 18);
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.pnlFooter.Controls.Add(this.lblSummary);

            // ════════════════════════════════════════════════════════════════════
            //  ADD TO FORM
            // ════════════════════════════════════════════════════════════════════
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                pnlHeader,
                pnlToolbar,
                dgvInventory,
                pnlFooter
            });

            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Button factory ───────────────────────────────────────────────────────
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
        private System.Windows.Forms.Panel pnlHeader, pnlToolbar, pnlFooter;
        private System.Windows.Forms.Label lblTitle, lblSearch, lblStatus, lblSummary;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddVehicle, btnEdit, btnDelete, btnExport, btnRefresh;
        private System.Windows.Forms.DataGridView dgvInventory;
    }
}