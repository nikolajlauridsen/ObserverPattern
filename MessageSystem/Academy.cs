using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace MessageSystem
{
    public class Academy : Subject
    {
        public readonly string Name;

        private string message;
        public string Message {
            get {
                return message;
            }
            set {
                message = value;
                Notify();
            }
        }

        public Academy(string name)
        {
            this.Name = name;
        }
    }
}
