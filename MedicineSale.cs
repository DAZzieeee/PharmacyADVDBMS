using System;

namespace PharmacyLogin
{
    public class MedicineSale
    {
        public string BrandName { get; set; }
        public DateTime DateOfSale { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public MedicineSale(string brandName, decimal price, int quantity)
        {
            BrandName = brandName;
            DateOfSale = DateTime.Now;
            Price = price;
            Quantity = quantity;
            TotalPrice = price * quantity;
        }
    }
} 