using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroBreweryLibrary;
namespace Repositories
{
    public interface IBeerRatingRepository
    {
        void Add(BeerRating beerRating, Beer beer);
        double GetAverageBeerRating(Beer beer);

    }
    public interface IMicroBreweryRatingRepository
    {
        void Add(MicroBreweryRating microBreweryRating, MicroBrewery microBrewery);
        double GetAverageBeerRating(MicroBrewery microBrewery);

    }
}
