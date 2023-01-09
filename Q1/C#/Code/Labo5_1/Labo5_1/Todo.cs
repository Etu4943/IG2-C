using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5_1
{
    internal class Todo<T> where T : IComparable
    {
        static private readonly int INCREMENT = 5;

        private T[] appels;
        private int nbAppels;

        public Todo()
        {
            appels = new T[INCREMENT];
            nbAppels = 0;
        }

        public bool EstVide()
        {
            return nbAppels == 0;
        }

        public void Ajoute(T appel)
        {
            if(!Contient(appel))
            {
                if (nbAppels >= appels.Length)
                {
                    T[] nvAppels = new T[appels.Length + INCREMENT];
                    for (int i = 0; i < nbAppels; i++)
                    {
                        nvAppels[i] = appels[i];
                    }
                    appels = nvAppels;
                }
                appels[nbAppels] = appel;
                nbAppels++;
            }
            
            
        }

        public T AppelLu()
        {
            T resultat = appels[0];
            int i = 1;
            while(i < nbAppels)
            {
                appels[i - 1] = appels[i];
                i++;
            }
            nbAppels --;
            return resultat;
        }

        public bool Contient(T numeroAAjouter)
        {
            bool estPresent = false;
            foreach(T numero in appels)
            {
                estPresent = numeroAAjouter.CompareTo(numero) == 0;
                if(estPresent)
                    break;
            }
            return estPresent;
        }
    }
}
