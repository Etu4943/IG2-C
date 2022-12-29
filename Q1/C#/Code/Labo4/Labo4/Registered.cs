using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal abstract class Registered
    {
        private static int NB_MAX_FOLLOWED_FORMATIONS = 5;
        private string name;
        private int zipCode;
        private Formation[] tabFormations;
        private Formation mainFormation;
        private int nbFormations;

        public Registered(string name, int zipCode, Formation formation)
        {
            this.name = name;
            this.zipCode = zipCode;
            mainFormation = formation;
            tabFormations = new Formation[NB_MAX_FOLLOWED_FORMATIONS];
            nbFormations = 0;
            if (formation == null)
                throw new Exception("Il faut une formation principale !");
            AddFormation(formation);
        }

        public dynamic MainFormation{
            get 
            {
                return mainFormation.Code;
            }
            set
            {
                foreach(Formation formation in tabFormations)
                {
                    if(formation.Code == value)
                        mainFormation = formation;
                }
            }
        }

        public int ZipCode
        {
            get
            {
                return zipCode;
            }
        }

        public void AddFormation(Formation formation, bool isNewMain = false)
        {
            if (nbFormations < 5)
            {
                if(formation.SeatLeft < 25)
                {
                    tabFormations[nbFormations] = formation;
                    nbFormations++;
                    formation.AddRegistered(this);
                    if (isNewMain)
                    {
                        MainFormation = formation;
                    }
                }
            }
            else
            {
                throw new Exception("Plus de place");
            }
        }

        public void AddFormations(params Formation[] formations)
        {
            foreach(Formation formation in formations)
            {
                try
                {
                    AddFormation(formation);
                }
                catch
                {
                    break;
                }   
            }
        }


        public abstract float PourcReductionBase(Formation formation);

        public float Cout(Formation formation)
        {
            float currentReduc = PourcReductionBase(formation);
            if (currentReduc >= 75 && Utils.RegionWalonne(ZipCode) && formation.IsSponsoredRW)
                currentReduc += 25;
            return formation.Prix/100*(100-currentReduc);
        }

        public float CoutTotal()
        {
            float total = 0;
            for(int i = 0; i < nbFormations; i ++)
            {
                total += Cout(tabFormations[i]);
            }
            return total;
        }

        public StringBuilder FicheInformation()
        {
            StringBuilder output = new StringBuilder();
            output.Append($"Inscrit : {name} ({zipCode})\n");
            foreach (Formation formation in tabFormations)
            {
                if (formation != null)
                    output.Append($"{formation.Informations()}\n");
                else
                    break;
            }
            output.Append($"Total à payer : {CoutTotal()}");
            return output;
        }

        public override string ToString()
        {
            return $"{name} - ({zipCode}) -";
        }

    }
}
