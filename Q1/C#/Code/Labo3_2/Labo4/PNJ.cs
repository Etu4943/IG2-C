using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class PNJ : Creature
    {
        
        public PNJ(string nom, int pv, string faction):base(nom, pv, pv)
        {
            Faction = faction;
        }
        public PNJ(string nom, string faction) : this(nom, 0, faction) { }
        public string Faction
        {
            get;
            set;
        }
    }
}
