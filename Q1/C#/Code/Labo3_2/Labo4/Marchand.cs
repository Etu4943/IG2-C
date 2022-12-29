using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Marchand : PNJ
    {
        private ICompagnon[] tabPNJ;
        int nbPNJ;
        public Marchand(string nom) : base(nom, 10, "commerçant") 
        {
            tabPNJ = new ICompagnon[10];
            nbPNJ = 0;
        }

        public void AjouterCompagnon(params ICompagnon[] compagnons)
        {
            foreach(ICompagnon compagnon in compagnons)
            {
                tabPNJ[nbPNJ] = compagnon;
                nbPNJ++;
            }
        }


        public void AfficherOffre()
        {
            StringBuilder output= new StringBuilder();
            output.Append(Nom + " propose :\n");
            for (int i = 0; i < nbPNJ; i++)
            {
                output.Append($"({i+1}) {tabPNJ[i].Nom}: {tabPNJ[i].PrixAchat} po plus {tabPNJ[i].CoutQuotidien} po par jour\n");
            }
            Console.WriteLine(output);
        }

    }
}
