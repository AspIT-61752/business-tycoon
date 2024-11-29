namespace EmpireBuilder.Shared
{
    public class User
    {
        public int Money { get; set; }
        public int ClickValue { get; set; }
        public int UpgradeCost { get; set; }

        public void EarnMoney()
        {
            Money += ClickValue;
        }

        public bool TryUpgrade()
        {
            if (Money >= UpgradeCost)
            {
                Money -= UpgradeCost;
                ClickValue *= 2;
                UpgradeCost *= 2;
                return true;
            }

            return false;
        }
    }
}
