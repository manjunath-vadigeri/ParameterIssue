using System.Windows.Input;

namespace CG.UI.Views;

public partial class Tile : ContentView
{
    public static readonly BindableProperty ImageSourceProperty =
        BindableProperty.Create(nameof(ImageSource), typeof(ImageSource), typeof(Tile), default(ImageSource));

    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(Tile), string.Empty);

    public static readonly BindableProperty CountProperty =
        BindableProperty.Create(nameof(Count), typeof(string), typeof(Tile), string.Empty);

    //public static readonly BindableProperty IconHeightProperty =
    //    BindableProperty.Create(nameof(IconHeight), typeof(double), typeof(Tile), 65.0);

    //public static readonly BindableProperty IconWidthProperty =
    //    BindableProperty.Create(nameof(IconWidth), typeof(double), typeof(Tile), 100.0);

    public static readonly BindableProperty CommandProperty =
        BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(Tile), default(ICommand));

    public static readonly BindableProperty CommandParameterProperty =
        BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(Tile), null);

    public event EventHandler<EventArgs> Clicked;

    public Tile()
    {
        InitializeComponent();
    }

    public ImageSource ImageSource
    {
        get => (ImageSource)GetValue(ImageSourceProperty);
        set => SetValue(ImageSourceProperty, value);
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public string Count
    {
        get => (string)GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }

    //public double IconHeight
    //{
    //    get => (double)GetValue(IconHeightProperty);
    //    set => SetValue(IconHeightProperty, value);
    //}

    //public double IconWidth
    //{
    //    get => (double)GetValue(IconWidthProperty);
    //    set => SetValue(IconWidthProperty, value);
    //}

    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public object CommandParameter
    {
        get => GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }

    private void OnSelected(object sender, EventArgs e)
    {
        if (Clicked != null)
        {
            Clicked.Invoke(this, EventArgs.Empty);
            return;
        }

        Command?.Execute(CommandParameter);
    }
}
