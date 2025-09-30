namespace HelloWorld;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        string userName = NameEntry.Text;

        if (string.IsNullOrWhiteSpace(userName))
        {
            Label.Text = "Syötä nimesi ensin!";
            Label.TextColor = Colors.Red;
        }
        else
        {
            Label.Text = $"Hello {userName}!";
            Label.TextColor = Colors.Green;
        }
    }
}