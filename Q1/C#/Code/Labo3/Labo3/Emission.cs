using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3
{
    internal class Emission
    {
        protected string title;
        protected int duration;

        public Emission(string title, int duration)
        {
            this.title = title;
            this.duration = duration;
        }

        public virtual string Presentation()
        {
            return title + " (" + duration + " minutes)";
        }

        public string Title
        {
            get { return title; }
        }
    }
}
