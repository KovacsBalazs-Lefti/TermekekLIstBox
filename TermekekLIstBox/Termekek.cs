using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermekekLIstBox
{
    internal class Termekek
    {
        ulong termekkod;
        string nev;
        int mennyiseg;

        public ulong Termekkod { get => termekkod; set => termekkod = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public Termekek(ulong termekkod, string nev, int mennyiseg)
        {
            Termekkod = termekkod;
            Nev = nev;
            Mennyiseg = mennyiseg;
        }

        public override string ToString()
        {
            return $"{this.nev} ({this.Mennyiseg} kg)";
        }
        public string toTxt()
        {
            return $"{termekkod};{this.nev};{this.mennyiseg}\n";

        }
    }
    
}
