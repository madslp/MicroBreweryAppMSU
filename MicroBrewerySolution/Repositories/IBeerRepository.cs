using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroBreweryLibrary;
namespace Repositories
{
    public interface IBeerRepository
    {
        void Add(Beer beer);
        IEnumerable<Beer> GetAll();
    }


}
