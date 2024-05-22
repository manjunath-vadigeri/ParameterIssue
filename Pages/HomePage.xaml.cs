
namespace CG.UI.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void OnCIllustrationClicked(object sender, EventArgs e)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "breadcrumbs", new List<string>{ "C Illustration" } }
            };

            Shell.Current.GoToAsync(nameof(CIllustrationPage), navigationParameter);
        }
    }
}