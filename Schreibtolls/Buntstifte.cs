using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtolls
{
    class Buntstifte:Stift
    {
        public Buntstifte(int strichstärke) : base(strichstärke)
        {
            this.Typ = "Buntstifte";
        }
        public Buntstifte(int strichstärke, ConsoleColor farbe) : base(strichstärke, farbe)
        {
            this.Typ = "Buntstifte";
        }
    }
}
