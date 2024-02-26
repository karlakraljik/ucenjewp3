using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Polaznik:Osoba

    {

        public Polaznik() : base() 
        {
        }
        public Polaznik(string Ime, string Prezime, string Brojugovora)
            : base(Ime, Prezime)
        {
            this.BrojUgovora = Brojugovora;
        }
       
        public string? BrojUgovora { get; set; }

        public override string ToString()
        {
            return base.ToString()  +": " + BrojUgovora;
        }
    }
}
