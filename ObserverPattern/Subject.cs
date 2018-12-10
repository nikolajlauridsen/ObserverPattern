using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Subject
    {
        protected List<Observer> observers = new List<Observer>();

        public virtual void Attach(Observer o)
        {
            observers.Add(o);
        }

        public virtual void Detach(Observer o)
        {
            observers.Remove(o);
        }

        public virtual void Notify()
        {
            foreach(Observer o in observers) {
                o.Update();
            }
        }
    }
}
