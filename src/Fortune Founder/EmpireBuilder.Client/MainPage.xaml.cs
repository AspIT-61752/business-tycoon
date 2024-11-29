using EmpireBuilder.Shared;

namespace EmpireBuilder.Client
{
    public partial class MainPage : ContentPage
    {
        private User _user;
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            _user = new User();

            if (_user.ClickValue < 1)
            {
                _user.ClickValue = 1;
            }

            if (_user.UpgradeCost < 2)
            {
                _user.UpgradeCost = 15;
            }

            StartPassiveIncome();
            UpdateUI();
        }

        private void OnClickButtonClicked(object sender, EventArgs e)
        {
            _user.EarnMoney();
            UpdateUI(sender);
            SemanticScreenReader.Announce(ClickButton.Text);
        }

        private void OnUpgradeButtonClicked(object sender, EventArgs e)
        {
            if (_user.TryUpgrade())
            {
                UpdateUI(sender);
                SemanticScreenReader.Announce(UpgradeButton.Text);
            }
        }

        private async void StartPassiveIncome()
        {
            while (true)
            {
                await Task.Delay(1000);
                _user.EarnMoney();
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            MoneyLabel.Text = $"Money: ${_user.Money}";
            UpgradeButton.Text = $"Upgrade (Cost: ${_user.UpgradeCost})";
            UpgradeButton.IsEnabled = _user.Money >= _user.UpgradeCost;
        }

        private void UpdateUI(object sender)
        {
            MoneyLabel.Text = $"Money: ${_user.Money}";
            UpgradeButton.Text = $"Upgrade (Cost: ${_user.UpgradeCost})";
            UpgradeButton.IsEnabled = _user.Money >= _user.UpgradeCost;

            
        }

        private async void OnGoToItemsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsPage());
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}
    }

}
