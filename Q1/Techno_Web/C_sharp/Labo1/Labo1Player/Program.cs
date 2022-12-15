using System;

namespace Labo1Player
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime annif1 = new DateTime(2001, 03, 17);
            DateTime annif2 = new DateTime(2003, 12, 10);

            Player joueur1 = new Player("Clément", "Potier", annif1, true);
            Player joueur2 = new Player("Nora", "Viandier", annif2);
            Console.WriteLine(joueur2);
        }
    }
}