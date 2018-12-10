using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject cs;
            ConcreteObserver co1, co2, co3;

            cs = new ConcreteSubject();

            co1 = new ConcreteObserver(cs);
            co2 = new ConcreteObserver(cs);
            co3 = new ConcreteObserver(cs);

            cs.Attach(co1);
            cs.Attach(co2);
            cs.Attach(co3);


            cs.State = 1;
            cs.State = 2;
            cs.State = 100;
            Console.ReadKey();
        }
    }
}
