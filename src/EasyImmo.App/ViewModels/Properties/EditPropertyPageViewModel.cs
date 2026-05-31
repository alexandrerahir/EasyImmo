using EasyImmo.Business.Services;
using EasyImmo.Data.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EasyImmo.App.ViewModels.Properties
{
    // Récupération de la propriété séléctionné
    [QueryProperty(nameof(CurrentProperty), "SelectedProperty")]

    /// <summary>
    /// EditPropertyPageViewModel
    /// Cette classe représente le ViewModel pour la page d'édition d'une propriété
    /// </summary>
    public class EditPropertyPageViewModel : INotifyPropertyChanged
    {
        // Liste des type de propriété
        public ObservableCollection<PropertyType> PropertyTypes { get; set; }

        // Liste des personnes
        public ObservableCollection<PersonDisplayModel> People { get; set; }

        // Propriété séléctionné
        private Property _currentProperty;
        public Property CurrentProperty
        {
            get => _currentProperty;
            set
            {
                _currentProperty = value;
                if (_currentProperty != null)
                {
                    LoadPropertyData();
                }
                OnPropertyChanged();
            }
        }

        // Type de propriété séléctionné
        private PropertyType _selectedPropertyType;
        public PropertyType SelectedPropertyType
        {
            get => _selectedPropertyType;
            set { _selectedPropertyType = value; OnPropertyChanged(); }
        }

        // Personne séléctionné
        private PersonDisplayModel _selectedPerson;
        public PersonDisplayModel SelectedPerson
        {
            get => _selectedPerson;
            set { _selectedPerson = value; OnPropertyChanged(); }
        }

        // Informations générales
        private string _title;
        public string Title { get => _title; set { _title = value; OnPropertyChanged(); } }

        private string _description;
        public string Description { get => _description; set { _description = value; OnPropertyChanged(); } }

        // Adresse 
        private string _streetName;
        public string StreetName { get => _streetName; set { _streetName = value; OnPropertyChanged(); } }

        private string _houseNumber;
        public string HouseNumber { get => _houseNumber; set { _houseNumber = value; OnPropertyChanged(); } }

        private string _boxNumber;
        public string BoxNumber { get => _boxNumber; set { _boxNumber = value; OnPropertyChanged(); } }

        private string _city;
        public string City { get => _city; set { _city = value; OnPropertyChanged(); } }

        private string _postalCode;
        public string PostalCode { get => _postalCode; set { _postalCode = value; OnPropertyChanged(); } }

        private string _provinceName;
        public string ProvinceName { get => _provinceName; set { _provinceName = value; OnPropertyChanged(); } }

        private string _country;
        public string Country { get => _country; set { _country = value; OnPropertyChanged(); } }

        // Surface
        private double? _livingArea;
        public double? LivingArea { get => _livingArea; set { _livingArea = value; OnPropertyChanged(); } }

        private double? _landArea;
        public double? LandArea { get => _landArea; set { _landArea = value; OnPropertyChanged(); } }

        private double? _totalSurfaceArea;
        public double? TotalSurfaceArea { get => _totalSurfaceArea; set { _totalSurfaceArea = value; OnPropertyChanged(); } }

        // Pièces
        private int? _toiletCount;
        public int? ToiletCount { get => _toiletCount; set { _toiletCount = value; OnPropertyChanged(); } }

        private int? _bedroomCount;
        public int? BedroomCount { get => _bedroomCount; set { _bedroomCount = value; OnPropertyChanged(); } }

        private int? _bathroomCount;
        public int? BathroomCount { get => _bathroomCount; set { _bathroomCount = value; OnPropertyChanged(); } }

        private int? _totalRoomCount;
        public int? TotalRoomCount { get => _totalRoomCount; set { _totalRoomCount = value; OnPropertyChanged(); } }

        // Energie
        private string _energyClass;
        public string EnergyClass { get => _energyClass; set { _energyClass = value; OnPropertyChanged(); } }

        private double? _energyConsumption;
        public double? EnergyConsumption { get => _energyConsumption; set { _energyConsumption = value; OnPropertyChanged(); } }

        private string _heatingType;
        public string HeatingType { get => _heatingType; set { _heatingType = value; OnPropertyChanged(); } }

        private int? _constructionYear;
        public int? ConstructionYear { get => _constructionYear; set { _constructionYear = value; OnPropertyChanged(); } }

        private string _condition;
        public string Condition { get => _condition; set { _condition = value; OnPropertyChanged(); } }

        // Création de la commande
        public ICommand SaveCommand { get; }

        public EditPropertyPageViewModel()
        {
            PropertyTypes = new ObservableCollection<PropertyType>();
            People = new ObservableCollection<PersonDisplayModel>();

            // Appel de la commande
            SaveCommand = new Command(SaveProperty);

            LoadData();
        }

        /// <summary>
        /// Chargement des données 
        /// </summary>
        private void LoadData()
        {
            foreach (var type in PropertyServices.GetPropertyTypes()) PropertyTypes.Add(type);
            foreach (var person in PersonServices.GetPeople()) People.Add(new PersonDisplayModel { Person = person });
        }

        /// <summary>
        /// Remplissage automatique des champs avec la propriété actuelle
        /// </summary>
        private void LoadPropertyData()
        {
            Title = _currentProperty.PropertyTitle;
            Description = _currentProperty.PropertyDescription;

            SelectedPropertyType = PropertyTypes.FirstOrDefault(t => t.PropertyTypeId == _currentProperty.PropertyTypeId);
            SelectedPerson = People.FirstOrDefault(p => p.Person.PersonId == _currentProperty.PersonId);

            var detail = _currentProperty.PropertyDetails?.FirstOrDefault();
            if (detail != null)
            {
                LivingArea = detail.LivingArea;
                LandArea = detail.LandArea;
                TotalSurfaceArea = detail.TotalSurfaceArea;
                ToiletCount = detail.ToiletCount;
                BedroomCount = detail.BedroomCount;
                BathroomCount = detail.BathroomCount;
                TotalRoomCount = detail.TotalRoomCount;
                EnergyClass = detail.EnergyClass;
                EnergyConsumption = detail.EnergyConsumption;
                HeatingType = detail.HeatingType;
                ConstructionYear = detail.ConstructionYear;
                Condition = detail.Condition;
            }
        }

        /// <summary>
        /// Modification de la propriété
        /// </summary>
        private async void SaveProperty()
        {
            if (SelectedPropertyType == null || SelectedPerson == null || string.IsNullOrWhiteSpace(Title))
            {
                await Shell.Current.DisplayAlert("Attention", "Veuillez remplir tous les champs obligatoires (Titre, Type et Propriétaire).", "OK");
                return;
            }

            _currentProperty.PropertyTitle = Title;
            _currentProperty.PropertyDescription = Description;
            _currentProperty.PropertyTypeId = SelectedPropertyType.PropertyTypeId;
            _currentProperty.PersonId = SelectedPerson.Person.PersonId;

            var detail = _currentProperty.PropertyDetails?.FirstOrDefault();
            if (detail == null)
            {
                detail = new PropertyDetail();
                _currentProperty.PropertyDetails = new List<PropertyDetail> { detail };
            }

            detail.LivingArea = LivingArea;
            detail.LandArea = LandArea;
            detail.TotalSurfaceArea = TotalSurfaceArea;
            detail.ToiletCount = ToiletCount;
            detail.BedroomCount = BedroomCount;
            detail.BathroomCount = BathroomCount;
            detail.TotalRoomCount = TotalRoomCount;
            detail.EnergyClass = EnergyClass;
            detail.EnergyConsumption = EnergyConsumption;
            detail.HeatingType = HeatingType;
            detail.ConstructionYear = ConstructionYear;
            detail.Condition = Condition;

            PropertyServices.UpdateProperty(_currentProperty);

            await Shell.Current.GoToAsync("..");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}