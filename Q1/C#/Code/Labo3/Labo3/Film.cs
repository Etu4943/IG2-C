using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3
{
    internal class Film : Emission
    {
        private string genre;

        public Film(string title, int duration, string genre):base(title,duration)
        {
            this.genre = genre;
        }

        public override string Presentation()
        {
            return base.Presentation() + ", " + genre;
        }
    }
}
