using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Unemployed : Registered
    {
        private int ONEMNum;
        public Unemployed(string name, int zipCode, Formation formation, int ONEMNum) : base(name, zipCode, formation) 
        {
            this.ONEMNum= ONEMNum;
        }

        public override float PourcReductionBase(Formation formation)
        {
            return 100;
        }

    }
}
