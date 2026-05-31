using EasyImmo.Business.Services;
using EasyImmo.Data.Entities;
using EasyImmo.App.Views.Folders;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace EasyImmo.App.ViewModels.Folders
{

    /// <summary>
    /// FolderItemViewModel
    /// </summary>
    public class FolderItemViewModel
    {
        public Folder Folder { get; }

        public string PersonFullName => Folder.Person != null
            ? $"{Folder.Person.FirstNamePerson} {Folder.Person.LastNamePerson}"
            : "Inconnu";

        // Détermine si le dossier est fermé ou ouvert
        public string Status => Folder.FolderCloseDate.HasValue ? "Fermé" : "Ouvert";

        public FolderItemViewModel(Folder folder)
        {
            Folder = folder;
        }
    }

    /// <summary>
    /// FoldersPageViewModel
    /// Cette classe représente le ViewModel pour la page des dossiers
    /// </summary>
    public class FoldersPageViewModel : INotifyPropertyChanged
    {
        private IEnumerable<FolderItemViewModel> _allFolders;

        // Création des commandes
        public ICommand DetailsFolderCommand { get; }
        public ICommand DeleteFolderCommand { get; }

        // Liste des dossiers
        private ObservableCollection<FolderItemViewModel> _folders;
        public ObservableCollection<FolderItemViewModel> Folders
        {
            get => _folders;
            set
            {
                _folders = value;
                OnPropertyChanged();
            }
        }

        // Options de filtrage
        public List<string> FilterOptions { get; } = new List<string> { "Tous", "Ouverts", "Fermés" };

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

        public FoldersPageViewModel()
        {
            // Appel des commandes
            DetailsFolderCommand = new Command<FolderItemViewModel>(DetailsFolder);
            DeleteFolderCommand = new Command<FolderItemViewModel>(DeleteFolder);

            // Charge les dossiers
            LoadFolders();

            // Option tous séléctionné par défaut
            SelectedFilter = FilterOptions[0];
        }

        /// <summary>
        /// Charge la liste des dossiers
        /// </summary>
        public void LoadFolders()
        {
            var folders = FolderServices.GetFolders();

            _allFolders = folders
                .OrderBy(f => f.FolderCloseDate.HasValue)
                .Select(f => new FolderItemViewModel(f))
                .ToList();

            ApplyFilter();
        }

        /// <summary>
        /// Navigation vers la page détails d'un dossier
        /// </summary>
        private async void DetailsFolder(FolderItemViewModel item)
        {
            if (item?.Folder == null) return;

            var navigationParameter = new Dictionary<string, object>
            {
                { "SelectedFolder", item.Folder }
            };

            await Shell.Current.GoToAsync(nameof(DetailsFolderPage), navigationParameter);
        }

        /// <summary>
        /// Supprimer un dossier
        /// </summary>
        private async void DeleteFolder(FolderItemViewModel item)
        {
            if (item?.Folder == null) return;

            bool isConfirmed = await Application.Current.MainPage.DisplayAlert(
                "Confirmer la suppression",
                $"Êtes-vous sûr de vouloir supprimer le dossier numéro {item.Folder.FolderId} ?",
                "Oui",
                "Non");

            if (isConfirmed)
            {
                FolderServices.DeleteFolder(item.Folder.FolderId);
                LoadFolders();
            }
        }

        /// <summary>
        /// Filtrer les dossier en fonction de leurs statut
        /// </summary>
        private void ApplyFilter()
        {
            if (_allFolders == null) return;

            IEnumerable<FolderItemViewModel> filteredFolders = _allFolders;

            if (SelectedFilter == "Ouverts")
            {
                filteredFolders = _allFolders.Where(f => !f.Folder.FolderCloseDate.HasValue);
            }
            else if (SelectedFilter == "Fermés")
            {
                filteredFolders = _allFolders.Where(f => f.Folder.FolderCloseDate.HasValue);
            }

            Folders = new ObservableCollection<FolderItemViewModel>(filteredFolders);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}