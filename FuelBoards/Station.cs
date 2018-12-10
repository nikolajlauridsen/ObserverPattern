using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace FuelBoards
{
    public enum Region
    {
        Jylland,
        Fyn,
        Sjælland
    }

    public class Station : Observer
    {
        public readonly Region region;
        public readonly string City;
        private FuelPrices Prices;

        public double KeroOxy { get; private set; }
        public double HydroOxy { get; private set; }
        public double AlcoOxy { get; private set; }

        public bool OnSale = false;



        public Station(FuelPrices prices, Region region, string city)
        {
            this.region = region;
            this.Prices = prices;
            this.City = city;
        }

        public override void Update()
        {
            setPrices();
            Console.WriteLine(String.Format("New prices in: {0}\nKero: {1}\nHydro: {2}\nAlco: {3}\n\n", City, KeroOxy, HydroOxy, AlcoOxy));
        }

        private void setPrices()
        {
            double multiplier = 1;
            if (region == Region.Sjælland) multiplier = 1.05;
            else if (region == Region.Fyn) multiplier = 0.95;

            KeroOxy = Prices.KeroOxy * multiplier;
            HydroOxy = Prices.HydroOxy * multiplier;
            AlcoOxy = Prices.AlcoOxy * multiplier;

            if (OnSale) {
                multiplier = 0.9;
                KeroOxy = KeroOxy * multiplier;
                HydroOxy = HydroOxy * multiplier;
                AlcoOxy = AlcoOxy * multiplier;
            }

        }
    }
}
