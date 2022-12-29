using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    internal static class Utils
    {
        public static bool GrandNamur(int zipCode)
        {
            return zipCode >= 5000 && zipCode <= 5099;
        }
        public static bool RegionWalonne(int zipCode)
        {
            return (zipCode >= 1300 && zipCode <= 1499) || (zipCode >= 4000 && zipCode <= 7999);
        }
    }
}
