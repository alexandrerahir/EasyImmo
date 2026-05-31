using EasyImmo.App.ViewModels.Properties;

namespace EasyImmo.App.Views.Properties;

public partial class PropertiesPage : ContentPage
{
	public PropertiesPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.Properties.PropertiesPageViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is PropertiesPageViewModel viewModel)
        {
            viewModel.LoadProperties();
        }
    }
}