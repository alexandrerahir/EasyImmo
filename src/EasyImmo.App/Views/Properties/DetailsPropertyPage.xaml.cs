using EasyImmo.App.ViewModels.Properties;

namespace EasyImmo.App.Views.Properties;

public partial class DetailsPropertyPage : ContentPage
{
	public DetailsPropertyPage()
	{
		InitializeComponent();
		BindingContext = new DetailsPropertyPageViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is DetailsPropertyPageViewModel viewModel)
        {
            if (viewModel.PropertyId > 0)
            {
                viewModel.LoadProperty();
            }
        }
    }
}