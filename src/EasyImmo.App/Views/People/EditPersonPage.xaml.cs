using EasyImmo.App.ViewModels.People;

namespace EasyImmo.App.Views.People;

public partial class EditPersonPage : ContentPage
{
	public EditPersonPage()
	{
		InitializeComponent();
		BindingContext = new EditPersonViewModel();
    }
}