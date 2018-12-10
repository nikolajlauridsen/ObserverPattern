using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelBoards
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelPrices priceManager = new FuelPrices();

            Station fredericia = new Station(priceManager, Region.Jylland, "Fredericia");
            Station odense = new Station(priceManager, Region.Fyn, "Odense");
            Station kbh = new Station(priceManager, Region.Sjælland, "København");
            Station tinge = new Station(priceManager, Region.Jylland, "Tinge");

            priceManager.Attach(fredericia);
            priceManager.Attach(odense);
            priceManager.Attach(kbh);
            priceManager.Attach(tinge);

            priceManager.KeroOxy = 10;
            Console.WriteLine("________________________________________________________________________________________");
            fredericia.OnSale = true;
            priceManager.KeroOxy = 10;
            Console.WriteLine("________________________________________________________________________________________");
            fredericia.OnSale = false;
            priceManager.KeroOxy = 20;

            Console.ReadKey(false);
        }
    }
}
