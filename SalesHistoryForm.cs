using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PharmacyLogin
{
    public partial class SalesHistoryForm : Form
    {
        private List<MedicineSale> salesHistory;

        public SalesHistoryForm(List<MedicineSale> sales)
        {
            InitializeComponent();
            salesHistory = sales;
            InitializeDataGridView();
            LoadSalesData();
        }

        private void InitializeDataGridView()
        {
            dataGridViewSales.AutoGenerateColumns = false;
            dataGridViewSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BrandName",
                HeaderText = "Brand Name",
                DataPropertyName = "BrandName"
            });
            dataGridViewSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DateOfSale",
                HeaderText = "Date of Sale",
                DataPropertyName = "DateOfSale",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy HH:mm" }
            });
            dataGridViewSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
            dataGridViewSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            });
            dataGridViewSales.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalPrice",
                HeaderText = "Total Price",
                DataPropertyName = "TotalPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }

        private void LoadSalesData()
        {
            dataGridViewSales.DataSource = null;
            dataGridViewSales.DataSource = salesHistory;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Text = "Sales History";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 