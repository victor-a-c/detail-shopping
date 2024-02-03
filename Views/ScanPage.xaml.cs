using ZXing.Net.Maui;

namespace Detail_Shopping.Views;

public partial class ScanPage : ContentPage
{
	public ScanPage()
	{
		InitializeComponent();
        barcodeReader.Options = new ZXing.Net.Maui.BarcodeReaderOptions
        {

            Formats = BarcodeFormats.All,

            //Limits to a given format --> Formats = ZXing.Net.Maui.BarcodeFormat.Ean13,
            Multiple = true,
            AutoRotate = true,
            TryHarder = true
        };
        barcodeReader.CameraLocation = CameraLocation.Rear;
    }

    private void barcodeReader_OnBarcodesDetected(object? sender, BarcodeDetectionEventArgs e)
    {
        Dispatcher.Dispatch(() =>
        {
            //barcodeResult.Text = $"{e.Results[0].Value} {e.Results[0].Format}";
        });

    }
}