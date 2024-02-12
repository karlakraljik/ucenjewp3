using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z05
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi cijeli broj");
            int broj=int.Parse(Console.ReadLine());

            int zbroj = 0;
            for(int i=0; i<=broj; i++)
            {
                zbroj += i;
            }
            
                Console.WriteLine(zbroj);
            
        





        }
    }
}
