using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07
    {
        public static void Izvedi()
        {
            string ime = Pomocno.UcitajString("Unesi svoje ime");
            int visina = Pomocno.UcitajCijeliBoroj("Unesi svoju visinu u cm");
            float tezina = Pomocno.UcitajdecimalniiBoroj("Unesi svoju tezinu u kgh");

            if(visina>170 && visina > 190)
            {
                if (tezina < 90.5)
                {
                    Console.Write("ti, " + ime + " si zgodan/zgodna.");
                }
               
            }


        }
    }
}
