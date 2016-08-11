using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroBreweryLibrary;

namespace Repositories
{
    public class BeerRepository : IBeerRepository
    {
        private MicroBreweryDBEntities dbEntities;

        public BeerRepository()
        {

            dbEntities = new MicroBreweryDBEntities();

        }

        public void Add(Beer beer)
        {
            dbEntities.Beers.Add(beer);
            dbEntities.SaveChanges();

        }

        public IEnumerable<Beer> GetAll()
        {
            return (from beer in dbEntities.Beers
                    select beer).ToList();

        }
    }
}
