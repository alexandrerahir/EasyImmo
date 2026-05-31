using EasyImmo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyImmo.Business.Services
{
    public class PropertyServices
    {
        /// <summary>
        /// Récupère toutes les propriétés de la base de données
        /// </summary>
        public static List<Data.Entities.Property> GetProperties()
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.Properties
                        .Include(p => p.PropertyDetails)
                        .Include(p => p.PropertyType)
                        .Include(p => p.Photos)
                        .Include(p => p.Listings)
                            .ThenInclude(l => l.ListingType)
                        .Include(p => p.Address)
                            .ThenInclude(a => a.Street)
                                .ThenInclude(s => s.PostalCode)
                                    .ThenInclude(pc => pc.Municipality)
                                        .ThenInclude(m => m.Province)
                                            .ThenInclude(pr => pr.Region)
                                                .ThenInclude(r => r.Country)
                        .ToList();
            }
        }

        /// <summary>
        /// Récupère une propriété par son id
        /// </summary>
        public static Data.Entities.Property? GetPropertyById(int propertyId)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.Properties
                        .Include(p => p.PropertyDetails)
                        .Include(p => p.PropertyType)
                        .Include(p => p.Photos)
                        .Include(p => p.Person)
                        .Include(p => p.Listings)
                            .ThenInclude(l => l.ListingType)
                        .Include(p => p.Listings)
                            .ThenInclude(l => l.Folders)
                        .Include(p => p.Listings)
                            .ThenInclude(l => l.Agent)
                        .Include(p => p.Address)
                            .ThenInclude(a => a.Street)
                                .ThenInclude(s => s.PostalCode)
                                    .ThenInclude(pc => pc.Municipality)
                                        .ThenInclude(m => m.Province)
                                            .ThenInclude(pr => pr.Region)
                                                .ThenInclude(r => r.Country)
                        .FirstOrDefault(p => p.PropertyId == propertyId);
            }
        }

        /// <summary>
        /// Récupère tous les types de propriété
        /// </summary>
        public static List<Data.Entities.PropertyType> GetPropertyTypes()
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.PropertyTypes.ToList();
            }
        }

        /// <summary>
        /// Ajoute une nouvelle propriété à la base de données
        /// </summary>
        public static void AddProperty(Property newProperty)
        {
            using (var entities = new EasyImmoContext())
            {
                entities.Properties.Add(newProperty);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Met à jour les informations d'une propriété dans la base de données
        /// </summary>
        public static void UpdateProperty(Data.Entities.Property updatedProperty)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                
                var existingProperty = entities.Properties
                    .Include(p => p.PropertyDetails)
                    .FirstOrDefault(p => p.PropertyId == updatedProperty.PropertyId);

                if (existingProperty != null)
                {
                    existingProperty.PropertyTitle = updatedProperty.PropertyTitle;
                    existingProperty.PropertyDescription = updatedProperty.PropertyDescription;
                    existingProperty.PropertyTypeId = updatedProperty.PropertyTypeId;
                    existingProperty.PersonId = updatedProperty.PersonId;

                    var existingDetail = existingProperty.PropertyDetails.FirstOrDefault();
                    var updatedDetail = updatedProperty.PropertyDetails?.FirstOrDefault();

                    if (existingDetail != null && updatedDetail != null)
                    {
                        existingDetail.LivingArea = updatedDetail.LivingArea;
                        existingDetail.LandArea = updatedDetail.LandArea;
                        existingDetail.TotalSurfaceArea = updatedDetail.TotalSurfaceArea;
                        existingDetail.ToiletCount = updatedDetail.ToiletCount;
                        existingDetail.BedroomCount = updatedDetail.BedroomCount;
                        existingDetail.BathroomCount = updatedDetail.BathroomCount;
                        existingDetail.TotalRoomCount = updatedDetail.TotalRoomCount;
                        existingDetail.EnergyClass = updatedDetail.EnergyClass;
                        existingDetail.EnergyConsumption = updatedDetail.EnergyConsumption;
                        existingDetail.HeatingType = updatedDetail.HeatingType;
                        existingDetail.ConstructionYear = updatedDetail.ConstructionYear;
                        existingDetail.Condition = updatedDetail.Condition;
                    }
                    else if (existingDetail == null && updatedDetail != null)
                    {
                        existingProperty.PropertyDetails.Add(updatedDetail);
                    }

                    entities.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Supprime une propriété de la base de données en fonction de son id
        /// </summary>
        public static void DeletePropertyById(int id)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                var property = entities.Properties
                    .Include(p => p.PropertyDetails)
                    .Include(p => p.Photos)
                    .Include(p => p.Listings)
                    .FirstOrDefault(p => p.PropertyId == id);

                if (property != null)
                {
                    if (property.PropertyDetails != null)
                        entities.RemoveRange(property.PropertyDetails);

                    if (property.Photos != null)
                        entities.RemoveRange(property.Photos);

                    if (property.Listings != null)
                        entities.RemoveRange(property.Listings);

                    entities.Properties.Remove(property);
                    entities.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Récupère toutes les annonces liées à une propriété via son Id
        /// </summary>
        public static List<Data.Entities.Listing> GetListingsByPropertyId(int propertyId)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.Listings
                    .Include(l => l.ListingType)
                    .Include(l => l.Agent)
                    .Where(l => l.PropertyId == propertyId)
                    .ToList();
            }
        }

        /// <summary>
        /// Ajoute une nouvelle annonce pour une propriété
        /// </summary>
        public static void AddListingForProperty(Data.Entities.Listing newListing)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                // On s'assure que la nouvelle annonce a bien la date de création
                if (newListing.ListingStartDate == default)
                {
                    newListing.ListingStartDate = DateTime.Now;
                }

                entities.Listings.Add(newListing);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Récupère tous les types d'annonces (ex: Vente, Location)
        /// </summary>
        public static List<Data.Entities.ListingType> GetListingTypes()
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.ListingTypes.ToList();
            }
        }

        /// <summary>
        /// Récupère tous les agents immobiliers disponibles
        /// </summary>
        public static List<Data.Entities.Agent> GetAgents()
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.Agents.ToList();
            }
        }

    }
}
