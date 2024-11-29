using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireBuilder.Shared
{
    public partial class Item
    {
        public string Name { get; set; } // Name of the item
        public double Cost { get; set; } // Base cost of the item
        public double SellPrice { get; set; } // Price for selling the item
        public int Stock { get; set; } // Quantity available in the store
        public ItemCategory Category { get; set; } // Category of the item
        public DateTime? ExpirationDate { get; set; } // Expiration date of the item
        public string ImagePath { get; set; } // Path to the image of the item
        public List<ItemUpgrade> Upgrades { get; set; } = new List<ItemUpgrade>(); // List of upgrades for the item

        public bool IsExpired()
        {
            return ExpirationDate.HasValue && DateTime.Now > ExpirationDate.Value;
        }

        public void AdjustPrice(double percentageAdjustment)
        {
            Cost += Cost * (percentageAdjustment / 100);
            SellPrice += SellPrice * (percentageAdjustment / 100);
        }

        public void Restock(int quantity)
        {
            Stock += quantity;
        }

        public bool Buy(int quantity, out double totalCost)
        {
            totalCost = 0;
            if (Stock >= quantity)
            {
                Stock -= quantity;
                totalCost = quantity * Cost;
                return true;
            }

            return false;
        }

        public void Sell(int quantity, out double totalRevenue)
        {
            // If we don't have enough stock, sell what we can
            if (quantity > Stock)
            {
                quantity = Stock;
            }

            totalRevenue = quantity * SellPrice;
            Stock -= quantity;
        }
    }
}
