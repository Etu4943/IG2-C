using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3
{
    internal class DessinAnime:EpisodeSerie
    {
        private int targetAge;
        public DessinAnime(string title, int duration, string serieName, int num, int targetAge):base(title, duration, serieName, num)
        {
            this.targetAge = targetAge;
        }

        public string Presentation()
        {
            return $"Enfant de {targetAge} : {Title} ({SerieName} numéro {Num})";
        }


    }
}
