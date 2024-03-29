﻿
namespace UcenjeCS.E17KonzolnaAplikacija
{
    internal class Izbornik
    {
        public ObradaSmjer ObradaSmjer { get; }
        public ObradaPolaznik ObradaPolaznik { get; }

        private ObradaGrupa ObradaGrupa;
        public ObradaPredavac ObradaPredavac { get; }

        public Izbornik() 
        {
            
            Pomocno.dev = true;
            ObradaSmjer = new ObradaSmjer();
            ObradaPolaznik = new ObradaPolaznik();
            ObradaPredavac = new ObradaPredavac();
            ObradaGrupa=new ObradaGrupa(this);
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Edunova Console APP v 1.0 *****");
            Console.WriteLine("*************************************");
        }

        private void PrikaziIzbornik()
        {
            Console.Clear();
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Preadavac");
            Console.WriteLine("5. Izlaz iz programa");
            

            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika: ",
                "Odabir mora biti 1 - 4.", 1, 5))
            {
                case 1:
                    Console.Clear();
                    ObradaSmjer.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    ObradaPolaznik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    ObradaGrupa.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObradaPredavac.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;

                    case 5:
                    Console.WriteLine("Hvala na kolrištenju doviđenja");
                    break;


            }


        }

    }
}
