using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z06
    {
        public static void Izvedi()
        {
            int pb = Pomocno.UcitajCijeliBoroj("Unesi prvi broj");
            int db = Pomocno.UcitajCijeliBoroj("Unesi drugi broj");
            Console.WriteLine(pb+db);
            Console.WriteLine(Pomocno.UcitajString("unesi ime grada"));
        }
    }
}
