namespace CG.UI.Views;

public partial class CustomWebView : ContentView
{
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomWebView), default);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public CustomWebView()
	{
		InitializeComponent();
	}

    private async void OnNavigating(object sender, WebNavigatingEventArgs e)
    {
        string localUrlPrefix = "local://";
        if (!e.Url.StartsWith(localUrlPrefix))
        {
            e.Cancel = true;
            return;
        }

        string url = e.Url[localUrlPrefix.Length..];
        await Shell.Current.GoToAsync(url);
    }

}