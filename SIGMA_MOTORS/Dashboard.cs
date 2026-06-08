using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIGMA_MOTORS
{
    public partial class Dashboard : Form
    {
        private Form activeForm = null;
        private Button activeButton = null;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblUserName.Text = SessionManager.EmployeeName + " ▼";

            try
            {
                string logoPath = System.IO.Path.Combine(
                    Application.StartupPath, "Resources", "sigma_logo.jpg");
                if (System.IO.File.Exists(logoPath))
                    picLogo.Image = Image.FromFile(logoPath);
            }
            catch { /* logo optional */ }

            OpenChildForm(new MainDashboardForm(), btnDash);
        }

        // ════════════════════════════════════════════════════════════════════════
        //  CHILD FORM LOADER
        // ════════════════════════════════════════════════════════════════════════

        private void OpenChildForm(Form childForm, Button sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            if (activeButton != null)
            {
                activeButton.BackColor = Color.Transparent;
                activeButton.ForeColor = Color.FromArgb(200, 200, 200);
            }

            activeButton = sender;
            activeButton.BackColor = Color.FromArgb(139, 0, 0);
            activeButton.ForeColor = Color.White;

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            MainContentPanel.Controls.Clear();
            MainContentPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        // ════════════════════════════════════════════════════════════════════════
        //  NAVIGATION CLICK
        // ════════════════════════════════════════════════════════════════════════

        private void Navigation_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            if (clicked == null) return;

            switch (clicked.Name)
            {
                case "btnDash":
                    OpenChildForm(new MainDashboardForm(), clicked);
                    break;
                case "btnInventory":
                    OpenChildForm(new InventoryForm(), clicked);
                    break;
                case "btnSales":
                    OpenChildForm(new SalesDeptForm(), clicked);
                    break;
                case "btnPurchase":
                    OpenChildForm(new PurchaseForm(), clicked);
                    break;
                case "btnCustomer":
                    OpenChildForm(new CustomerForm(), clicked);
                    break;
                case "btnSupplier":
                    OpenChildForm(new SupplierForm(), clicked);
                    break;
                case "btnEmployee":
                    OpenChildForm(new EmployeeForm(), clicked);
                    break;
               case "btnReports":
                    OpenChildForm(new ReportsForm(), clicked);
                    break;
                case "btnInvoices":
                    OpenChildForm(new InvoicesForm(), clicked);
                    break;
            }
        }

        // ════════════════════════════════════════════════════════════════════════
        //  POWER / LOGOUT
        // ════════════════════════════════════════════════════════════════════════

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Sigma Motors ERP?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SessionManager.Clear();
                Application.Exit();
            }
        }

        private void MainContentPanel_Paint(object sender, PaintEventArgs e) { }
    }
}