using CG.UI.ViewModels;

namespace CG.UI.Pages
{
    public partial class CIllustrationPage : ContentPage
    {
        public CIllustrationPage(/*CollegeCategoriesViewModel viewModel*/)
    	{
    		InitializeComponent();

            //I want to send the viewModel data to the component => BUT viewModel is not yet available
            //view model will be bound at a later stage and triggers OnBindingContextChanged
            
            rootComponent.Parameters =
            new Dictionary<string, object>
            {
                { "RichTextContent",  "From Constructor"}
            };

            //simulating the viewmodel initialization
            BindingContext = "BINDING";
        }

        protected override async void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            //await viewModel.Init();

            new Task(async () =>
            {
                await Task.Delay(2000);
                //viewModel.College.Details = @"<h1> College Information</h1>";
                var details = "From OnBindingContextChanged";

                rootComponent.Parameters =
                new Dictionary<string, object>
                {
                    { "RichTextContent",  details}
                };
            }).Start();
    }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    //await viewModel.Init();

        //    rootComponent.Parameters =
        //    new Dictionary<string, object>
        //    {
        //        { "RichTextContent", "Hello" }
        //    };
        //}
    }
}
