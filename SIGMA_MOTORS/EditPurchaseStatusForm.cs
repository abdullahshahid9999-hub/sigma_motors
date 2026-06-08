using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIGMA_MOTORS
{
    public partial class EditPurchaseStatusForm : Form
    {
        string connString = "server=localhost;database=SIGMA_MOTORS;uid=root;pwd=Pakistan@1947;";
        private int _poId;
        private string _currentStatus;

        public EditPurchaseStatusForm(int poId, string currentStatus)
        {
            InitializeComponent();
            _poId = poId;
            _currentStatus = currentStatus;
        }

        private void EditPurchaseStatusForm_Load(object sender, EventArgs e)
        {
            lblPoId.Text = $"Purchase Order ID:  {_poId}";
            lblCurrent.Text = $"Current Status:  {_currentStatus}";

            cmbNewStatus.Items.Clear();
            cmbNewStatus.Items.Add("Pending");
            cmbNewStatus.Items.Add("Completed");
            cmbNewStatus.Items.Add("Cancelled");
            cmbNewStatus.SelectedItem = _currentStatus;

            LoadPODetails();
        }

        private void LoadPODetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string q = @"
                        SELECT B.BRAND_NAME, M.MODEL_NAME, VR.VARIENT_NAME,
                               S.COMPANY_NAME, PO.PRICE, PO.PURCHASE_DATE
                        FROM PURCHASE_ORDERS PO
                        JOIN VEHICLE  V  ON PO.VEHICLE_ID  = V.VEHICLE_ID
                        JOIN BRANDS   B  ON V.BRAND_ID     = B.BRAND_ID
                        JOIN MODELS   M  ON V.MODEL_ID     = M.MODEL_ID
                        JOIN VARIENTS VR ON V.VARIENT_ID   = VR.VARIENT_ID
                        JOIN SUPPLIER S  ON PO.SUPPLIER_ID = S.SUPPLIER_ID
                        WHERE PO.PURCHASE_ORDER_ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _poId);
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                lblVehicle.Text = $"{dr["BRAND_NAME"]} {dr["MODEL_NAME"]} {dr["VARIENT_NAME"]}";
                                lblSupplier.Text = dr["COMPANY_NAME"].ToString();
                                lblPrice.Text = $"PKR {Convert.ToDecimal(dr["PRICE"]):N0}";
                                lblDate.Text = Convert.ToDateTime(dr["PURCHASE_DATE"]).ToString("dd MMM yyyy");
                            }
                        }
                    }
                }
                catch { /* optional */ }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbNewStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = cmbNewStatus.SelectedItem.ToString();

            if (newStatus == _currentStatus)
            {
                MessageBox.Show("Status is already " + newStatus, "No Change",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Change status from '{_currentStatus}' to '{newStatus}'?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(
                        "UPDATE PURCHASE_ORDERS SET STATUS = @status WHERE PURCHASE_ORDER_ID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", _poId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Status updated successfully!", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}