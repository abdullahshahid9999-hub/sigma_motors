using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace SIGMA_MOTORS
{
    public partial class InvoicesForm : Form
    {
        private const string ConnStr = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";
        private DataTable _allData = new DataTable();

        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            LoadStats();
            LoadInvoices();
        }

        private void LoadStats()
        {
            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();

                    // Total Invoices
                    var cmd1 = new MySqlCommand("SELECT COUNT(*) FROM INVOICES", conn);
                    lblTotalInvoices.Text = cmd1.ExecuteScalar().ToString();

                    // This Month
                    var cmd2 = new MySqlCommand(
                        "SELECT COUNT(*) FROM INVOICES WHERE MONTH(INVOICE_DATE)=MONTH(NOW()) AND YEAR(INVOICE_DATE)=YEAR(NOW())", conn);
                    lblThisMonth.Text = cmd2.ExecuteScalar().ToString();

                    // Total Revenue
                    var cmd3 = new MySqlCommand("SELECT IFNULL(SUM(NET_AMOUNT),0) FROM INVOICES WHERE STATUS='Paid'", conn);
                    decimal revenue = Convert.ToDecimal(cmd3.ExecuteScalar());
                    lblTotalRevenue.Text = "Rs " + revenue.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInvoices(string search = "")
        {
            try
            {
                using (var conn = new MySqlConnection(ConnStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            I.INVOICE_ID,
                            CONCAT('INV-', LPAD(I.INVOICE_ID, 4, '0')) AS Invoice_No,
                            C.NAME AS Customer,
                            CONCAT(B.BRAND_NAME,' ',M.MODEL_NAME,' ',V2.VARIENT_NAME) AS Vehicle,
                            I.NET_AMOUNT,
                            I.STATUS,
                            DATE_FORMAT(I.INVOICE_DATE,'%d-%b-%Y') AS Invoice_Date,
                            E.NAME AS Salesperson,
                            I.SALE_ID
                        FROM INVOICES I
                        LEFT JOIN CUSTOMER C ON I.CUSTOMER_ID = C.CUSTOMER_ID
                        LEFT JOIN VEHICLE V ON I.VEHICLE_ID = V.VEHICLE_ID
                        LEFT JOIN BRANDS B ON V.BRAND_ID = B.BRAND_ID
                        LEFT JOIN MODELS M ON V.MODEL_ID = M.MODEL_ID
                        LEFT JOIN VARIENTS V2 ON V.VARIENT_ID = V2.VARIENT_ID
                        LEFT JOIN EMPLOYEE E ON I.EMPLOYEE_ID = E.EMPLOYEE_ID
                        WHERE 1=1";

                    if (!string.IsNullOrWhiteSpace(search))
                        query += " AND (C.NAME LIKE @s OR CONCAT('INV-', LPAD(I.INVOICE_ID,4,'0')) LIKE @s)";

                    query += " ORDER BY I.INVOICE_DATE DESC";

                    var cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrWhiteSpace(search))
                        cmd.Parameters.AddWithValue("@s", "%" + search + "%");

                    var adapter = new MySqlDataAdapter(cmd);
                    _allData = new DataTable();
                    adapter.Fill(_allData);

                    // Build display table
                    var display = new DataTable();
                    display.Columns.Add("Invoice No");
                    display.Columns.Add("Customer");
                    display.Columns.Add("Vehicle");
                    display.Columns.Add("Net Amount");
                    display.Columns.Add("Status");
                    display.Columns.Add("Date");
                    display.Columns.Add("Salesperson");
                    display.Columns.Add("INVOICE_ID");
                    display.Columns.Add("SALE_ID");

                    foreach (DataRow row in _allData.Rows)
                    {
                        display.Rows.Add(
                            row["Invoice_No"],
                            row["Customer"],
                            row["Vehicle"],
                            "Rs " + Convert.ToDecimal(row["NET_AMOUNT"]).ToString("N0"),
                            row["STATUS"],
                            row["Invoice_Date"],
                            row["Salesperson"],
                            row["INVOICE_ID"],
                            row["SALE_ID"]
                        );
                    }

                    dgvInvoices.DataSource = display;

                    if (dgvInvoices.Columns.Contains("INVOICE_ID"))
                        dgvInvoices.Columns["INVOICE_ID"].Visible = false;
                    if (dgvInvoices.Columns.Contains("SALE_ID"))
                        dgvInvoices.Columns["SALE_ID"].Visible = false;

                    StyleGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleGrid()
        {
            dgvInvoices.EnableHeadersVisualStyles = false;
            dgvInvoices.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(139, 0, 0);
            dgvInvoices.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInvoices.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgvInvoices.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 245, 245);
            dgvInvoices.DefaultCellStyle.SelectionBackColor = Color.FromArgb(180, 0, 0);
            dgvInvoices.DefaultCellStyle.SelectionForeColor = Color.White;

            // Color status column
            foreach (DataGridViewRow row in dgvInvoices.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString();
                    if (status == "Paid")
                        row.Cells["Status"].Style.ForeColor = Color.Green;
                    else if (status == "Pending")
                        row.Cells["Status"].Style.ForeColor = Color.OrangeRed;
                    else
                        row.Cells["Status"].Style.ForeColor = Color.Gray;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            if (search == "Search by Customer or Invoice ID...")
                search = "";
            LoadInvoices(search);
        }

        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by Customer or Invoice ID...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by Customer or Invoice ID...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentRow == null) return;

            int invoiceId = Convert.ToInt32(dgvInvoices.CurrentRow.Cells["INVOICE_ID"].Value);
            var form = new SaleInvoiceForm(invoiceId);
            form.ShowDialog();
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                var sfd = new SaveFileDialog
                {
                    Filter = "CSV Files|*.csv",
                    FileName = "Invoices_" + DateTime.Now.ToString("yyyyMMdd")
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;

                using (var sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("Invoice No,Customer,Vehicle,Net Amount,Status,Date,Salesperson");
                    foreach (DataGridViewRow row in dgvInvoices.Rows)
                    {
                        if (row.IsNewRow) continue;
                        sw.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6}",
                            row.Cells["Invoice No"].Value,
                            row.Cells["Customer"].Value,
                            "\"" + row.Cells["Vehicle"].Value + "\"",
                            row.Cells["Net Amount"].Value,
                            row.Cells["Status"].Value,
                            row.Cells["Date"].Value,
                            row.Cells["Salesperson"].Value));
                    }
                }
                MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search by Customer or Invoice ID...";
            txtSearch.ForeColor = Color.Gray;
            LoadStats();
            LoadInvoices();
        }

        private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnViewInvoice_Click(sender, e);
        }
    }
}