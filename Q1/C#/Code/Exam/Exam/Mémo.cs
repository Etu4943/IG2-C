using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Mémo
    {
        private int identifiant;
        private Employé auteur;
        private DateTime date;
        List<Employé> destinataires;
        HashSet<string> mots_cléfs;
        Dictionary<Langue,string> contenu;

        Console.WriteLine(mémos.Max(m => m.Destinataies.Count()));


    }
}
