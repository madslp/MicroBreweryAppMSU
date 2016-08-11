using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroBreweryLibrary;
using Repositories;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            IBeerRepository beer = new BeerRepository();

            Beer newBeer = new Beer();
            newBeer.Id = 1;
            beer.Add(newBeer);

            //Beer newBeer2 = new Beer();
            //newBeer2.Id = 1;
            //beer.Add(newBeer2);

        }
    }
}
