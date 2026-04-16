using EasyImmo.App.ViewModels;

namespace EasyImmo.App.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}