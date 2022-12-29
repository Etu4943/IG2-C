using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Formation
    {
        private static int NB_MAX_SEATS = 25;
        private int prix;
        private string wording;
        private string code;
        private Registered[] tabRegistered;
        private int nbRegistered;
        private bool isSponsoredRW;

        public Formation(string wording, string code, int prix)
        {
            this.wording = wording;
            this.code = code;
            Prix = prix;
            tabRegistered = new Registered[NB_MAX_SEATS];
            isSponsoredRW = true;
            nbRegistered = 0;
        }
        public int Prix{
            get { return prix; }
            set
            {
                if (value < 100)
                    prix = 100;
                else
                    prix = value;
            }
        }

        public bool IsSponsoredRW
        {
            get
            {
                return isSponsoredRW;
            }
        }

        public string Code
        {
            get
            {
                return code;
            }
        }

        public int SeatLeft
        {
            get
            {
                return tabRegistered.Count(x => x != null);
            }
        }

        public void AddRegistered(Registered registered)
        {
            tabRegistered[nbRegistered] = registered;
            nbRegistered++;
        }

        public string Informations()
        {
            StringBuilder output = new StringBuilder();
            output.Append($"{code} - {wording}");
            if (isSponsoredRW)
                output.Append(" (RW)");

            return output.ToString();
        }

        public override string ToString()
        {
            return ($"{Informations()} [{tabRegistered.Count(x => x != null)} inscrit(s)]");
        }
    }
}
