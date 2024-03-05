using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E17KonzolnaAplikacija.Model;

namespace UcenjeCS.E17KonzolnaAplikacija
{
    internal class ObradaPredavac
    {

        public List<Predavac> Predavaci { get; }

        public ObradaPredavac()
        {
            Predavaci = new List<Predavac>();
            if (Pomocno.dev)
            {
                TestniPodaci();
            }
        }

        public void PrikaziIzbornik()
        {

            Console.WriteLine("Izbornik za rad s predavacima");
            Console.WriteLine("1. Pregled postojećih predavaca");
            Console.WriteLine("2. Unos novog predavaca");
            Console.WriteLine("3. Promjena postojećeg predvaca");
            Console.WriteLine("4. Brisanje predvaca");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika predvaca: ",
                "Odabir mora biti 1-5", 1, 5))
            {

                case 1:
                    PregledPredavaca();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UcitajNovogPredvaca();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjenaPreadavaca();
                    PrikaziIzbornik();
                    break;
                case 4:
                    BrisanjePrevaca();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad s polaznicima");
                    break;
            }

        }


        private void PromjenaPreadavaca()
        {
            throw new NotImplementedException();
        }

        private void PromjenaPredavaca()
        {
            PregledPredavaca();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj predavaca: ", "Nije dobar odabir", 1, Predavaci.Count());
            Predavac p = Predavaci[index - 1];
            p.Ime = Pomocno.UcitajString("Unesi ime predavaca (" + p.Ime + "): ", "Ime obavezno");
            p.Prezime = Pomocno.UcitajString("Unesi Prezime predavaca (" + p.Prezime + "): ", "Prezime obavezno");
            p.Email = Pomocno.UcitajString("Unesi Email predavaca (" + p.Email + "): ", "Email obavezno");
            p.Oib = Pomocno.UcitajString("Unesi Oib predavaca (" + p.Oib + "): ", "Oib obavezno");
            p.Iban = Pomocno.UcitajString("Unesi Iban predavaca(" + p.Iban + "): ", "Iban obavezno");
        }


        private void PregledPredavaca()
        {

            Console.WriteLine("------------------");
            Console.WriteLine("---- Predavac ----");
            Console.WriteLine("------------------");
            int b = 1;
            foreach (Predavac predavac in Predavaci)
            {
                Console.WriteLine("{0}. {1}", b++, predavac);
            }
            Console.WriteLine("------------------");
        }


        private void UcitajNovogPredvaca()
        {
            Predavac p = new Predavac();
            p.Sifra = Pomocno.ucitajCijeliBroj("Unesi sifru predavaca: ", "Unos mora biti pozitivan broj");
            p.Ime = Pomocno.UcitajString("Unesi ime: ", "Ime obavezno");
            p.Prezime = Pomocno.UcitajString("Unesi Prezime predavaca: ", "Prezime obavezno");
            p.Email = Pomocno.UcitajString("Unesi Email predavaca: ", "Email obavezno");
            p.Oib = Pomocno.UcitajString("Unesi Oib predavaca: ", "Oib obavezno");
            p.Iban = Pomocno.UcitajString("Unesi Iban predavaca: ", "Oib obavezno");
            Predavaci.Add(p);
        }




        private void BrisanjePrevaca()
        {
            PregledPredavaca();
            int index = Pomocno.ucitajBrojRaspon("Odaberi redni broj predavaca: ", "Nije dobar odabir", 1, Predavaci.Count());
            Predavaci.RemoveAt(index - 1);
        }


        private void TestniPodaci()
        {




            Predavaci.Add(new Predavac
            {
                Sifra = 1,
                Ime = "Marko",
                Prezime = "Marić",
                Email = "markomaric@gmaiol.com",
                Oib = "021588524522",
                Iban = "12343344"
            });

            Predavaci.Add(new Predavac
            {
                Sifra = 2,
                Ime = "Ana",
                Prezime = "Tomić",
                Email = "tomican@gmail.com",
                Oib = "33734172821",
                Iban = "HR1259983252"
            });
        }

        internal void PrikaziPredavace()
        {
            throw new NotImplementedException();
        }
    }
}
