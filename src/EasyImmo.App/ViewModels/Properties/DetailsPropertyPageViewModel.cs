using EasyImmo.Business.Services;
using EasyImmo.Data.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using EasyImmo.App.Views.Properties;

namespace EasyImmo.App.ViewModels.Properties
{

    /// <summary>
    /// ListingDisplayModel
    /// </summary>
    public class ListingDisplayModel
    {
        public Listing Listing { get; set; }

        public bool IsActive => Listing.ListingEndDate == null || Listing.ListingEndDate >= DateTime.Now;
        public string StatusText => IsActive ? "En cours" : "Terminé";
    }

    // Id de la propriété séléctionné
    [QueryProperty(nameof(PropertyId), "PropertyId")]

    /// <summary>
    /// DetailsPropertyPageViewModel
    /// Cette classe représente le ViewModel pour la page des détails de la propriété
    /// </summary>
    public class DetailsPropertyPageViewModel : INotifyPropertyChanged
    {

        // Création des commandes
        public ICommand AddListingCommand { get; }

        // Id la propriété séléctionné
        private int _propertyId;
        public int PropertyId
        {
            get => _propertyId;
            set
            {
                if (_propertyId != value)
                {
                    _propertyId = value;
                    LoadProperty();
                }
            }
        }

        // Propriété séléctionné
        private Property _currentProperty;
        public Property CurrentProperty
        {
            get => _currentProperty;
            set
            {
                _currentProperty = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(SortedListings));
            }
        }

        /// <summary>
        /// Liste des annonces trier par ordre de date
        /// </summary>
        public ObservableCollection<ListingDisplayModel> SortedListings
        {
            get
            {
                if (_currentProperty?.Listings == null)
                    return new ObservableCollection<ListingDisplayModel>();

                var sorted = _currentProperty.Listings
                    .Select(l => new ListingDisplayModel { Listing = l })
                    .OrderByDescending(ldm => ldm.IsActive)
                    .ThenByDescending(ldm => ldm.Listing.ListingStartDate)
                    .ToList();

                return new ObservableCollection<ListingDisplayModel>(sorted);
            }
        }

        public DetailsPropertyPageViewModel()
        {
            // Appel des commandes
            AddListingCommand = new Command(AddListing);
        }

        /// <summary>
        /// Charge la propriété
        /// </summary>
        public void LoadProperty()
        {
            CurrentProperty = PropertyServices.GetPropertyById(PropertyId);
        }

        /// <summary>
        /// Redirige vers la page d'ajout d'une annonce
        /// </summary>
        private async void AddListing()
        {
            bool hasActiveListing = SortedListings != null && SortedListings.Any(ldm => ldm.IsActive);

            // Verification si il y'a déjà une annonce active
            if (hasActiveListing)
            {
                await Shell.Current.DisplayAlert("Action impossible", "Ce bien possède déjà une annonce en cours.", "OK");
                return;
            }

            await Shell.Current.GoToAsync($"{nameof(AddListingPage)}?PropertyId={PropertyId}");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}