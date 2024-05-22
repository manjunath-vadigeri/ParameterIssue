using CommunityToolkit.Maui.Behaviors;

namespace CG.UI.Views;

public class CustomImage : Image
{
    public static readonly BindableProperty TintColorProperty =
        BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(CustomImage), default, propertyChanged: OnTintColorChanged);

    public Color? TintColor
    {
        get => (Color?)GetValue(TintColorProperty);
        set => SetValue(TintColorProperty, value);
    }

    private static void OnTintColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is not CustomImage control)
        {
            return;
        }

        Behavior toRemove = control.Behaviors.FirstOrDefault(b => b is IconTintColorBehavior);

        if (toRemove is not null)
        {
            control.Behaviors.Remove(toRemove);
        }

        if (newValue is not null && newValue is Color tintColor)
        {
            IconTintColorBehavior tintBehavior = new() { TintColor = tintColor };
            control.Behaviors.Add(tintBehavior);
        }
    }
}
