using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z0LjubavniKalkulator
    {

        public static void Izvedi()
        {
            Console.WriteLine("Ljubavni Kalkulator <3");

            Console.WriteLine("Unesite svoje ime");
            string TvojeIme = Console.ReadLine().Trim().ToUpper();

            Console.WriteLine("Unesite ime simpatije");
            string SimpatijaIme = Console.ReadLine().Trim().ToUpper();

            
            Console.WriteLine("Izračunavanje šanse ljubavi...");

            System.Threading.Thread.Sleep(2000);

            string imeukupno = TvojeIme + SimpatijaIme;


            char[] Imeukupnochar = imeukupno.ToCharArray();

            PonavljanjeSlova[] listaSlova = new PonavljanjeSlova[Imeukupnochar.Length];


            for (int i = 0; i < Imeukupnochar.Length; i++)
            {
                char character = Imeukupnochar[i];
                int counter = new int();
                for (int j = 0; j < Imeukupnochar.Length; j++)
                {
                 
                    if (Imeukupnochar[j] == character) 
                    {
                        counter++;
                    }
                    continue;
                }
                listaSlova[i] = new PonavljanjeSlova(character, counter);
            }


            int[] zbrojevi = prviZbroj(listaSlova.Select(x => x.counter).ToArray());

            string novoString = string.Join("", zbrojevi);

            int rezultat = int.Parse(novoString);

            Console.WriteLine("\n Šansa za ljubav iznosi: " + rezultat + "%");



            static int[] prviZbroj(int[] brojevi)
            {
                int[] noviZbrojevi;

                if (brojevi.Length % 2 == 0)
                {
                    noviZbrojevi = new int[brojevi.Length / 2];
                }
                else
                {
                    noviZbrojevi = new int[brojevi.Length / 2 + 1];
                }

                for (int i = 0; i < brojevi.Length / 2; i++)
                {
                    int zbroj = brojevi[i] + brojevi[brojevi.Length - 1 - i];

                    if (zbroj >= 10)
                    {
                        noviZbrojevi[i] = zbroj / 10;
                        noviZbrojevi[noviZbrojevi.Length - 1] = zbroj % 10;
                    }

                    else
                    {
                        noviZbrojevi[i] = zbroj;
                    }

                }

                if (brojevi.Length % 2 != 0)
                {
                    noviZbrojevi[noviZbrojevi.Length - 1] = brojevi[brojevi.Length / 2];
                }

                if (brojevi.Length > 3)
                {


                    return prviZbroj(noviZbrojevi);
                }
                else
                {
                    return noviZbrojevi;
                }
            }

        }
        
    }

    public class PonavljanjeSlova
    {
        public char character;
        public int counter;

        public PonavljanjeSlova(char character, int counter)
        {
            this.character = character;
            this.counter = counter;
        }
    }
}
