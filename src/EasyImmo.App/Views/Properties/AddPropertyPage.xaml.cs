namespace EasyImmo.App.Views.Properties;

public partial class AddPropertyPage : ContentPage
{
	public AddPropertyPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.Properties.AddPropertyPageViewModel();

    }
}