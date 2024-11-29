namespace EmpireBuilder.Shared
{
    public partial class Item
    {
        public class ItemUpgrade
        {
            public string Description { get; set; } // Description of the upgrade
            public double Cost { get; set; } // Cost of the upgrade
            public Action<Item> ApplyEffect { get; set; } // Action to apply the upgrade effect
        }
    }
}
