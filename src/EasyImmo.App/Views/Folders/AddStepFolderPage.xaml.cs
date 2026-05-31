namespace EasyImmo.App.Views.Folders;

public partial class AddStepFolderPage : ContentPage
{
	public AddStepFolderPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.Folders.AddStepFolderPageViewModel();
    }
}