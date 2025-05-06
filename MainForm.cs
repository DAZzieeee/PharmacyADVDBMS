using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PharmacyLogin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.btnViewMedicine.Click += btnViewMedicine_Click;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Text = "Pharmacy";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            var addForm = new AddMedicineForm();
            addForm.ShowDialog();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            var sellForm = new SellMedicineForm();
            sellForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            // TODO: Replace with actual inventory data source
            var medicines = new List<Medicine>();
            var findForm = new FindMedicine(medicines);
            findForm.ShowDialog();
        }
    }
} 