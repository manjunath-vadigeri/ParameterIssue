using CommunityToolkit.Mvvm.ComponentModel;

namespace CG.UI.ViewModels;

[QueryProperty(nameof(Breadcrumbs), "breadcrumbs")]
public partial class AbstractViewModelWithBreadcrumb : ObservableObject
{
    [ObservableProperty]
    private List<string> breadcrumbs;
}
