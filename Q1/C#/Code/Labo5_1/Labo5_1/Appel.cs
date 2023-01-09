using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5_1
{
    internal class Appel : IComparable
    {

        public Appel(string nom, string numero)        {
            Nom = nom;
            Numero = numero;

       }
        public string Nom
        {
            get;
            set;
        }
        public string Numero
        {
            get;
            set;
        }

        public int CompareTo(Object o)
        {
            if (o is Appel)
            {
                Appel num = (Appel)o;
                if (num.Numero == this.Numero)
                    return 0;
            }
            return -1;
        }

         public override string ToString()
        {
            return Nom + " (" + Numero + ")";
        }
    }
}
