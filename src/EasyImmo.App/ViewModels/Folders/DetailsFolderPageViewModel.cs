using EasyImmo.App.Views.Folders;
using EasyImmo.Business.Services;
using EasyImmo.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EasyImmo.App.ViewModels.Folders
{
    // Récupération du dossier séléctionné
    [QueryProperty(nameof(SelectedFolder), "SelectedFolder")]

    /// <summary>
    /// DetailsFolderPageViewModel
    /// Cette classe représente le ViewModel pour la page de détails d'un dossier
    /// </summary>
    public class DetailsFolderPageViewModel : INotifyPropertyChanged
    {
        // Dossier séléctionné
        private Folder _selectedFolder;
        public Folder SelectedFolder
        {
            get => _selectedFolder;
            set
            {
                _selectedFolder = value;
                if (_selectedFolder != null)
                {
                    LoadFullFolderDetails(_selectedFolder.FolderId);
                }
            }
        }

        // Détails du dossier
        private Folder _folderDetails;
        public Folder FolderDetails
        {
            get => _folderDetails;
            set
            {
                _folderDetails = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Status));
                OnPropertyChanged(nameof(IsClosed));
            }
        }

        // Récupération du status du dossier
        public string Status => FolderDetails?.FolderCloseDate.HasValue == true ? "Fermé" : "Ouvert";
        public bool IsClosed => FolderDetails?.FolderCloseDate.HasValue == true;

        // Création des commandes
        public ICommand EditStatusCommand { get; }
        public ICommand AddStepCommand { get; }

        public DetailsFolderPageViewModel()
        {
            // Appel des commandes
            EditStatusCommand = new Command(EditStatus);
            AddStepCommand = new Command(AddStep);
        }

        /// <summary>
        /// Charge les détails du dossier
        /// </summary>
        private void LoadFullFolderDetails(int folderId)
        {
            FolderDetails = FolderServices.GetFolderById(folderId);
        }

        /// <summary>
        /// Modifie le statut du dossier
        /// </summary>
        private async void EditStatus()
        {
            if (FolderDetails == null) return;

            var navigationParameter = new Dictionary<string, object>
            {
                { "SelectedFolder", FolderDetails }
            };

            await Shell.Current.GoToAsync(nameof(EditStatusFolderPage), navigationParameter);
        }

        /// <summary>
        /// Ajoute une étape au dossier
        /// </summary>
        private async void AddStep()
        {
            if (FolderDetails == null) return;

            var navigationParameter = new Dictionary<string, object>
            {
                { "SelectedFolder", FolderDetails }
            };

            await Shell.Current.GoToAsync(nameof(AddStepFolderPage), navigationParameter);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}