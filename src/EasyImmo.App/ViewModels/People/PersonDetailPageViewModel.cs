using EasyImmo.Business.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EasyImmo.App.ViewModels.People
{
    // Personne séléctionné
    [QueryProperty(nameof(CurrentPerson), "SelectedPerson")]

    /// <summary>
    /// PersonDetailPageViewModel
    /// Cette classe représente le ViewModel pour la page de détail d'une personne
    /// </summary>
    public class PersonDetailPageViewModel : INotifyPropertyChanged
    {

        // Personne séléctionné
        private Data.Entities.Person _currentPerson;
        public Data.Entities.Person CurrentPerson
        {
            get => _currentPerson;
            set
            {
                if (value != null)
                {
                    _currentPerson = PersonServices.GetPersonById(value.PersonId);
                }
                else
                {
                    _currentPerson = null;
                }

                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}