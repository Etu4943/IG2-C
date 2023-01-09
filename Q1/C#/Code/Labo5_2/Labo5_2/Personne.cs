using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5_2
{
    internal class Personne
    {
        private Identite identite;
        public Personne(int age, Identite identite)
        {
            Age = age;
            this.identite= identite;
        }

        public int Age
        {
            get;
            set;
        }

        public Identite getIdentite()
        {
            return identite;
        }

        public override string ToString()
        {
            return $"{identite} ({Age})";
        }
    }
}
