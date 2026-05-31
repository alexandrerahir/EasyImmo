using EasyImmo.App.Views.People;
using EasyImmo.Business.Services;
using EasyImmo.Data.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EasyImmo.App.ViewModels.People
{
    /// <summary>
    /// PeoplePageViewModel
    /// Cette classe représente le ViewModel pour la page des personnes
    /// </summary>
    public class PeoplePageViewModel : INotifyPropertyChanged
    {
        // Liste des personnes
        public ObservableCollection<Data.Entities.Person> People { get; set; }

        // Création des commandes
        public ICommand DeletePersonCommand { get; }
        public ICommand DetailsPersonCommand { get; }
        public ICommand AddPersonCommand { get; }
        public ICommand EditPersonCommand { get; }

        // Nombres de personnes
        private int _personCount;
        public int PersonCount
        {
            get => _personCount;
            set { 
                _personCount = value; 
                OnPropertyChanged(); 
            }
        }

        public PeoplePageViewModel()
        {
            People = new ObservableCollection<Data.Entities.Person>(PersonServices.GetPeople());

            // Appel des commandes
            DeletePersonCommand = new Command<Data.Entities.Person>(DeletePerson);
            DetailsPersonCommand = new Command<Data.Entities.Person>(DetailsPerson);
            AddPersonCommand = new Command(AddPerson);
            EditPersonCommand = new Command<Data.Entities.Person>(EditPerson);

            loadPeople();
        }

        /// <summary>
        /// Charge la liste des personnes
        /// </summary>
        public void loadPeople()
        {
            People.Clear();
            foreach (var person in PersonServices.GetPeople())
            {
                People.Add(person);
            }

            PersonCount = PersonServices.GetPeople().Count;
        }

        /// <summary>
        /// Redirige vers la page d'ajout d'une personne
        /// </summary>
        private async void AddPerson()
        {
            await Shell.Current.GoToAsync(nameof(AddPersonPage));
        }

        /// <summary>
        /// Supprime une personne
        /// </summary>
        private async void DeletePerson(Data.Entities.Person person)
        {
            if (person == null) return;

            bool confirm = await Shell.Current.DisplayAlert("Confirmation", $"Voulez-vous vraiment supprimer {person.FirstNamePerson} {person.LastNamePerson} ?","Oui", "Non");

            if (!confirm) return;

            PersonServices.DeletePersonById(person.PersonId);
            People.Remove(person);
            PersonCount = People.Count;
        }

        /// <summary>
        /// Redirige vers la page de détail d'une personne
        /// </summary>
        private async void DetailsPerson(Data.Entities.Person person)
        {
            if (person == null) return;

            var navigationParameter = new Dictionary<string, object>
            {
                { "SelectedPerson", person }
            };

            await Shell.Current.GoToAsync(nameof(PersonDetailPage), navigationParameter);
        }

        /// <summary>
        /// Modifier une personne
        /// </summary>
        private async void EditPerson(Data.Entities.Person person)
        {
            if (person == null) return;
            var navigationParameter = new Dictionary<string, object>
            {
                { "SelectedPerson", person }
            };
            await Shell.Current.GoToAsync(nameof(EditPersonPage), navigationParameter);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
