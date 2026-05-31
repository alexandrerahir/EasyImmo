using EasyImmo.App.ViewModels.Folders;

namespace EasyImmo.App.Views.Folders;

public partial class FoldersPage : ContentPage
{
	public FoldersPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.Folders.FoldersPageViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is FoldersPageViewModel viewModel)
        {
            viewModel.LoadFolders();
        }
    }

}