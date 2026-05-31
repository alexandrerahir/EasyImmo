using EasyImmo.App.ViewModels;

namespace EasyImmo.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is MainPageViewModel viewModel)
            {
                viewModel.LoadData();
            }
        }
    }
}
