using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroBreweryLibrary;
namespace Repositories
{
    public interface IMicroBreweryRepository
    {

        void Add(MicroBrewery microBrewery);
        void RegisterBeer(MicroBrewery microBrewery, Beer beer);
        IEnumerable<MicroBrewery> GetAll();
    }
}
