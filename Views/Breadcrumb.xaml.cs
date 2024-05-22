using System.Text;

namespace CG.UI.Views;

public partial class Breadcrumb : ContentView
{
    public static readonly BindableProperty IconSourceProperty =
        BindableProperty.Create(nameof(IconSource), typeof(ImageSource), typeof(Breadcrumb), default(ImageSource));

    public static readonly BindableProperty ItemsProperty =
            BindableProperty.Create(nameof(Items), typeof(IList<string>), typeof(Breadcrumb), new List<string>());

    public ImageSource IconSource
    {
        get => (ImageSource)GetValue(IconSourceProperty);
        set => SetValue(IconSourceProperty, value);
    }

    public IList<string> Items
    {
        get { return (IList<string>)GetValue(ItemsProperty); }
        set { SetValue(ItemsProperty, value); }
    }

    public Breadcrumb()
    {
        InitializeComponent();
    }

    private async void OnBreadcrumbItemSelected(object sender, TappedEventArgs e)
    {
        if (sender is Label label)
        {
            var items = Items;
            int index = items.IndexOf(label.Text);

            int level = items.Count - 1 - index;
            await GoBack(level);
        }
    }

    private async void OnIconSelected(object sender, EventArgs e)
    {
        await GoBack(Items.Count - 1);
    }

    private async Task GoBack(int level)
    {

        if (level >= Navigation.NavigationStack.Count)
        {
            level = Navigation.NavigationStack.Count - 1;
        }

        if (level <= 0)
        {
            return;
        }

        StringBuilder urlBuilder = new StringBuilder();
        for (; level > 1; level--)
        { 
            urlBuilder.Append("../");
        }

        string url = urlBuilder.Append("..").ToString();
        await Shell.Current.GoToAsync(url);
    }
}