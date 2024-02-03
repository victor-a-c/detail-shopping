namespace Detail_Shopping.Views;

public partial class ScanHistoryPage : ContentPage
{
	public ScanHistoryPage()
	{
		InitializeComponent();
        List<ScannedItem> scans = new List<ScannedItem>()
        {
            new ScannedItem { name="Coca-Cola Coke Zero", manufacturer="Coca-Cola"},
            new ScannedItem { name="test2", manufacturer="test2 manufacturer"}
        };

        scanHistoryList.ItemsSource = scans;
	}

    private void BtnBack_OnClicked(object? sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    public class ScannedItem()
    {
        public string name { get; set; }
        public string manufacturer { get; set;}
        //country of origin
        //public string product_origin { get; set;}
    }
}