using Labo_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo0Player
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime annif1 = new DateTime(2001, 3, 17);
            DateTime annif2 = new DateTime(2003, 12, 10);
            Player joueur1 = new Player("Clément", "Potier", annif1, true);
            Player joueur2 = new Player("Nora", "Viandier", annif2);
            //Console.WriteLine(joueur2.ToString());
            TestMaps();
        }

        public static void AssertMaps(string expected, Player p)
        {
            Console.WriteLine("Expected answer : " + expected);
            Console.WriteLine(p.ListingMaps());
        }

        public static void TestMaps()
        {
            // Mise en place
            Player p = new Player("Indiana", "Jones", new DateTime(1899, 7, 1));
            Map map1 = new Map("Club House", 25, true); // canyon
            Map map2 = new Map("Stade Bravo", 22, 32); // forteresse
            Map map3 = new Map("Villa", 30, 29, false); // foret
            Map map4 = new Map("Café Dot.", 25, 28); // desert
            Map map5 = new Map("Favela", 20, false); // oasis
            Map map6 = new Map("SkyCrapper", 20, 30); // caverne
            // Test
            AssertMaps("aucune", p);
            // Mise en place
            p.AddMap(map1);
            // Test
            AssertMaps("Club House", p);
            // Mise en place
            p.AddMap(map2);
            p.AddMap(map3);
            // Test
            AssertMaps("Villa, Stade Bravo, Club House", p);
            // Mise en place
            p.AddMap(map2);
            // Test
            AssertMaps("Stade Bravo, Villa, Club House", p);
            // Mise en place
            p.AddMap(map4);
            p.AddMap(map5);
            // Test
            AssertMaps("Favela, Café Dot., Stade Bravo, Villa, Club House", p);
            // Mise en place
            p.AddMap(map3);
            // Test
            AssertMaps("Villa, Favela, Café Dot., Stade Bravo, Club House", p);
            // Mise en place
            p.AddMap(map6);
            // Test
            AssertMaps("SkyCrapper, Villa, Favela, Café Dot., Stade Bravo", p);
        }
    }
}