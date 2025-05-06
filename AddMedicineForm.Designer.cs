namespace PharmacyLogin
{
    partial class AddMedicineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblManuAddress = new System.Windows.Forms.Label();
            this.txtManuAddress = new System.Windows.Forms.TextBox();
            this.lblMedicineCode = new System.Windows.Forms.Label();
            this.txtMedicineCode = new System.Windows.Forms.TextBox();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.lblMfgDate = new System.Windows.Forms.Label();
            this.dtpMfgDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(171, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Medicine";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(34, 75);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(87, 16);
            this.lblManufacturer.TabIndex = 1;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(171, 75);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(285, 22);
            this.txtManufacturer.TabIndex = 2;
            // 
            // lblManuAddress
            // 
            this.lblManuAddress.AutoSize = true;
            this.lblManuAddress.Location = new System.Drawing.Point(34, 117);
            this.lblManuAddress.Name = "lblManuAddress";
            this.lblManuAddress.Size = new System.Drawing.Size(61, 16);
            this.lblManuAddress.TabIndex = 3;
            this.lblManuAddress.Text = "Address:";
            // 
            // txtManuAddress
            // 
            this.txtManuAddress.Location = new System.Drawing.Point(171, 117);
            this.txtManuAddress.Name = "txtManuAddress";
            this.txtManuAddress.Size = new System.Drawing.Size(285, 22);
            this.txtManuAddress.TabIndex = 4;
            // 
            // lblMedicineCode
            // 
            this.lblMedicineCode.AutoSize = true;
            this.lblMedicineCode.Location = new System.Drawing.Point(34, 160);
            this.lblMedicineCode.Name = "lblMedicineCode";
            this.lblMedicineCode.Size = new System.Drawing.Size(101, 16);
            this.lblMedicineCode.TabIndex = 5;
            this.lblMedicineCode.Text = "Medicine Code:";
            // 
            // txtMedicineCode
            // 
            this.txtMedicineCode.Location = new System.Drawing.Point(171, 160);
            this.txtMedicineCode.Name = "txtMedicineCode";
            this.txtMedicineCode.Size = new System.Drawing.Size(285, 22);
            this.txtMedicineCode.TabIndex = 6;
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Location = new System.Drawing.Point(34, 203);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(105, 16);
            this.lblMedicineName.TabIndex = 7;
            this.lblMedicineName.Text = "Medicine Name:";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(171, 203);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(285, 22);
            this.txtMedicineName.TabIndex = 8;
            // 
            // lblMfgDate
            // 
            this.lblMfgDate.AutoSize = true;
            this.lblMfgDate.Location = new System.Drawing.Point(34, 245);
            this.lblMfgDate.Name = "lblMfgDate";
            this.lblMfgDate.Size = new System.Drawing.Size(67, 16);
            this.lblMfgDate.TabIndex = 9;
            this.lblMfgDate.Text = "Mfg. Date:";
            // 
            // dtpMfgDate
            // 
            this.dtpMfgDate.Location = new System.Drawing.Point(171, 245);
            this.dtpMfgDate.Name = "dtpMfgDate";
            this.dtpMfgDate.Size = new System.Drawing.Size(285, 22);
            this.dtpMfgDate.TabIndex = 10;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(34, 288);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(68, 16);
            this.lblExpDate.TabIndex = 11;
            this.lblExpDate.Text = "Exp. Date:";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Location = new System.Drawing.Point(171, 288);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(285, 22);
            this.dtpExpDate.TabIndex = 12;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(34, 331);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 16);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Quantity:";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(171, 331);
            this.numQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(137, 22);
            this.numQuantity.TabIndex = 14;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(34, 373);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price:";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(171, 373);
            this.numPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(137, 22);
            this.numPrice.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 32);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(343, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 32);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 480);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblManuAddress);
            this.Controls.Add(this.txtManuAddress);
            this.Controls.Add(this.lblMedicineCode);
            this.Controls.Add(this.txtMedicineCode);
            this.Controls.Add(this.lblMedicineName);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.lblMfgDate);
            this.Controls.Add(this.dtpMfgDate);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.dtpExpDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddMedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Medicine";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblManuAddress;
        private System.Windows.Forms.TextBox txtManuAddress;
        private System.Windows.Forms.Label lblMedicineCode;
        private System.Windows.Forms.TextBox txtMedicineCode;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label lblMfgDate;
        private System.Windows.Forms.DateTimePicker dtpMfgDate;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
} 