using EasyImmo.Business.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EasyImmo.App.ViewModels.People
{
    // Personne séléctionné
    [QueryProperty(nameof(CurrentPerson), "SelectedPerson")]

    /// <summary>
    /// EditPersonViewModel
    /// Cette classe représente le ViewModel pour la page d'édition d'une personne
    /// </summary>
    public class EditPersonViewModel : INotifyPropertyChanged
    {
        // Personne séléctionné
        private Data.Entities.Person _currentPerson;
        public Data.Entities.Person CurrentPerson
        {
            get => _currentPerson;
            set
            {
                _currentPerson = value;
                if (_currentPerson != null)
                {
                    FirstName = _currentPerson.FirstNamePerson;
                    LastName = _currentPerson.LastNamePerson;
                    Email = _currentPerson.EmailPerson;
                    Phone = _currentPerson.PhonePerson;
                }
                OnPropertyChanged();
            }
        }

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

        public EditPersonViewModel()
        {
            // Appel des commandes
            SaveCommand = new Command(SavePerson);
        }

        /// <summary>
        /// Modifie une personne
        /// </summary>
        private async void SavePerson()
        {
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Phone) || string.IsNullOrWhiteSpace(Email))
            {
                await Shell.Current.DisplayAlert("Attention", "Veuillez remplir tous les champs (Prénom, Nom, Téléphone, Email).", "OK");
                return;
            }

            _currentPerson.FirstNamePerson = FirstName;
            _currentPerson.LastNamePerson = LastName;
            _currentPerson.EmailPerson = Email;
            _currentPerson.PhonePerson = Phone;

            PersonServices.UpdatePerson(_currentPerson);

            await Shell.Current.GoToAsync("..");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
