using EasyImmo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyImmo.App.Services
{
    /// <summary>
    ///  AuthService
    ///  Service pour l'authentification des agents
    /// </summary>
    public class AuthService
    {
        // Singleton pattern
        private static AuthService _instance;
        public static AuthService Instance => _instance ??= new AuthService();

        // Contexte de la base de données
        private readonly EasyImmoContext _context;

        // Stockage de l'agent connecté
        public Agent? CurrentAgent { get; private set; }

        /// <summary>
        /// Initialise une nouvelle instance de AuthService
        /// </summary>
        public AuthService()
        {
            _context = new EasyImmoContext();
        }

        /// <summary>
        /// Verifie les informations de connexion de l'agent et le connecte s'il est authentifié avec succès
        /// </summary>
        /// <param name="email">Adresse mail de l'agent</param>
        /// <param name="password">Mot de passe de l'agent</param>
        /// <returns>
        /// <c>true</c> Si un agent correspondant aux identifiants fourni est trouvé 
        /// <c>false</c> Si les identifiants fournis sont incorrects
        /// </returns>
        public async Task<bool> LoginAsync(string email, string password)
        {
            // Recherche de l'agent correspondant aux identifiants fournis
            var agent = await _context.Agents.FirstOrDefaultAsync(a => a.EmailAgent == email && a.PasswordAgent == password);

            if (agent != null)
            {
                // Memorisation de l'agent correspondant aux identifiants fournis
                CurrentAgent = agent;
                return true;
            }

            // Aucun agent trouvé correspondant aux identifiants fournis
            return false;
        }

        /// <summary>
        /// Ferme la session de l'agent connecté et redirige vers la page de connexion
        /// </summary>
        public void Logout()
        {
            // Suppression de l'agent
            CurrentAgent = null;

            // Rediction vers la page de connexion
            Application.Current.MainPage = new NavigationPage(new Views.LoginPage());
        }

    }
}
