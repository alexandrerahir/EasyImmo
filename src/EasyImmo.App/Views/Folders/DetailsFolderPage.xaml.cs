namespace EasyImmo.App.Views.Folders;

public partial class DetailsFolderPage : ContentPage
{
	public DetailsFolderPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.Folders.DetailsFolderPageViewModel();
    }
}