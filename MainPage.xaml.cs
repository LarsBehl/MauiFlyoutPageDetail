namespace TestFlyoutApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Task.Delay(1000);
        this.MainStackLayout.Add(new Label() { Text = "New Label" });
    }
}

