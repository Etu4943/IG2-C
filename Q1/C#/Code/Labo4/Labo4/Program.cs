using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Formation f1 = new Formation("Formation sur le bien-être", "EJWZG13", 100);
            Formation f2 = new Formation("Matriser le Javascript", "VGYEDE", 100);

            Institution i1 = new Institution("Duplex", 7550);
            Institution i2 = new Institution("Henallux", 5050);

            Unemployed u1 = new Unemployed("Richard Dumont", 1350, f1, 456);

            Worker w1 = new Worker("Clément Potier", 1330, f1, "Employee",i1);
            w1.AddFormation(f2);
            Worker w2 = new Worker("Serge Dupond", 4230, f2, "Employee");

            Teacher t1 = new Teacher("Clément Potier", 1750, f2, "Teacher", i2, "Javascript");


            Console.WriteLine(t1.FicheInformation());
 
        }

    }
}
