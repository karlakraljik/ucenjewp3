using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E17KonzolnaAplikacija;

namespace UcenjeCS.E12KlasaObjekt.Edunova
{
    internal class Predavac
    {
        internal object Iban;

        public int? sifra { get; set; }
        public int Sifra { get; internal set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Email { get; set; }
        public string? Oib { get; set; }
        public string? BrojUgovora { get; set; }

        public static implicit operator Predavac(ObradaPredavac v)
        {
            throw new NotImplementedException();
        }
    }
}
