using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL241125_Vp
{
    internal class Ember
    {
        public Guid Guid { get; set; }
        public string Nev { get; set; }

        public override string ToString() =>
            $"{Nev} ({Guid})";

        public Ember(string nev)
        {
            Guid = Guid.NewGuid();
            Nev = nev;
        }
    }
}
