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

            {
                Console.WriteLine("Unesi prvi brpj");
            }
            int broj2 = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("Unesi drugi broj");
            }
                int broj4 = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("Unesi treci broj");
            }
                int broj7 = int.Parse(Console.ReadLine());

            if (broj2 < broj4 && broj2 < broj7)
            {
                Console.WriteLine(broj2);
            }else if(broj4<broj2 && broj2 < broj7)
            {
                Console.WriteLine(broj4);
            }
            else
            {
                Console.WriteLine(broj7);
            }
            

                
        }
    }
}
