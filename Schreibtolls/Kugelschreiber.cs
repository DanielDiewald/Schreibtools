using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtolls
{
    class Kugelschreiber:Stift
    {
        public Kugelschreiber(int strichstärke) : base(strichstärke)
        {
            this.Typ = "Kugelschreiber";
        }
        public Kugelschreiber(int strichstärke, ConsoleColor farbe): base(strichstärke, farbe)
        {
            this.Typ = "Kugelschreiber";
        }
    }
}
