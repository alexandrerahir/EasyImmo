using EasyImmo.Business.Services;
using EasyImmo.Data.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace EasyImmo.App.ViewModels.Folders
{
    // Récupération du dossier séléctionné
    [QueryProperty(nameof(SelectedFolder), "SelectedFolder")]

    /// <summary>
    /// AddStepFolderPageViewModel
    /// Cette classe représente le ViewModel pour la page d'ajout d'étape d'un dossier
    /// </summary>
    public class AddStepFolderPageViewModel : INotifyPropertyChanged
    {
        
        // Dossier séléctionné
        private Folder _selectedFolder;
        public Folder SelectedFolder
        {
            get => _selectedFolder;
            set
            {
                _selectedFolder = value;
                OnPropertyChanged();
            }
        }

        // Liste des types d'étapes
        private ObservableCollection<StepType> _stepTypes;
        public ObservableCollection<StepType> StepTypes
        {
            get => _stepTypes;
            set
            {
                _stepTypes = value;
                OnPropertyChanged();
            }
        }

        // Type d'étape sélectionné
        private StepType _selectedStepType;
        public StepType SelectedStepType
        {
            get => _selectedStepType;
            set
            {
                _selectedStepType = value;
                OnPropertyChanged();
            }
        }

        // Date de l'étape
        private DateTime _stepDate = DateTime.Today;
        public DateTime StepDate
        {
            get => _stepDate;
            set
            {
                _stepDate = value;
                OnPropertyChanged();
            }
        }

        // Note de l'étape
        private string _stepNote;
        public string StepNote
        {
            get => _stepNote;
            set
            {
                _stepNote = value;
                OnPropertyChanged();
            }
        }

        // Création des commandes
        public ICommand AddStepCommand { get; }

        public AddStepFolderPageViewModel()
        {
            LoadStepTypes();

            // Appel des commandes
            AddStepCommand = new Command(AddStep);
        }

        /// <summary>
        /// Charge la liste des types d'étape
        /// </summary>
        private void LoadStepTypes()
        {
            var types = FolderServices.GetStepTypes();
            StepTypes = new ObservableCollection<StepType>(types);

            if (StepTypes.Any())
            {
                SelectedStepType = StepTypes.First();
            }
        }

        /// <summary>
        /// Ajoute une étape au dossier séléctionné
        /// </summary>
        private async void AddStep()
        {
            // Verification si le dossier et le type est null
            if (SelectedFolder == null || SelectedStepType == null)
            {
                await Shell.Current.DisplayAlert("Erreur", "Veuillez sélectionner un type d'étape.", "OK");
                return;
            }

            // Ajout de l'étape
            FolderServices.AddFolderStep(
                SelectedFolder.FolderId,
                SelectedStepType.StepTypeId,
                StepDate,
                StepNote
            );

            await Shell.Current.GoToAsync("..");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}