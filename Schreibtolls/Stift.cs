using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schreibtolls
{
    abstract class Stift
    {
        public int Strichstärke { get; set; }
        public ConsoleColor Farbe { get; set; }
        public string Typ { get; set; }
        public Stift(int strichstärke)
        {
            this.Strichstärke = strichstärke;
            this.Typ = "unbekannt";
            this.Farbe = 0;
        }
        public Stift (int strichstärke, ConsoleColor farbe) :this(strichstärke)
        {
            this.Farbe = farbe;
        }
        public virtual string SchreibeTest(string text)
        {
            Console.BackgroundColor = (ConsoleColor)0;
            Console.ForegroundColor = this.Farbe;
            if ((int)this.Farbe == 0)
            {
                Console.BackgroundColor = (ConsoleColor)15;
            }
            return $"({Typ},{Strichstärke},{Farbe}) {text}";
        }
    }
}
