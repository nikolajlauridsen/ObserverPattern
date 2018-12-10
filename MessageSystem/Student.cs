using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace MessageSystem
{
    class Student : Observer
    {
        public readonly string Name;
        public string Message;
        private Academy subject;

        public Student(Academy subject, string name)
        {
            Name = name;
            this.subject = subject; 
        }

        public override void Update()
        {
            this.Message = subject.Message;
            Console.WriteLine(String.Format("Sturende {0} modtog nyheden {1} fra akadamiet {2}", this.Name, this.Message, subject.Name));
        }
    }
}
