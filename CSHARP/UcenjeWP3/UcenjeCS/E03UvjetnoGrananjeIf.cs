using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {
        public static void Izvedi()
        {
            int i = 7; // nisam koristio consol readline kako bi bio brži

            bool uvjet = i == 7;
            // minimalnio if izraz

            if (uvjet)
            {
                Console.WriteLine("1. ušao sam u if granu");
            }
            // ako se if odnosi na jednu liniju i ne trebaju viticaste zagrade

            if (uvjet)
                Console.WriteLine("2. bez{}");
            Console.WriteLine("3. ovo ce se uvijek ispisati");

            // primjer kako se inače piše if

            if (i > 0)
            {
                Console.WriteLine("4. i je veče od 0");
            }

            var j = 5;
            //dodatni operatori and(&)
            if (i == 7 & j == 5)
            {
                Console.WriteLine("5. zadovoljena uvjeta");
            }

            //razlika izmedu & i &&
            // & uvijek se provjerava oba ovjeta
            //&& ukoliko prvi uvjet nije zadovoljen drugi se provjerava

            if (i == 7 && j == 5)
            {
                Console.WriteLine("6. oba uvjeta su zadovoljena");
            }
            else //neobavezni dio if naredbe
            {
                Console.WriteLine("7. jedan uvjet nije zadovolje");
            }

            //logičko ili ALGR+W
            // | uvijek se šrpvjeravaju oba uvjeta
            // ||

            if (i == 7 || j == 5)
            {
                Console.WriteLine("8. jedan ili oba uvjet su zadovoljena");
            }
            else
            {
                Console.WriteLine("9.niti jedan uvjet nije zadovoljen");
            }

            //logički not
            //jedan kompliciran uvjet
            if((i>0 && i<10) || !(i < 5))
            {
                Console.WriteLine("10.zadovoljen kompliciran uvjet");
            }
            i = 5;
            if(i==1)    

            {
                Console.WriteLine("11. i je 1"); 
            }else if (i == 2)
            {
                Console.WriteLine("12. i je 2");
            }
            else
            {
                Console.WriteLine("13. i nije 1ili 2");
            }

            //inline if
            // kada if poziva istu naredbu s razlicitim parametrima
            if(1== 3)
            {
                Console.WriteLine("14. i je 3");
            }
            else
            {
                Console.WriteLine("15. i nije 3");
            }

            Console.WriteLine(i==3 ? "14. i nije 3" : "15.  nije 3");

            
         
           

        

        }
    }
}
