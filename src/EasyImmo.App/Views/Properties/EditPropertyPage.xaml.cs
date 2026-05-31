using EasyImmo.App.ViewModels.Properties;

namespace EasyImmo.App.Views.Properties;

public partial class EditPropertyPage : ContentPage
{
	public EditPropertyPage()
	{
		InitializeComponent();
		BindingContext = new EditPropertyPageViewModel();
    }
}