using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Academy EAL = new Academy("EAL");

            Student Nikolaj = new Student(EAL, "Nikolaj");
            Student Kasper = new Student(EAL, "Kasper");
            Student Victor = new Student(EAL, "Victor");

            EAL.Attach(Nikolaj);
            EAL.Attach(Kasper);
            EAL.Attach(Victor);

            EAL.Message = "BAJER PÅ FREDAG GUTTER";
            EAL.Message = "Ignorer sidste besked #jebaited";
            Console.ReadKey(false);
        }
    }
}
