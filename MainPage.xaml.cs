using Detail_Shopping.Views;
using ZXing.Net.Maui;

namespace Detail_Shopping
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void BtnScan_OnClicked(object? sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ScanPage));
        }

        private void BtnHistory_OnClicked(object? sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ScanHistoryPage));
        }
    }

}
