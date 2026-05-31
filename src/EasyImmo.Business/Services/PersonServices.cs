using EasyImmo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyImmo.Business.Services
{
    public class PersonServices
    {

        /// <summary>
        /// Récupère toutes les personnes de la base de données
        /// </summary>
        public static List<Data.Entities.Person> GetPeople()
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.People.ToList();
            }
        }

        /// <summary>
        /// Récupère une personne par son id
        /// </summary>
        public static Data.Entities.Person? GetPersonById(int id)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.People
                    // Adresse de la personne
                    .Include(p => p.Address)
                        .ThenInclude(a => a.Street)
                            .ThenInclude(s => s.PostalCode)
                                .ThenInclude(pc => pc.Municipality)
                                    .ThenInclude(m => m.Province)
                                        .ThenInclude(prov => prov.Region)
                                            .ThenInclude(r => r.Country)

                    // Les dossiers de la personne
                    .Include(p => p.Folders)

                    // Les propriétés et leurs détails de la personne
                    .Include(p => p.Properties)
                        .ThenInclude(prop => prop.PropertyDetails)

                    // Les adresses des propriétés de la personne
                    .Include(p => p.Properties)
                        .ThenInclude(prop => prop.Address)
                            .ThenInclude(a => a.Street)
                                .ThenInclude(s => s.PostalCode)
                                    .ThenInclude(pc => pc.Municipality)
                                        .ThenInclude(m => m.Province)
                                            .ThenInclude(prov => prov.Region)
                                                .ThenInclude(r => r.Country)

                    .FirstOrDefault(p => p.PersonId == id);
            }
        }

        /// <summary>
        /// Ajoute une nouvelle personne à la base de données
        /// </summary>
        public static void AddPerson(Data.Entities.Person newPerson)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                entities.People.Add(newPerson);
                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Met à jour les informations d'une personne dans la base de données
        /// </summary>
        public static void UpdatePerson(Data.Entities.Person updatedPerson)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                var person = entities.People.FirstOrDefault(p => p.PersonId == updatedPerson.PersonId);
                if (person != null)
                {
                    person.FirstNamePerson = updatedPerson.FirstNamePerson;
                    person.LastNamePerson = updatedPerson.LastNamePerson;
                    person.EmailPerson = updatedPerson.EmailPerson;
                    person.PhonePerson = updatedPerson.PhonePerson;
                    entities.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Supprime une personne de la base de données en fonction de son id
        /// </summary>
        public static void DeletePersonById(int id)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                var person = entities.People.FirstOrDefault(p => p.PersonId == id);
                if (person != null)
                {
                    entities.People.Remove(person);
                    entities.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Liste tout les biens d'une personne en fonction de son id
        /// </summary>
        public static List<Property> GetPropertiesByPersonId(int personId)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.Properties.Where(p => p.PersonId == personId).ToList();
            }
        }

        /// <summary>
        /// Lister tout les dossiers d'une personne
        /// </summary>
        public static List<Folder> GetFoldersByPersonId(int personId)
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.Folders.Where(f => f.PersonId == personId).ToList();
            }
        }

    }
}
