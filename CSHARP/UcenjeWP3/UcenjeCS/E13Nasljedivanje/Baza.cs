using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Baza
    {
        public Baza(string Naziv) {
            this.Nazhiv = Naziv;
        
        }
        public string Nazhiv { get; set; }
    }
}
