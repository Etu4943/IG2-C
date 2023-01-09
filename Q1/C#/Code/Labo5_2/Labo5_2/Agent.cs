using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Labo5_2
{
    internal class Agent : Personne
    {
        private HashSet<Informateur> informateurs;

        public Agent(Identite identite, int age):base(age,identite) 
        { 
            informateurs= new HashSet<Informateur>();
        }

        public void AjouteInformateur(Informateur informateur)
        {
            informateurs.Add(informateur);
        }

        public bool ConnaitInformateur(Informateur informateur)
        {
            return informateurs.Contains(informateur);
        }

        public override string ToString()
        {
            return $"{getIdentite()} ({Age})"; // Ameliorer
        }


    }
}
