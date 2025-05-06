using System;
using System.Windows.Forms;

namespace PharmacyLogin
{
    public partial class AddMedicineForm : Form
    {
        public AddMedicineForm()
        {
            InitializeComponent();
            
            // Set default values
            dtpMfgDate.Value = DateTime.Today;
            dtpExpDate.Value = DateTime.Today.AddYears(1);
            numQuantity.Value = 0;
            numPrice.Value = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtManufacturer.Text))
            {
                MessageBox.Show("Please enter manufacturer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManufacturer.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMedicineCode.Text))
            {
                MessageBox.Show("Please enter medicine code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedicineCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMedicineName.Text))
            {
                MessageBox.Show("Please enter medicine name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedicineName.Focus();
                return;
            }

            if (dtpExpDate.Value <= dtpMfgDate.Value)
            {
                MessageBox.Show("Expiry date must be after manufacturing date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpExpDate.Focus();
                return;
            }

            if (numQuantity.Value <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numQuantity.Focus();
                return;
            }

            if (numPrice.Value <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPrice.Focus();
                return;
            }

            // TODO: Save medicine data to database
            MessageBox.Show("Medicine added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Text = "Add Medicine";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
} 