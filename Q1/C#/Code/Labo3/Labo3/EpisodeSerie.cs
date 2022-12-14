using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3
{
    internal class EpisodeSerie:Emission
    {
        private string serieName;
        private int num;
        public EpisodeSerie(string title, int duration, string serieName, int num) : base(title, duration)
        {
            this.serieName = serieName;
            this.num = num;
        }

        public override string Presentation()
        {
            return serieName + " : " + base.Presentation();
        }

        public string SerieName
        {
            get { return serieName; }
        }

        public int Num
        {
            get { return num; }
        }
    }
}
