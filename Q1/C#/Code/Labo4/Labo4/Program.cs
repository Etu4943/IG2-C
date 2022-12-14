// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

namespace Labo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature c1 = new Creature("Hubert",15);
            Console.WriteLine(c1.Etat);
            c1.Pv = 10;
            Console.WriteLine(c1.Etat);
            Creature c2 = new Creature("Abu", 0,1);
            Console.WriteLine(c2.Etat);
        }

    }
}
