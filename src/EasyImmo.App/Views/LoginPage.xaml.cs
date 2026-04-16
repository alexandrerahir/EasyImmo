using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace EasyImmo.App.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // On cache l'erreur à chaque tentative
        ErrorLabel.IsVisible = false;

        if (EmailEntry.Text == "admin" && PasswordEntry.Text == "1234")
        {
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            ErrorLabel.Text = "Nous n'avons trouvé aucun compte associé à ces informations. Vérifiez votre adresse e-mail et votre mot de passe, puis réessayez.";
            ErrorLabel.IsVisible = true;
        }
    }

}