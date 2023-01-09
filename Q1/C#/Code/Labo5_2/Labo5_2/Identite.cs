using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5_2
{
    internal class Identite
    {
        public Identite(string prenom, string nom) {
            Prenom = prenom;
            Nom = nom;
        }
        public string Prenom
        {
            get;
            set;
        }
        public string Nom
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"{Nom}, {Prenom}";
        }
    }
}
