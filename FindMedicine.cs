using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PharmacyLogin
{
    public partial class FindMedicine : Form
    {
        private List<Medicine> medicines; // Replace with your data source

        public FindMedicine(List<Medicine> inventory)
        {
            InitializeComponent();
            medicines = inventory;
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MedicineID", "MedicineID");
            dataGridView1.Columns.Add("ManufacturerName", "Manufacturer Name");
            dataGridView1.Columns.Add("ManufacturerAddress", "Manufacturer Address");
            dataGridView1.Columns.Add("MedicineName", "Medicine Name");
            dataGridView1.Columns.Add("Brand", "Brand");
            dataGridView1.Columns.Add("GenericName", "Generic Name");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("ExpirationDate", "Expiration Date");
            dataGridView1.Columns.Add("Category", "Category");
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            string term = txtSearch.Text.Trim().ToLower();
            var results = medicines.Where(m =>
                m.ID.ToString().Contains(term) ||
                m.Brand.ToLower().Contains(term) ||
                m.GenericName.ToLower().Contains(term)
            ).ToList();
            dataGridView1.DataSource = results;
        }

        public void btnViewAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = medicines;
        }

        public void btnSortNameAsc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = medicines.OrderBy(m => m.ID).ToList();
        }

        public void btnSortNameDesc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = medicines.OrderByDescending(m => m.ID).ToList();
        }

        public void btnSortIDAsc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = medicines.OrderBy(m => m.ID).ToList();
        }

        public void btnSortIDDesc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = medicines.OrderByDescending(m => m.ID).ToList();
        }

        public void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }

    // Example Medicine class
    public class Medicine
    {
        public int ID { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerAddress { get; set; }
        public string MedicineName { get; set; }
        public string Brand { get; set; }
        public string GenericName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Category { get; set; }
    }
}