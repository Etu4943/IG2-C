using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5_2
{
    internal class Informateur : Personne
    {
        private HashSet<string> domaines;
        public Informateur(Identite identite, int age):base(age, identite) 
        {
            domaines = new HashSet<string>();
        }

        public void AjouteDomaine(string domaine)
        {
            domaines.Add(domaine.ToLower());
        }

        public bool ConnaitDomaine(string domaine)
        {
            return domaines.Contains(domaine.ToLower());
        }

        public StringBuilder AfficheDomaines()
        {
            StringBuilder output = new StringBuilder();
            foreach(string domaine in domaines)
            {
                output.Append(domaine + "\n");
            }
            return output;
        }
    }
}
