// See https://aka.ms/new-console-template for more information

namespace Labo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Emission e1 = new Emission("Koh-Lanta", 120);
            Emission e2 = new Emission("Star Ac'", 50);
            Film f1 = new Film("Air force One", 130, "Action");
            Film f2 = new Film("High School Musical", 100, "Comédie Romantique");
            EpisodeSerie s1 = new EpisodeSerie("DNA", 40, "Le jour de demain", 154);
            EpisodeSerie s2 = new EpisodeSerie("ITC", 40, "Va dormir", 620);


            Test();
        }

        static void Test()
        {
            Emission e1 = new Emission("Motus", 50);
            Emission e2 = new Emission("Des chiffres et des lettres", 45);
            Film f1 = new Film("Bilbo the Hobbit", 182, "fantastique");
            Film f2 = new Film("Le bon, la brute et le truand", 178, "western");
            EpisodeSerie s1 = new EpisodeSerie("Monsters", 47, "The Walking Dead", 801);
            EpisodeSerie s2 = new EpisodeSerie("The Interrogation", 52, "Designated Survivor", 6);
            DessinAnime da1 = new DessinAnime("Simprovised", 24, "Simpsons", 2721,16);
            DessinAnime da2 = new DessinAnime("Droids in Distress", 22, "Star Wars Rebels", 3, 8);
            UtilTV.AfficherProgramme(e1, e2, e2, f1, f2, s1, s2, da1, da2);
            /*string[] expected = { "Motus (50 minutes)", "Des chiffres et des lettres (45 minutes)", "Bilbo the Hobbit (182 minutes), fantastique", "Le bon, la brute et le truand (178 minutes), western", "The Walking Dead : Monsters (47 minutes)", "Designated Survivor : The Interrogation (52 minutes)", "Simpsons : Simprovised (24 minutes)", "Star Wars Rebels : Droids in Distress (22 minutes)" };
            Check(expected[0],e1);
            Check(expected[1],e2);
            Check(expected[2],f1);
            Check(expected[3],f2);
            Check(expected[4],s1);
            Check(expected[5],s2);
            Check(expected[6],da1);
            Check(expected[7],da2);*/

            Console.WriteLine("....");
            UtilTV.PresentationDA(da1, da2);
        }

        static void Check(string expected, Emission e)
        {
            UtilTV.AfficherProgramme(e);
            if (e.Presentation() == expected)
                Console.WriteLine("OK !");
            else
                Console.WriteLine("PROBLEM !");
        }
    }
}
