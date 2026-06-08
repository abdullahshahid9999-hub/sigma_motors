namespace SIGMA_MOTORS
{
    partial class ProfitLossForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblMonthLbl;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblYearLbl;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblPeriod;

        // Revenue row
        private System.Windows.Forms.Panel pnlRevRow;
        private System.Windows.Forms.Label lblRevenueLbl;
        private System.Windows.Forms.Label lblRevenueValue;

        // Cost row
        private System.Windows.Forms.Panel pnlCostRow;
        private System.Windows.Forms.Label lblCostLbl;
        private System.Windows.Forms.Label lblCostValue;

        // Divider
        private System.Windows.Forms.Panel pnlDivider;

        // Profit/Loss row
        private System.Windows.Forms.Panel pnlProfitRow;
        private System.Windows.Forms.Label lblProfitLabel;
        private System.Windows.Forms.Label lblProfitValue;

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

            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblMonthLbl = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYearLbl = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblPeriod = new System.Windows.Forms.Label();

            this.pnlRevRow = new System.Windows.Forms.Panel();
            this.lblRevenueLbl = new System.Windows.Forms.Label();
            this.lblRevenueValue = new System.Windows.Forms.Label();

            this.pnlCostRow = new System.Windows.Forms.Panel();
            this.lblCostLbl = new System.Windows.Forms.Label();
            this.lblCostValue = new System.Windows.Forms.Label();

            this.pnlDivider = new System.Windows.Forms.Panel();

            this.pnlProfitRow = new System.Windows.Forms.Panel();
            this.lblProfitLabel = new System.Windows.Forms.Label();
            this.lblProfitValue = new System.Windows.Forms.Label();

            System.Drawing.Color darkRed = System.Drawing.Color.FromArgb(139, 0, 0);
            System.Drawing.Color green = System.Drawing.Color.FromArgb(0, 150, 0);

            // ── FORM ──
            this.Text = "Profit & Loss Report";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Size = new System.Drawing.Size(520, 480);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Load += new System.EventHandler(this.ProfitLossForm_Load);

            // ── HEADER ──
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 52;
            this.pnlHeader.BackColor = darkRed;

            this.lblTitle.Text = "Profit & Loss Statement";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 12);
            this.pnlHeader.Controls.Add(this.lblTitle);

            // ── FILTER ──
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Height = 60;
            this.pnlFilter.BackColor = System.Drawing.Color.White;

            this.lblMonthLbl.Text = "Month:";
            this.lblMonthLbl.AutoSize = true;
            this.lblMonthLbl.Location = new System.Drawing.Point(20, 20);
            this.lblMonthLbl.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Size = new System.Drawing.Size(130, 26);
            this.cmbMonth.Location = new System.Drawing.Point(72, 16);

            this.lblYearLbl.Text = "Year:";
            this.lblYearLbl.AutoSize = true;
            this.lblYearLbl.Location = new System.Drawing.Point(216, 20);
            this.lblYearLbl.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Size = new System.Drawing.Size(90, 26);
            this.cmbYear.Location = new System.Drawing.Point(256, 16);

            this.btnGenerate.Text = "Generate";
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.BackColor = darkRed;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Size = new System.Drawing.Size(90, 28);
            this.btnGenerate.Location = new System.Drawing.Point(360, 15);
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            this.btnClose.Text = "✕ Close";
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.Size = new System.Drawing.Size(72, 28);
            this.btnClose.Location = new System.Drawing.Point(456, 15);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.pnlFilter.Controls.Add(this.lblMonthLbl);
            this.pnlFilter.Controls.Add(this.cmbMonth);
            this.pnlFilter.Controls.Add(this.lblYearLbl);
            this.pnlFilter.Controls.Add(this.cmbYear);
            this.pnlFilter.Controls.Add(this.btnGenerate);
            this.pnlFilter.Controls.Add(this.btnClose);

            // ── RESULTS PANEL ──
            this.pnlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResults.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlResults.Visible = false;
            this.pnlResults.Padding = new System.Windows.Forms.Padding(40, 30, 40, 30);

            // Period label
            this.lblPeriod.Text = "";
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPeriod.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(40, 30);
            this.lblPeriod.Visible = false;

            // Revenue Row
            this.pnlRevRow.BackColor = System.Drawing.Color.White;
            this.pnlRevRow.Size = new System.Drawing.Size(420, 54);
            this.pnlRevRow.Location = new System.Drawing.Point(40, 70);

            this.lblRevenueLbl.Text = "Revenue";
            this.lblRevenueLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRevenueLbl.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblRevenueLbl.AutoSize = true;
            this.lblRevenueLbl.Location = new System.Drawing.Point(16, 14);

            this.lblRevenueValue.Text = "Rs 0";
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblRevenueValue.ForeColor = green;
            this.lblRevenueValue.AutoSize = true;
            this.lblRevenueValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblRevenueValue.Location = new System.Drawing.Point(280, 13);

            this.pnlRevRow.Controls.Add(this.lblRevenueLbl);
            this.pnlRevRow.Controls.Add(this.lblRevenueValue);

            // Cost Row
            this.pnlCostRow.BackColor = System.Drawing.Color.White;
            this.pnlCostRow.Size = new System.Drawing.Size(420, 54);
            this.pnlCostRow.Location = new System.Drawing.Point(40, 134);

            this.lblCostLbl.Text = "Total Cost";
            this.lblCostLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCostLbl.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblCostLbl.AutoSize = true;
            this.lblCostLbl.Location = new System.Drawing.Point(16, 14);

            this.lblCostValue.Text = "Rs 0";
            this.lblCostValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCostValue.ForeColor = System.Drawing.Color.FromArgb(180, 0, 0);
            this.lblCostValue.AutoSize = true;
            this.lblCostValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCostValue.Location = new System.Drawing.Point(280, 13);

            this.pnlCostRow.Controls.Add(this.lblCostLbl);
            this.pnlCostRow.Controls.Add(this.lblCostValue);

            // Divider
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.pnlDivider.Size = new System.Drawing.Size(420, 2);
            this.pnlDivider.Location = new System.Drawing.Point(40, 198);

            // Profit/Loss Row
            this.pnlProfitRow.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.pnlProfitRow.Size = new System.Drawing.Size(420, 70);
            this.pnlProfitRow.Location = new System.Drawing.Point(40, 210);

            this.lblProfitLabel.Text = "Net Profit";
            this.lblProfitLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProfitLabel.ForeColor = green;
            this.lblProfitLabel.AutoSize = true;
            this.lblProfitLabel.Location = new System.Drawing.Point(16, 18);

            this.lblProfitValue.Text = "+Rs 0";
            this.lblProfitValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblProfitValue.ForeColor = green;
            this.lblProfitValue.AutoSize = true;
            this.lblProfitValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblProfitValue.Location = new System.Drawing.Point(240, 16);

            this.pnlProfitRow.Controls.Add(this.lblProfitLabel);
            this.pnlProfitRow.Controls.Add(this.lblProfitValue);

            this.pnlResults.Controls.Add(this.lblPeriod);
            this.pnlResults.Controls.Add(this.pnlRevRow);
            this.pnlResults.Controls.Add(this.pnlCostRow);
            this.pnlResults.Controls.Add(this.pnlDivider);
            this.pnlResults.Controls.Add(this.pnlProfitRow);

            // ── ADD TO FORM ──
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
        }
    }
}