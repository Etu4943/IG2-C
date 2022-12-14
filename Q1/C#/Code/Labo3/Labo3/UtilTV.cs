using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3
{
    internal class UtilTV
    {
        static public void AfficherProgramme( params Emission[] tabEmissions)
        {
            foreach (Emission emission in tabEmissions)
            {
                Console.WriteLine(emission.Presentation());
            }
        }

        public static void PresentationDA(params DessinAnime[] das)
        {
            foreach (DessinAnime da in das)
                Console.WriteLine(da.Presentation());
        }
    }
}
