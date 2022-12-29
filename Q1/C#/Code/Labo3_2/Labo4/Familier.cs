using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Familier : PNJ, ICompagnon
    {
        int prix;

        public Familier(string nom, string description, int prix) : base(nom,1, "alliés")
        {
            Description = description;
            Prix = prix;
        }

        public string Description { get; set; }
        public int Prix
        {
            get 
            { 
                return prix; 
            }
            set
            {
                if (value >= 0)
                    prix = value;
                    
            }
        }

        int ICompagnon.PrixAchat 
        { 
            get 
            {
                return Prix;
            } 
        }

        int ICompagnon.CoutQuotidien
        {
            get
            {
                return 1;
            }
        }

        public override int Pv
        {
            get { return 1; }
        }
    }
}
