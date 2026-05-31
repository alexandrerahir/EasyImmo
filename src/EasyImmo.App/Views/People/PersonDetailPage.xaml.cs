using EasyImmo.App.ViewModels.People;

namespace EasyImmo.App.Views.People;

public partial class PersonDetailPage : ContentPage
{
	public PersonDetailPage()
	{
		InitializeComponent();
		BindingContext = new PersonDetailPageViewModel();
    }
}