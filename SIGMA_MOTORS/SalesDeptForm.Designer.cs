namespace SIGMA_MOTORS
{
    partial class SalesDeptForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.lblRecentSales = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnAddSales);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 80);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sales Department";
            // 
            // btnAddSales
            // 
            this.btnAddSales.BackColor = System.Drawing.Color.Maroon;
            this.btnAddSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddSales.ForeColor = System.Drawing.Color.White;
            this.btnAddSales.Location = new System.Drawing.Point(780, 20);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(140, 40);
            this.btnAddSales.TabIndex = 1;
            this.btnAddSales.Text = "+ Add Sales";
            this.btnAddSales.UseVisualStyleBackColor = false;
            this.btnAddSales.Click += new System.EventHandler(this.btnAddSales_Click);
            // 
            // lblRecentSales
            // 
            this.lblRecentSales.AutoSize = true;
            this.lblRecentSales.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblRecentSales.ForeColor = System.Drawing.Color.Maroon;
            this.lblRecentSales.Location = new System.Drawing.Point(20, 100);
            this.lblRecentSales.Name = "lblRecentSales";
            this.lblRecentSales.Size = new System.Drawing.Size(118, 25);
            this.lblRecentSales.TabIndex = 1;
            this.lblRecentSales.Text = "Recent Sales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SalesDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblRecentSales);
            this.Controls.Add(this.pnlHeader);
            this.Name = "SalesDeptForm";
            this.Text = "Sigma Motors - Sales";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.Label lblRecentSales;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}