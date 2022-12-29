using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Institution
    {

        public Institution(string name, int zipCode)
        {
            Name = name;
            ZipCode = zipCode;
        }

        public string Name
        {
            get;
            set;
        }

        public int ZipCode { get; set; }
    }
}
