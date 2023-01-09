using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Des tableaux
            int[] nombres = { 7, 9, 13, 16, 21, 22, 29, 36, 44, 47, 51, 55, 64, 71, 77, 81, 99 };
            char[] voyelles = { 'a', 'e', 'i', 'o', 'u', 'y' };
            // Une collection simple via List
            List<string> prénoms = new List<string>();
            string[] prénomsTmp = { "Anatole", "Bergamote", "Cunégonde", "Doriphore","Fernande", "Gustave", "Hermione", "Isidore", "Mathilde", "Ophélie","Quasimodo", "Raistlin", "Wilfred", "Zénobe" };
            foreach (string prénom in prénomsTmp)
                prénoms.Add(prénom);
            // Un tableau associatif via Dictionary
            Dictionary<int, List<string>> dico = new Dictionary<int, List<string>>();
            string[] nombresFr = { "un", "deux", "trois", "quatre", "cinq", "six","sept", "huit", "neuf", "dix" };
            string[] nombresEn = { "one", "two", "three", "four", "five", "six","seven", "eight", "nine", "ten" };
            for (int i = 1; i < 10; i++)
            {
                dico[i] = new List<string>();
                dico[i].Add(nombresFr[i - 1]);
                dico[i].Add(nombresEn[i - 1]);
            }

            int longueur = 6;
            IEnumerable<string> prénoms6Lettres = prénoms.Where(value => value.Length == longueur);
            Console.WriteLine(Affichage(prénoms6Lettres));
            prénoms.Remove("Zénobe");
            Console.WriteLine(Affichage(prénoms6Lettres));
            prénoms.Add("Jordan");
            prénoms.Add("Zébulon");
            prénoms.Add("Agatha");
            Console.WriteLine(Affichage(prénoms6Lettres));
            longueur = 7;
            Console.WriteLine(Affichage(prénoms6Lettres));
            //Console.WriteLine(Affichage(prénoms));

            //Console.WriteLine(Affichage(prénoms.Where(s => s.Contains("i"))));
            //Console.WriteLine(Affichage(prénoms.Where(s => s.CompareTo("C") == -1 || s.CompareTo("Sharp") == 1)));
            //Console.WriteLine(Affichage(prénoms.Where(s => !s.EndsWith("e"))));
            //Console.WriteLine(Affichage(prénoms.Select(s => s.Substring(1))));
            //IEnumerable<int> nombreAscii = voyelles.Select(lettre => (int)lettre);
            //Console.WriteLine(Affichage(nombres.SkipWhile(x => x%11 != 0)));
            //Console.WriteLine(Affichage(nombres.Select(x => x%10)));
            //Console.WriteLine(Affichage(nombres.Select(x => x%10).Distinct()));
            //Console.WriteLine(Affichage(dico));
            //Console.WriteLine(Affichage(prénoms.Where(x => x.Length == 7)));
            //Console.WriteLine(prénoms.Select(x => x.Length).Sum()/(double)prénoms.Count);
            //Console.WriteLine(prénoms.Where(x => x.Length%2 == 1).Select(x => x.Length).Sum()/(double)prénoms.Count);
            //Console.WriteLine(prénoms.Select(x => x.Length).Max());
            //Console.WriteLine(Affichage(dico.Keys.Where(x => dico[x].Any(x => x.Length == 3))));
            //Console.WriteLine(Affichage(dico.Keys.Where(x => dico[x].First().Length == dico[x].Last().Length)));
            //Console.WriteLine(Affichage(dico.Keys.Select(x => dico[x].Sum( s => s.Length))));
        }

        static string Affichage(IEnumerable<string> valeurs)
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            bool premier = true;
            foreach (string val in valeurs)
            {
                if (!premier)
                    res.Append(", ");
                else
                    premier = false;
                res.Append(val);
            }
            res.Append("]");
            return res.ToString();
        }

        static string Affichage(IEnumerable<int> valeurs)
        {
            IEnumerable<string> nombres = valeurs.Select(val => val.ToString());
            return Affichage(nombres); 
        }

        static string Affichage(Dictionary<int, List<string>> collection)
        {
            List<string> newList = new List<string>();
            
            
            foreach(KeyValuePair<int,List<string>> info in collection)
            {
                StringBuilder output = new StringBuilder();
                output.Append($"{info.Key} ->");
                output.Append($"{Affichage(info.Value)}");
                newList.Add(output.ToString());
            }

            return Affichage(newList);
        }

    }
}
