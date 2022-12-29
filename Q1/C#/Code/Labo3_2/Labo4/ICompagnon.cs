using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4
{
    
    internal interface ICompagnon
    {
        int PrixAchat{ get; }
        int CoutQuotidien { get; }

        string Nom { get; }

    }
}
