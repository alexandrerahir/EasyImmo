using EasyImmo.Business.Services;
using EasyImmo.Data.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EasyImmo.App.ViewModels.Properties
{
    // id de la propriété séléctionné
    [QueryProperty(nameof(PropertyId), "PropertyId")]

    /// <summary>
    /// AddListingPageViewModel
    /// Cette classe représente le ViewModel pour la page d'ajout d'une annonce
    /// </summary>
    public class AddListingPageViewModel : INotifyPropertyChanged
    {
        // Id de la propriété
        private int _propertyId;
        public int PropertyId
        {
            get => _propertyId;
            set
            {
                if (_propertyId != value)
                {
                    _propertyId = value;
                    OnPropertyChanged();
                }
            }
        }

        // Liste des types d'annonce
        public ObservableCollection<ListingType> ListingTypes { get; set; }

        // Liste des agents
        public ObservableCollection<Agent> Agents { get; set; }

        // Type d'annonce séléctionné
        private ListingType _selectedListingType;
        public ListingType SelectedListingType
        {
            get => _selectedListingType;
            set { _selectedListingType = value; OnPropertyChanged(); }
        }

        // Agent séléctionné 
        private Agent _selectedAgent;
        public Agent SelectedAgent
        {
            get => _selectedAgent;
            set { _selectedAgent = value; OnPropertyChanged(); }
        }

        // Prix 
        private double _listingPrice;
        public double ListingPrice
        {
            get => _listingPrice;
            set { _listingPrice = value; OnPropertyChanged(); }
        }

        // Frais d'agence
        private double? _agencyFees;
        public double? AgencyFees
        {
            get => _agencyFees;
            set { _agencyFees = value; OnPropertyChanged(); }
        }

        // Frais de notaire
        private double? _notaryFees;
        public double? NotaryFees
        {
            get => _notaryFees;
            set { _notaryFees = value; OnPropertyChanged(); }
        }

        // Charges
        private double? _rentalCharge;
        public double? RentalCharge
        {
            get => _rentalCharge;
            set { _rentalCharge = value; OnPropertyChanged(); }
        }

        // Garantie locative
        private double? _rentalWarranty;
        public double? RentalWarranty
        {
            get => _rentalWarranty;
            set { _rentalWarranty = value; OnPropertyChanged(); }
        }

        // Création des commande
        public ICommand SaveCommand { get; }

        public AddListingPageViewModel()
        {
            ListingTypes = new ObservableCollection<ListingType>(PropertyServices.GetListingTypes());
            Agents = new ObservableCollection<Agent>(PropertyServices.GetAgents());

            SaveCommand = new Command(async () => await SaveListing());
        }

        private async Task SaveListing()
        {
            if (SelectedListingType == null || SelectedAgent == null || ListingPrice <= 0)
            {
                await Shell.Current.DisplayAlert("Erreur", "Veuillez remplir le type d'annonce, l'agent affecté et le prix (supérieur à 0).", "OK");
                return;
            }

            var newListing = new Listing
            {
                PropertyId = this.PropertyId,
                ListingTypeId = SelectedListingType.ListingTypeId,
                AgentId = SelectedAgent.AgentId,
                ListingPrice = this.ListingPrice,
                AgencyFees = this.AgencyFees,
                NotaryFees = this.NotaryFees,
                RentalCharge = this.RentalCharge,
                RentalWarranty = this.RentalWarranty,
                ListingStartDate = DateTime.Now
            };

            PropertyServices.AddListingForProperty(newListing);

            await Shell.Current.GoToAsync("..");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}