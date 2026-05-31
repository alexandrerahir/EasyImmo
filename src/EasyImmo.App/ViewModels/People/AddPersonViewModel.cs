using EasyImmo.Business.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EasyImmo.App.ViewModels.People
{
    /// <summary>
    /// AddPersonViewModel
    /// Cette classe représente le ViewModel pour la page d'ajout d'une personne
    /// </summary>
    public class AddPersonViewModel : INotifyPropertyChanged
    {
        // Nom
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set { _firstName = value; OnPropertyChanged(); }
        }

        // Prénom
        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set { _lastName = value; OnPropertyChanged(); }
        }

        // Email
        private string _email;
        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }

        // Numéro de téléphone
        private string _phone;
        public string Phone
        {
            get => _phone;
            set { _phone = value; OnPropertyChanged(); }
        }

        // Création des commandes
        public ICommand SaveCommand { get; }

        public AddPersonViewModel()
        {
            // Appel de la commande
            SaveCommand = new Command(SavePerson);
        }

        /// <summary>
        /// Enregistre une nouvelle personne
        /// </summary>
        private async void SavePerson()
        {
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Phone) || string.IsNullOrWhiteSpace(Email))
            {
                await Shell.Current.DisplayAlert("Attention", "Veuillez remplir tous les champs (Prénom, Nom, Téléphone, Email).", "OK");
                return;
            }

            var newPerson = new Data.Entities.Person
            {
                FirstNamePerson = FirstName,
                LastNamePerson = LastName,
                EmailPerson = Email,
                PhonePerson = Phone,
                AddressId = 1
            };

            PersonServices.AddPerson(newPerson);

            await Shell.Current.GoToAsync("..");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}