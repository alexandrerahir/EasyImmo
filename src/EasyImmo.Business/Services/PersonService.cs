using EasyImmo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyImmo.Business.Services
{
    public class PersonService
    {
        /// <summary>
        /// Récupère la liste de toutes les personnes
        /// </summary>
        public static List<Data.Entities.Person> GetPeople()
        {
            using (var entities = new Data.Entities.EasyImmoContext())
            {
                return entities.People.ToList();
            }
        }
    }
}
