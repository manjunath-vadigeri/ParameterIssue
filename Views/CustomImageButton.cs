using CommunityToolkit.Maui.Behaviors;

namespace CG.UI.Views;

public class CustomImageButton : ImageButton
{
    public static readonly BindableProperty TintColorProperty =
        BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(CustomImageButton), default, propertyChanged: OnTintColorChanged);

    public Color? TintColor
    {
        get => (Color?)GetValue(TintColorProperty);
        set => SetValue(TintColorProperty, value);
    }

    private static void OnTintColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is not CustomImageButton control)
        {
            return;
        }

        var tintColor = control.TintColor;
        Behavior toRemove = control.Behaviors.FirstOrDefault(b => b is IconTintColorBehavior);

        if (toRemove is not null)
        {
            control.Behaviors.Remove(toRemove);
        }

        if (newValue is not null)
        {
            IconTintColorBehavior tintBehavior = new() { TintColor = tintColor };
            control.Behaviors.Add(tintBehavior);
        }
    }
}
