using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal class Teacher : Worker
    {
        private string mainSubject;

        public Teacher(string name, int zipCode, Formation formation, string occupation,Institution institution, string mainSubject):base(name,zipCode, formation, occupation,institution)
        {
            this.mainSubject= mainSubject;
        }

        public override float PourcReductionBase(Formation formation)
        {
            if (Utils.GrandNamur(InstitutionZip))
                return 70;
            return 50;
        }

        public override string Occupation
        {
            get
            {
                return base.Occupation + " - [Main Subject : " + mainSubject + "]";
            }
        }

    }
}
