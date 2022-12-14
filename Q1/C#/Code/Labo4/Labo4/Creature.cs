using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Creature
    {
        private string nom;
        private int pv;
        private int pvMax;

        public Creature(string nom, int pv, int pvMax)
        {
            this.nom = nom;
            this.pv = pv;
            PvMax = pvMax;
        }

        public Creature(string nom, int pvMax) : this(nom, pvMax, pvMax) { }

        public string Nom
        {
            get { return nom; }
            set 
            {
                if (value == null)
                    nom = "<aucun nom>";
                else
                    nom = value; 
            }
        }

        public int PvMax
        {
            set
            {
                if (value <= 1) pvMax = 1;
                pvMax = value;
            }
        }

        public int Pv
        {
            get { return pv; }
            set 
            { 
                if(pv + value > pvMax) pv = pvMax;
                if (pv + value < 0) pv = 0;
                pv = value; 
            }
        }

        public float PourcentsPV
        {
            get { return (float)(pv)/pvMax; }
        }

        public StringBuilder Etat
        {
            get 
            { 
                StringBuilder output = new StringBuilder();
                output.Append($"{nom} ({pv}/{pvMax} : {(PourcentsPV*100).ToString("F2")}%)");
                output.Append(pv == 0 ? " - MORT" : "");
                return output;
            }
        }
    }
}
