using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z03
    {
        public static void Izvedi()
        {
            //program unosi tri cijela broja
            //program ispisuje najmanji

            int a = 3, b = 6, c = 8;
            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            if (b<a && b < c) 
            {
                Console.WriteLine(b);
            }else
            {
                Console.WriteLine(c);
            }
         

           

                
        }
    }
}
