using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpireBuilder.Shared
{
    public class Store
    {
        public string StoreName { get; set; }
        public int MaxUpgrade { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        public int CurrentUpgradeLevel { get; set; } = 0;

        public void Upgrade()
        {
            if (CurrentUpgradeLevel < MaxUpgrade)
            {
                CurrentUpgradeLevel++;
            }
        }

        public virtual string GetLayout()
        {
            return "Default Layout";
            //return "Store Layout";

            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Store: {StoreName}");
            //sb.AppendLine($"Current Upgrade Level: {CurrentUpgradeLevel}");
            //sb.AppendLine($"Max Upgrade Level: {MaxUpgrade}");
            //sb.AppendLine("Items:");
            //    foreach (var item in Items)
            //    {
            //        sb.AppendLine(item.ToString());
            //    }
            //return sb.ToString();
        }

        public void RestockItem(Item item, int quantity)
        {
            item.Restock(quantity);
        }

        public bool SellItem(Item item, int quantity, out double totalRevenue)
        {
            totalRevenue = 0;
            if (!Items.Contains(item))
            {
                return false;
            }

            // TODO: Do I even check if this is possible?
            item.Sell(quantity, out totalRevenue);

            if (item.Stock <= 0)
            {
                Items.Remove(item);
            }

            return true;
        }
    }
}
