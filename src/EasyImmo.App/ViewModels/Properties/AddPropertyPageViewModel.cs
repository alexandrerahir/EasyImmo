using EasyImmo.Business.Services;
using EasyImmo.Data.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EasyImmo.App.ViewModels.Properties
{
    public class PersonDisplayModel
    {
        public Person Person { get; set; }
        public string FullName => $"{Person.FirstNamePerson} {Person.LastNamePerson}";
    }

    /// <summary>
    /// AddPropertyPageViewModel
    /// Cette classe représente le ViewModel pour la page d'ajout d'un propriété
    /// </summary>
    public class AddPropertyPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<PropertyType> PropertyTypes { get; set; }
        public ObservableCollection<PersonDisplayModel> People { get; set; }

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

        // Informations général
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

        // Création des commandes
        public ICommand SaveCommand { get; }

        public AddPropertyPageViewModel()
        {
            PropertyTypes = new ObservableCollection<PropertyType>();
            People = new ObservableCollection<PersonDisplayModel>();

            // Appel des commandes
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
        /// Ajour de la propriété
        /// </summary>
        private async void SaveProperty()
        {
            if (SelectedPropertyType == null || SelectedPerson == null || string.IsNullOrWhiteSpace(Title))
            {
                await Shell.Current.DisplayAlert("Attention", "Veuillez remplir tous les champs (Titre, Description, Type et Propriétaire).", "OK");
                return;
            }

            var newProperty = new Property
            {
                PropertyTitle = Title,
                PropertyDescription = Description,
                PersonId = SelectedPerson.Person.PersonId,
                PropertyTypeId = SelectedPropertyType.PropertyTypeId,
                AddressId = 1,

                PropertyDetails = new List<PropertyDetail>
                {
                    new PropertyDetail
                    {
                        LivingArea = LivingArea,
                        LandArea = LandArea,
                        TotalSurfaceArea = TotalSurfaceArea,
                        ToiletCount = ToiletCount,
                        BedroomCount = BedroomCount,
                        BathroomCount = BathroomCount,
                        TotalRoomCount = TotalRoomCount,
                        EnergyClass = EnergyClass,
                        EnergyConsumption = EnergyConsumption,
                        HeatingType = HeatingType,
                        ConstructionYear = ConstructionYear,
                        Condition = Condition
                    }
                },

            };

            PropertyServices.AddProperty(newProperty);

            await Shell.Current.GoToAsync("..");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}