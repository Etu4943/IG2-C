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
            get { return pvMax; }
            set
            {
                if (value <= 1) pvMax = 1;
                pvMax = value;
            }
        }

        public virtual int Pv
        {
            get { return pv; }
            set 
            {
                if (value > pvMax)
                    pv = pvMax;

                else if (value < 0)
                    pv = 0;

                else
                    pv = value; 
            }
        }

        public float PourcentsPV
        {
            get { return (float)(Pv)/PvMax; }
        }

        public StringBuilder Etat
        {
            get 
            { 
                StringBuilder output = new StringBuilder();
                output.Append($"{nom} ({Pv}/{PvMax} : {(PourcentsPV*100).ToString("F2")}%)");
                output.Append(pv == 0 ? " - MORT" : "");
                return output;
            }
        }
    }
}
