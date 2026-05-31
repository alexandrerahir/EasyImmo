namespace EasyImmo.App.Views.Folders;

public partial class EditStatusFolderPage : ContentPage
{
	public EditStatusFolderPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.Folders.EditStatusFolderPageViewModel();
    }
}