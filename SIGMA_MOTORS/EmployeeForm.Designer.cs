namespace SIGMA_MOTORS
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblSearchSection;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchCnic;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvEmployees;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblSearchSection = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchCnic = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();

            this.SuspendLayout();

            // ── pnlHeader ────────────────────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 65;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);

            this.lblTitle.Text = "Employee Management";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Padding = new System.Windows.Forms.Padding(14, 16, 0, 0);

            this.lblTotal.Text = "Total: 0";
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotal.Location = new System.Drawing.Point(340, 23);
            this.lblTotal.AutoSize = true;

            this.lblActive.Text = "Active: 0";
            this.lblActive.ForeColor = System.Drawing.Color.White;
            this.lblActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblActive.Location = new System.Drawing.Point(440, 23);
            this.lblActive.AutoSize = true;

            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblTotal);
            this.pnlHeader.Controls.Add(this.lblActive);

            // ── pnlSearch ────────────────────────────────────────────────────
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height = 54;
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            this.lblSearchSection.Text = "SEARCH";
            this.lblSearchSection.Location = new System.Drawing.Point(0, 0);
            this.lblSearchSection.AutoSize = true;
            this.lblSearchSection.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.lblSearchSection.ForeColor = System.Drawing.Color.Gray;

            this.txtSearchName.Text = "Search by Name...";
            this.txtSearchName.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchName.Location = new System.Drawing.Point(12, 16);
            this.txtSearchName.Size = new System.Drawing.Size(205, 26);
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchName.GotFocus += new System.EventHandler(this.txtSearchName_GotFocus);
            this.txtSearchName.LostFocus += new System.EventHandler(this.txtSearchName_LostFocus);

            this.txtSearchCnic.Text = "Search by CNIC...";
            this.txtSearchCnic.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchCnic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchCnic.Location = new System.Drawing.Point(227, 16);
            this.txtSearchCnic.Size = new System.Drawing.Size(205, 26);
            this.txtSearchCnic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCnic.GotFocus += new System.EventHandler(this.txtSearchCnic_GotFocus);
            this.txtSearchCnic.LostFocus += new System.EventHandler(this.txtSearchCnic_LostFocus);

            this.btnSearch.Text = "Search";
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(442, 16);
            this.btnSearch.Size = new System.Drawing.Size(85, 26);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.pnlSearch.Controls.Add(this.lblSearchSection);
            this.pnlSearch.Controls.Add(this.txtSearchName);
            this.pnlSearch.Controls.Add(this.txtSearchCnic);
            this.pnlSearch.Controls.Add(this.btnSearch);

            // ── pnlActions ───────────────────────────────────────────────────
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Height = 46;
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);

            this.btnAdd.Text = "Add";
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Location = new System.Drawing.Point(12, 9);
            this.btnAdd.Size = new System.Drawing.Size(78, 28);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Text = "Edit";
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Location = new System.Drawing.Point(100, 9);
            this.btnEdit.Size = new System.Drawing.Size(78, 28);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Location = new System.Drawing.Point(188, 9);
            this.btnDelete.Size = new System.Drawing.Size(78, 28);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnExport.Text = "Export CSV";
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.Location = new System.Drawing.Point(276, 9);
            this.btnExport.Size = new System.Drawing.Size(98, 28);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);

            this.pnlActions.Controls.Add(this.btnAdd);
            this.pnlActions.Controls.Add(this.btnEdit);
            this.pnlActions.Controls.Add(this.btnDelete);
            this.pnlActions.Controls.Add(this.btnExport);

            // ── dgvEmployees ─────────────────────────────────────────────────
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmployees.GridColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.dgvEmployees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvEmployees.ColumnHeadersHeight = 36;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(139, 0, 0);
            this.dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvEmployees.RowTemplate.Height = 28;

            // ── Form ─────────────────────────────────────────────────────────
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text = "Employee Management";

            // Fill first → Top panels in reverse visual order last
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);

            this.Load += new System.EventHandler(this.EmployeeForm_Load);

            this.ResumeLayout(false);
        }
    }
}