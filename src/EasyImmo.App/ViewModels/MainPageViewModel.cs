using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using EasyImmo.Business.Services;
using EasyImmo.Data.Entities;

namespace EasyImmo.App.ViewModels
{
    /// <summary>
    /// MainPageViewModel
    /// Cette classe représente le ViewModel pour la page d'accueil de l'application
    /// </summary>
    public class MainPageViewModel : INotifyPropertyChanged
    {
        // Nombre de propriété
        private int _propertiesCount;
        public int PropertiesCount
        {
            get => _propertiesCount;
            set { _propertiesCount = value; OnPropertyChanged(); }
        }

        // Nombre de personne
        private int _peopleCount;
        public int PeopleCount
        {
            get => _peopleCount;
            set { _peopleCount = value; OnPropertyChanged(); }
        }

        // Nombre de dossier
        private int _foldersCount;
        public int FoldersCount
        {
            get => _foldersCount;
            set { _foldersCount = value; OnPropertyChanged(); }
        }

        public MainPageViewModel()
        {
            LoadData();
        }

        /// <summary>
        /// Charge les données
        /// </summary>
        public void LoadData()
        {
            // Récupération des propriétés
            var properties = PropertyServices.GetProperties();
            PropertiesCount = properties.Count;

            // Récupération des personnes
            var people = PersonServices.GetPeople();
            PeopleCount = people.Count;

            // Récupération des dossiers
            var folders = FolderServices.GetFolders();
            FoldersCount = folders.Count;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}