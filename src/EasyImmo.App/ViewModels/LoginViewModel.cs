using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EasyImmo.Business.Services;
using EasyImmo.App.Views;

namespace EasyImmo.App.ViewModels
{
    /// <summary>
    /// LoginViewModel
    /// Logique de la page de connexion
    /// </summary>
    public partial class LoginViewModel : ObservableObject
    {

        [ObservableProperty]
        private string _email = string.Empty;

        [ObservableProperty]
        private string _password = string.Empty;

        [ObservableProperty]
        private string _errorMessage = string.Empty;

        [ObservableProperty]
        private bool _isErrorVisible = false;

        /// <summary>
        /// Commande liée au bouton
        /// Effectue la validation, l'appel au service et la redirection
        /// </summary>
        [RelayCommand]
        private async Task LoginAsync()
        {
            try
            {
                IsErrorVisible = false;

                // Vérification si les champs sont remplis
                if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
                {
                    ErrorMessage = "Certaines informations sont manquantes. Veuillez compléter tous les champs, puis réessayez";
                    IsErrorVisible = true;
                    return;
                }

                // Appel au service d'authentification
                bool isSuccess = await AuthService.Instance.LoginAsync(Email, Password);


                if (isSuccess)
                {
                    // Si il est connecté, on change la page racine vers le Shell de l'application
                    Application.Current.MainPage = new AppShell();
                }
                else
                {
                    // Si le compte existe pas, affichage de l'erreur
                    ErrorMessage = "Nous n'avons trouvé aucun compte associé à ces informations. Vérifiez vos identifiants, puis réessayez";
                    IsErrorVisible = true;
                }
            }
            catch (Exception ex)
            {
                // Si il y a une exception, on affiche une erreur technique
                ErrorMessage = "Une erreur technique est survenue lors de la connexion. Veuillez réessayer plus tard.";
                IsErrorVisible = true;
            }
        }

        [RelayCommand]
        private void Logout()
        {
            // Appel du service de déconnexion pour supprimer l'agent connecté
            AuthService.Instance.Logout();

            // Redirection vers la page de connexion
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

    }
}