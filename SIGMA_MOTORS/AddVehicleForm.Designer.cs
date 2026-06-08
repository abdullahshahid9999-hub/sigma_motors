namespace SIGMA_MOTORS
{
    partial class AddVehicleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbVarient = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBrand
            // 
            this.cmbBrand.Location = new System.Drawing.Point(25, 70);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(250, 21);
            this.cmbBrand.TabIndex = 0;
            this.cmbBrand.Text = "Select Brand";
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // cmbModel
            // 
            this.cmbModel.Location = new System.Drawing.Point(25, 110);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(250, 21);
            this.cmbModel.TabIndex = 1;
            this.cmbModel.Text = "Select Model";
            // 
            // cmbVarient
            // 
            this.cmbVarient.Location = new System.Drawing.Point(25, 150);
            this.cmbVarient.Name = "cmbVarient";
            this.cmbVarient.Size = new System.Drawing.Size(250, 21);
            this.cmbVarient.TabIndex = 2;
            this.cmbVarient.Text = "Select Varient";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(25, 270);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(250, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "Price";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(25, 190);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(250, 20);
            this.txtColour.TabIndex = 4;
            this.txtColour.Text = "Colour";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(25, 230);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(250, 20);
            this.txtYear.TabIndex = 5;
            this.txtYear.Text = "2024";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(25, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE VEHICLE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADD NEW VEHICLE";
            // 
            // AddVehicleForm
            // 
            this.ClientSize = new System.Drawing.Size(928, 400);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbVarient);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbBrand, cmbModel, cmbVarient;
        private System.Windows.Forms.TextBox txtPrice, txtColour, txtYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}