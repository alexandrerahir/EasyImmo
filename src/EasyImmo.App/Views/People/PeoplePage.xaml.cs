using EasyImmo.App.ViewModels.People;

namespace EasyImmo.App.Views.People;

public partial class PeoplePage : ContentPage
{
	public PeoplePage()
	{
		InitializeComponent();
		BindingContext = new PeoplePageViewModel();
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();
		if (BindingContext is PeoplePageViewModel viewModel)
		{
			viewModel.loadPeople();
		}
	}
}