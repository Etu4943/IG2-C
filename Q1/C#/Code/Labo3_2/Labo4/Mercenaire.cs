using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Mercenaire : PNJ, ICompagnon
    {
        public Mercenaire(string nom, int pvMax) : base(nom, pvMax, "alliés") { }

        int ICompagnon.PrixAchat
        {
            get
            {
                return PvMax * 7;
            }
        }
        int ICompagnon.CoutQuotidien
        {
            get
            {
                if (PvMax <= 5)
                    return 25;
                return 35 + (PvMax > 15 ? (2 * (PvMax - 15)) : 0);    
            }
        }

    }
}
