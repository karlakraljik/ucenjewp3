using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z01
    {
        public static void Izvedi()
        {
            //program od korisnika unosi cijeli broj
            //ako je uneseni broj paran ispisuje "Super"
            //inače ispisuje Ok

            Console.Write("Unesi cijeli broj");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 0)
            {
                Console.WriteLine("Super");
            }
            else
            {
                Console.WriteLine("Ok");
            }

        }
    }
}
