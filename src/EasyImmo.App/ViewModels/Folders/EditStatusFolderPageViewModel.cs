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
    /// EditStatusFolderPageViewModel
    /// Cette classe représente le ViewModel pour la page d'édition du statut d'un dossier
    /// </summary>
    public class EditStatusFolderPageViewModel : INotifyPropertyChanged
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
                    SelectedStatus = _selectedFolder.FolderCloseDate.HasValue ? "Fermé" : "Ouvert";
                    CloseDate = _selectedFolder.FolderCloseDate ?? DateTime.Today;
                    CloseReason = _selectedFolder.FolderCloseReason ?? string.Empty;
                }
            }
        }

        // Liste des type de statut
        public List<string> StatusOptions { get; } = new List<string> { "Ouvert", "Fermé" };

        // Statut séléctionné
        private string _selectedStatus;
        public string SelectedStatus
        {
            get => _selectedStatus;
            set
            {
                _selectedStatus = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsClosedSelected));
            }
        }

        public bool IsClosedSelected => SelectedStatus == "Fermé";

        // Date de fermeture
        private DateTime _closeDate = DateTime.Today;
        public DateTime CloseDate
        {
            get => _closeDate;
            set
            {
                _closeDate = value;
                OnPropertyChanged();
            }
        }

        // Raison de la fermeture
        private string _closeReason;
        public string CloseReason
        {
            get => _closeReason;
            set
            {
                _closeReason = value;
                OnPropertyChanged();
            }
        }

        // Création de la commande
        public ICommand SaveCommand { get; }


        public EditStatusFolderPageViewModel()
        {
            // Appel des commandes
            SaveCommand = new Command(SaveStatus);
        }

        /// <summary>
        /// Changement du statut
        /// </summary>
        private async void SaveStatus()
        {
            if (SelectedFolder == null) return;

            DateTime? finalCloseDate = null;
            string finalCloseReason = null;

            if (IsClosedSelected)
            {
                finalCloseDate = CloseDate;
                finalCloseReason = string.IsNullOrWhiteSpace(CloseReason) ? "Non spécifiée" : CloseReason;
            }

            FolderServices.UpdateFolderStatus(SelectedFolder.FolderId, finalCloseDate, finalCloseReason);

            await Shell.Current.GoToAsync("..");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}