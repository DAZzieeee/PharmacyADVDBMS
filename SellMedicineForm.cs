using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PharmacyLogin;

namespace PharmacyLogin
{
    public partial class SellMedicineForm : Form
    {
        private static List<MedicineSale> salesHistory = new List<MedicineSale>();

        public SellMedicineForm()
        {
            InitializeComponent();
            this.btnViewSalesHistory.Click += btnViewSalesHistory_Click;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement search functionality using the ID/code
            if (string.IsNullOrWhiteSpace(idCodeTextBox.Text))
            {
                MessageBox.Show("Please enter an ID/Code to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Add database search logic here
        }

        private void CalculateTotal()
        {
            if (decimal.TryParse(priceTextBox.Text, out decimal price) && 
                decimal.TryParse(quantityTextBox.Text, out decimal quantity))
            {
                decimal total = price * quantity;
                totalTextBox.Text = total.ToString("0.00");
            }
        }

        private void CalculateChange()
        {
            if (decimal.TryParse(totalTextBox.Text, out decimal total) && 
                decimal.TryParse(cashTextBox.Text, out decimal cash))
            {
                decimal change = cash - total;
                changeTextBox.Text = change.ToString("0.00");
            }
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CashTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(brandNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(priceTextBox.Text) ||
                string.IsNullOrWhiteSpace(quantityTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceTextBox.Text, out decimal price) ||
                !int.TryParse(quantityTextBox.Text, out int quantity))
            {
                MessageBox.Show("Please enter valid price and quantity values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create and add the sale record
            var sale = new MedicineSale(brandNameTextBox.Text, price, quantity);
            salesHistory.Add(sale);

            MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearButton_Click(sender, e);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewSalesHistory_Click(object sender, EventArgs e)
        {
            var salesHistoryForm = new SalesHistoryForm(salesHistory);
            salesHistoryForm.ShowDialog();
        }
    }
} 