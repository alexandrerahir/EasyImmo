using EasyImmo.App.Views.People;
using EasyImmo.App.Views.Properties;
using EasyImmo.Business.Services;
using EasyImmo.Data.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EasyImmo.App.ViewModels.Properties
{
    /// <summary>
    /// PropertiesPageViewModel
    /// Cette classe représente le ViewModel pour la page des propriétés
    /// </summary>
    public class PropertiesPageViewModel : INotifyPropertyChanged
    {
        private IEnumerable<Data.Entities.Property> _allProperties;

        // Propriétés
        private ObservableCollection<Data.Entities.Property> _properties;
        public ObservableCollection<Data.Entities.Property> Properties
        {
            get => _properties;
            set
            {
                _properties = value;
                OnPropertyChanged();
            }
        }

        // Création des commandes
        public ICommand AddPropertyCommand { get; }
        public ICommand DeletePropertyCommand { get; }
        public ICommand EditPropertyCommand { get; }
        public ICommand DetailsPropertyCommand { get; }

        // Nombre de propriété
        private int _propertyCount;
        public int PropertyCount
        {
            get => _propertyCount;
            set
            {
                _propertyCount = value;
                OnPropertyChanged();
            }
        }

        // Liste des type d'annonce pour filtrer
        public List<string> FilterOptions { get; } = new List<string> { "Tous", "En vente", "En location", "Pas sur le marché" };

        // Filtre séléctionné
        private string _selectedFilter;
        public string SelectedFilter
        {
            get => _selectedFilter;
            set
            {
                if (_selectedFilter != value)
                {
                    _selectedFilter = value;
                    OnPropertyChanged();
                    ApplyFilter();
                }
            }
        }

        public PropertiesPageViewModel()
        {
            // Appel des commandes
            AddPropertyCommand = new Command(AddProperty);
            DeletePropertyCommand = new Command<Data.Entities.Property>(DeleteProperty);
            EditPropertyCommand = new Command<Data.Entities.Property>(EditProperty);
            DetailsPropertyCommand = new Command<Data.Entities.Property>(DetailsProperty);

            SelectedFilter = FilterOptions[0];
            LoadProperties();
        }

        /// <summary>
        /// Charge les propriétés
        /// </summary>
        public void LoadProperties()
        {
            _allProperties = PropertyServices.GetProperties();
            ApplyFilter();
        }

        /// <summary>
        /// Applique le filtrage
        /// </summary>
        private void ApplyFilter()
        {
            if (_allProperties == null) return;

            IEnumerable<Data.Entities.Property> filteredProperties = _allProperties;

            if (SelectedFilter == "En vente")
            {
                filteredProperties = _allProperties.Where(p => p.Listings.Any(l => !l.ListingEndDate.HasValue && l.ListingType != null && l.ListingType.ListingTypeName.Contains("Vente", StringComparison.OrdinalIgnoreCase)));
            }
            else if (SelectedFilter == "En location")
            {
                filteredProperties = _allProperties.Where(p => p.Listings.Any(l => !l.ListingEndDate.HasValue && l.ListingType != null && l.ListingType.ListingTypeName.Contains("Location", StringComparison.OrdinalIgnoreCase)));
            }
            else if (SelectedFilter == "Pas sur le marché")
            {
                filteredProperties = _allProperties.Where(p => !p.Listings.Any(l => !l.ListingEndDate.HasValue));
            }

            Properties = new ObservableCollection<Data.Entities.Property>(filteredProperties);
            PropertyCount = Properties.Count;
        }

        /// <summary>
        /// Redirige vers la page d'ajout d'une propriété
        /// </summary>
        private async void AddProperty()
        {
            await Shell.Current.GoToAsync(nameof(AddPropertyPage));
        }

        /// <summary>
        /// Redirige vers la page de détails d'une propriété
        /// </summary>
        private async void DetailsProperty(Data.Entities.Property property)
        {
            if (property == null) return;
            var navigationParams = new Dictionary<string, object>
            {
                { "PropertyId", property.PropertyId }
            };
            await Shell.Current.GoToAsync(nameof(DetailsPropertyPage), navigationParams);
        }

        /// <summary>
        /// Redirige vers la page d'édition d'une propriété
        /// </summary>
        private async void EditProperty(Data.Entities.Property property)
        {
            if (property == null) return;
            var navigationParams = new Dictionary<string, object>
            {
                { "SelectedProperty", property }
            };
            await Shell.Current.GoToAsync(nameof(EditPropertyPage), navigationParams);
        }

        /// <summary>
        /// Supprime une propriété
        /// </summary>
        private async void DeleteProperty(Data.Entities.Property property)
        {
            if (property == null) return;

            bool confirm = await Shell.Current.DisplayAlert("Confirmation", $"Voulez-vous vraiment supprimer {property.PropertyTitle} ?", "Oui", "Non");

            if (!confirm) return;

            PropertyServices.DeletePropertyById(property.PropertyId);

            LoadProperties();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}