using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Worker : Registered
    {
        private string occupation;
        private Institution institution;

        public Worker(string name, int zipCode, Formation formation,string occupation, Institution institution) : base(name, zipCode, formation)
        {
            Occupation = occupation;
            this.institution = institution;
        }
        public Worker(string name, int zipCode, Formation formation, string occupation) : this(name, zipCode, formation, occupation, null) { }

        public virtual dynamic Occupation 
        { 
            get 
            { 
                StringBuilder output = new StringBuilder();
                output.Append(occupation);
                if (institution != null)
                    output.Append(" at " + institution.Name);   
                return output;
            }
            set
            {
                occupation = value;
            }
        }

        public int InstitutionZip
        {
            get
            {
                return institution.ZipCode;
            }
        }


        public override float PourcReductionBase(Formation formation)
        {
            if (Utils.GrandNamur(ZipCode))
                return 20;
            if (Utils.RegionWalonne(ZipCode) && formation.IsSponsoredRW)
                return 25;
            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Occupation;
        }

    }
}
