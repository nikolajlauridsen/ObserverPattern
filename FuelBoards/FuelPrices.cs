using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace FuelBoards
{
    public class FuelPrices : Subject
    {
        public double HydroOxy { get; private set; }
        private double keroOxy;
        public double AlcoOxy { get; private set; }

        public double KeroOxy {
            get {
                return keroOxy;
            }

            set {
                keroOxy = value;
                HydroOxy = keroOxy * 1.1;
                AlcoOxy = keroOxy * 0.9;
                Notify();
            }
        }
    }
}
