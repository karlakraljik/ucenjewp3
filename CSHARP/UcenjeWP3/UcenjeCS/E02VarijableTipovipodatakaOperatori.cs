using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipovipodatakaOperatori
    {

        public static void izvedi()
        {
            int CijeliBroj;
            CijeliBroj = 7; // dodjeljivanje varijabli pomoču operatora =

            Console.WriteLine(CijeliBroj); // korištenje varijable

            Console.WriteLine("unesi cijeli broj");

            int Broj = int.Parse(Console.ReadLine());
            Console.WriteLine(CijeliBroj + Broj); //operator zbrajanja

            //// Deklaracija dodavanja vrjednosti u jednoj linijmi
            string v1 = "Osijek";
            string v2 = "Edunova";
            Console.WriteLine(v1 + v2); // + operator nadoljepljivanje

            float db = 3.14f;
            double vdb = 0.5556555666566655522655666664;

            Console.WriteLine("Unesi visinu u metrima");
            float visina = float.Parse(Console.ReadLine());

            Console.WriteLine(visina);

            int NajveciBroj = int.MaxValue;

            Console.WriteLine(NajveciBroj + 1);

            int i = 2, j = 3;
            Console.WriteLine(i-j); // -1
            Console.WriteLine(i*j); // 6
            Console.WriteLine(i/(float)j); //0.666666 (float) cast u flout tip podatka

            // iz dvoznamenkastog broja ispiši prvi broj

            Console.Write("Unesi dvoznamenkasti broj:");
            int dbroj=int.Parse(Console.ReadLine());
            Console.WriteLine( dbroj/10);

            // iz dvoznamenkastog broja ispiši drugi broj

            Console.WriteLine(dbroj%10); // modulo je ostatak cjelobrojnog djeljenja

            bool uvjet = true; // true ili false

            // operator jednakosti ==

            int k = 2, l = 2;
            Console.WriteLine(k==l);

            // različito !=

            Console.WriteLine(k!=l);

            // formatiranje rada konzolnog ispisa

            Console.WriteLine("{0} {1} {2} {3}", k>l, k>=l, k<l,k<=l);

            // uvečanje za 1
            int v = 1;
            Console.WriteLine(v); //1

            v = v + 1;

            Console.WriteLine(v); //2

            v += 1;

            Console.WriteLine(v); // 3

            // increment i dekrement

            v = 1;
            // ispisati i uvečati
            Console.WriteLine(v++);

            // uvećati pa ispisati
            Console.WriteLine(++v);

            // isto vrijedi i za decrement npr. --v i v--

            int x = 2, y = 1;
            x = x + ++y; // x = 4, y=2
            x = --x;  // x=3, y = 3
            Console.WriteLine(x+y); // 6





















        }

    }
}
