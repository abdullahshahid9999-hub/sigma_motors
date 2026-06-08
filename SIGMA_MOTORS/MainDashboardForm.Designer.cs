namespace SIGMA_MOTORS
{
    partial class MainDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelCars = new System.Windows.Forms.Panel();
            this.lblTotalCars = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSales = new System.Windows.Forms.Panel();
            this.lblSales = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRevenue = new System.Windows.Forms.Panel();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelExpenses = new System.Windows.Forms.Panel();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRecentSales = new System.Windows.Forms.DataGridView();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.panelLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockTitle = new System.Windows.Forms.Label();

            this.panelCars.SuspendLayout();
            this.panelSales.SuspendLayout();
            this.panelRevenue.SuspendLayout();
            this.panelExpenses.SuspendLayout();
            this.panelLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentSales)).BeginInit();
            this.SuspendLayout();

            // lblTime
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTime.Location = new System.Drawing.Point(20, 20);
            this.lblTime.Text = "00:00:00";

            // Total Cars Card
            this.panelCars.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelCars.Controls.Add(this.lblTotalCars);
            this.panelCars.Controls.Add(this.label1);
            this.panelCars.Location = new System.Drawing.Point(25, 80);
            this.panelCars.Size = new System.Drawing.Size(200, 100);
            this.label1.Text = "TOTAL CARS";
            this.label1.ForeColor = System.Drawing.Color.White;
            this.lblTotalCars.Text = "0";
            this.lblTotalCars.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalCars.ForeColor = System.Drawing.Color.White;
            this.lblTotalCars.Location = new System.Drawing.Point(10, 40);
            this.lblTotalCars.AutoSize = true;

            // Monthly Sales Card
            this.panelSales.BackColor = System.Drawing.Color.SeaGreen;
            this.panelSales.Controls.Add(this.lblSales);
            this.panelSales.Controls.Add(this.label2);
            this.panelSales.Location = new System.Drawing.Point(250, 80);
            this.panelSales.Size = new System.Drawing.Size(200, 100);
            this.label2.Text = "MONTHLY SALES";
            this.label2.ForeColor = System.Drawing.Color.White;
            this.lblSales.Text = "0";
            this.lblSales.ForeColor = System.Drawing.Color.White;
            this.lblSales.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSales.Location = new System.Drawing.Point(10, 40);
            this.lblSales.AutoSize = true;

            // Revenue Card
            this.panelRevenue.BackColor = System.Drawing.Color.Orange;
            this.panelRevenue.Controls.Add(this.lblRevenue);
            this.panelRevenue.Controls.Add(this.label3);
            this.panelRevenue.Location = new System.Drawing.Point(475, 80);
            this.panelRevenue.Size = new System.Drawing.Size(220, 100);
            this.label3.Text = "TOTAL REVENUE";
            this.label3.ForeColor = System.Drawing.Color.White;
            this.lblRevenue.Text = "Rs. 0";
            this.lblRevenue.ForeColor = System.Drawing.Color.White;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.Location = new System.Drawing.Point(10, 40);
            this.lblRevenue.AutoSize = true;

            // Expenses Card
            this.panelExpenses.BackColor = System.Drawing.Color.Crimson;
            this.panelExpenses.Controls.Add(this.lblExpenses);
            this.panelExpenses.Controls.Add(this.label4);
            this.panelExpenses.Location = new System.Drawing.Point(720, 80);
            this.panelExpenses.Size = new System.Drawing.Size(200, 100);
            this.label4.Text = "MONTHLY EXPENSES";
            this.label4.ForeColor = System.Drawing.Color.White;
            this.lblExpenses.Text = "Rs. 0";
            this.lblExpenses.ForeColor = System.Drawing.Color.White;
            this.lblExpenses.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblExpenses.Location = new System.Drawing.Point(10, 40);
            this.lblExpenses.AutoSize = true;

            // Recent Sales Table
            this.lblRecentTitle.Text = "RECENT SALES TRANSACTIONS";
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.Location = new System.Drawing.Point(25, 210);
            this.lblRecentTitle.AutoSize = true;
            this.dgvRecentSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentSales.Location = new System.Drawing.Point(25, 240);
            this.dgvRecentSales.Size = new System.Drawing.Size(600, 320);
            this.dgvRecentSales.ReadOnly = true;
            this.dgvRecentSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // Low Stock Panel
            this.panelLowStock.BackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.panelLowStock.Location = new System.Drawing.Point(650, 240);
            this.panelLowStock.Size = new System.Drawing.Size(270, 320);
            this.lblLowStockTitle.Text = "SYSTEM ALERTS";
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLowStockTitle.Location = new System.Drawing.Point(10, 10);
            this.panelLowStock.Controls.Add(this.lblLowStockTitle);

            // Form
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelLowStock);
            this.Controls.Add(this.dgvRecentSales);
            this.Controls.Add(this.lblRecentTitle);
            this.Controls.Add(this.panelExpenses);
            this.Controls.Add(this.panelRevenue);
            this.Controls.Add(this.panelSales);
            this.Controls.Add(this.panelCars);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;

            this.panelCars.ResumeLayout(false);
            this.panelSales.ResumeLayout(false);
            this.panelRevenue.ResumeLayout(false);
            this.panelExpenses.ResumeLayout(false);
            this.panelLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTime, lblTotalCars, lblSales, lblRevenue, lblExpenses;
        private System.Windows.Forms.Label label1, label2, label3, label4, lblRecentTitle, lblLowStockTitle;
        private System.Windows.Forms.Panel panelCars, panelSales, panelRevenue, panelExpenses, panelLowStock;
        private System.Windows.Forms.DataGridView dgvRecentSales;
        private System.Windows.Forms.Timer timer1;
    }
}