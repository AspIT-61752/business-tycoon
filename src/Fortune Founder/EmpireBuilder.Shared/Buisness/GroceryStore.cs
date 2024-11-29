using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmpireBuilder.Shared.Buisness
{
    public partial class GroceryStore : Store
    {
        public GroceryStore()
        {
            StoreName = "Grocery Store";
            MaxUpgrade = 5;
            Items.Add(new Item { Name = "Apple", Cost = 0.50, SellPrice = 1.00, Stock = 100, Category = Item.ItemCategory.Fruit, ExpirationDate = DateTime.Now.AddDays(7), ImagePath = "Images/apple.png" });
            Items.Add(new Item { Name = "Banana", Cost = 0.25, SellPrice = 0.75, Stock = 100, Category = Item.ItemCategory.Fruit, ExpirationDate = DateTime.Now.AddDays(5), ImagePath = "Images/banana.png" });
            Items.Add(new Item { Name = "Orange", Cost = 0.75, SellPrice = 1.25, Stock = 100, Category = Item.ItemCategory.Fruit, ExpirationDate = DateTime.Now.AddDays(10), ImagePath = "Images/orange.png" });
            Items.Add(new Item { Name = "Milk", Cost = 2.00, SellPrice = 3.00, Stock = 100, Category = Item.ItemCategory.Dairy, ExpirationDate = DateTime.Now.AddDays(14), ImagePath = "Images/milk.png" });
            Items.Add(new Item { Name = "Eggs", Cost = 1.50, SellPrice = 2.50, Stock = 100, Category = Item.ItemCategory.Poultry, ExpirationDate = DateTime.Now.AddDays(7), ImagePath = "Images/eggs.png" });
        }
    }
}
