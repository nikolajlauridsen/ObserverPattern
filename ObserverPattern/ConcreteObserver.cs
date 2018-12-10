using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject ConcreteSubject;
        public int State;

        public ConcreteObserver(ConcreteSubject subject)
        {
            ConcreteSubject = subject;
        }

        public override void Update()
        {
            this.State = ConcreteSubject.State;
            Console.WriteLine("State recieved: " + this.State);
        }
    }
}
