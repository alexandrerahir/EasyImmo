using EasyImmo.App.ViewModels.People;

namespace EasyImmo.App.Views.People;

public partial class AddPersonPage : ContentPage
{
	public AddPersonPage()
	{
		InitializeComponent();
        BindingContext = new AddPersonViewModel();
    }
}