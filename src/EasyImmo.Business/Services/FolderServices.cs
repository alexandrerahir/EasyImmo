using EasyImmo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyImmo.Business.Services
{
    public class FolderServices
    {
        /// <summary>
        /// Récupère toutes les personnes de la base de données
        /// </summary>
        public static List<Data.Entities.Folder> GetFolders()
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.Folders
                       .Include(f => f.Person)
                       .ToList();
            }
        }

        /// <summary>
        /// Récupère un dossier spécifique par son identifiant 
        /// </summary>
        public static Data.Entities.Folder? GetFolderById(int folderId)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.Folders
                       .Include(f => f.Person)
                       .Include(f => f.FolderSteps)
                            .ThenInclude(fs => fs.StepType)
                       .Include(f => f.Listing)
                           .ThenInclude(l => l.Property)
                       .Include(f => f.Listing)
                           .ThenInclude(l => l.ListingType)
                       .Include(f => f.Listing)
                           .ThenInclude(l => l.Agent)
                       .FirstOrDefault(f => f.FolderId == folderId);
            }
        }

        /// <summary>
        /// Supprime un dossier spécifique par son identifiant
        /// </summary>
        public static void DeleteFolder(int folderId)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                var folder = entities.Folders.FirstOrDefault(f => f.FolderId == folderId);

                if (folder != null)
                {
                    entities.Folders.Remove(folder);
                    entities.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Met à jour le statut d'un dossier
        /// </summary>
        public static void UpdateFolderStatus(int folderId, DateTime? closeDate, string? closeReason)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                var folder = entities.Folders.FirstOrDefault(f => f.FolderId == folderId);

                folder.FolderCloseDate = closeDate;
                folder.FolderCloseReason = closeReason;

                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Ajoute une nouvelle étape à un dossier
        /// </summary>
        public static void AddFolderStep(int folderId, int stepTypeId, DateTime stepDate, string note)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                var newStep = new FolderStep
                {
                    FolderId = folderId,
                    StepTypeId = stepTypeId,
                    FolderStepDate = stepDate,
                    FolderStepNote = note
                };

                entities.FolderSteps.Add(newStep);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Récupère la liste de tous les types d'étapes
        /// </summary>
        public static List<StepType> GetStepTypes()
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.StepTypes.ToList();
            }
        }

    }
}
