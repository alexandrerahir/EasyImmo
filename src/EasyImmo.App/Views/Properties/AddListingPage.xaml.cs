namespace EasyImmo.App.Views.Properties;

public partial class AddListingPage : ContentPage
{
	public AddListingPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.Properties.AddListingPageViewModel();
    }
}