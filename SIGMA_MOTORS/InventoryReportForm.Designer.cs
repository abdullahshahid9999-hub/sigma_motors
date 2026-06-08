namespace SIGMA_MOTORS
{
    partial class InventoryReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.TableLayoutPanel tlpFilters;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.DataGridView dgvInventory;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblStats;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpFilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblStats = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.tlpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1044, 50);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1028, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventory Report";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpFilters
            // 
            this.tlpFilters.BackColor = System.Drawing.Color.White;
            this.tlpFilters.ColumnCount = 9;
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilters.Controls.Add(this.lblBrand, 0, 0);
            this.tlpFilters.Controls.Add(this.cmbBrand, 1, 0);
            this.tlpFilters.Controls.Add(this.lblStatus, 2, 0);
            this.tlpFilters.Controls.Add(this.cmbStatus, 3, 0);
            this.tlpFilters.Controls.Add(this.lblYear, 4, 0);
            this.tlpFilters.Controls.Add(this.cmbYear, 5, 0);
            this.tlpFilters.Controls.Add(this.btnGenerate, 6, 0);
            this.tlpFilters.Controls.Add(this.btnExportCSV, 7, 0);
            this.tlpFilters.Controls.Add(this.btnClose, 8, 0);
            this.tlpFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpFilters.Location = new System.Drawing.Point(0, 50);
            this.tlpFilters.Name = "tlpFilters";
            this.tlpFilters.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.tlpFilters.RowCount = 1;
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilters.Size = new System.Drawing.Size(1044, 50);
            this.tlpFilters.TabIndex = 2;
            // 
            // lblBrand
            // 
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblBrand.Location = new System.Drawing.Point(13, 8);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblBrand.Size = new System.Drawing.Size(100, 34);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Brand:";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBrand
            // 
            this.cmbBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.Location = new System.Drawing.Point(119, 11);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(124, 23);
            this.cmbBrand.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblStatus.Location = new System.Drawing.Point(249, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblStatus.Size = new System.Drawing.Size(100, 34);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "  Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(355, 11);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(104, 23);
            this.cmbStatus.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblYear.Location = new System.Drawing.Point(465, 8);
            this.lblYear.Name = "lblYear";
            this.lblYear.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblYear.Size = new System.Drawing.Size(100, 34);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "  Year:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbYear
            // 
            this.cmbYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Location = new System.Drawing.Point(571, 11);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(84, 23);
            this.cmbYear.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(664, 8);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(90, 34);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.BackColor = System.Drawing.Color.White;
            this.btnExportCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportCSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExportCSV.Location = new System.Drawing.Point(758, 8);
            this.btnExportCSV.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(92, 34);
            this.btnExportCSV.TabIndex = 7;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = false;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.Location = new System.Drawing.Point(954, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "✕ Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvInventory.Location = new System.Drawing.Point(0, 100);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowTemplate.Height = 26;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(1044, 487);
            this.dgvInventory.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.lblStats);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 587);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1044, 34);
            this.pnlFooter.TabIndex = 1;
            // 
            // lblStats
            // 
            this.lblStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStats.Location = new System.Drawing.Point(0, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblStats.Size = new System.Drawing.Size(1044, 34);
            this.lblStats.TabIndex = 0;
            this.lblStats.Text = "Total: 0     |     Available: 0     |     Sold: 0";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InventoryReportForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1044, 621);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.tlpFilters);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(860, 480);
            this.Name = "InventoryReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory Report";
            this.Load += new System.EventHandler(this.InventoryReportForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.tlpFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}