using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06orPetlja
    {
        public static void Izvedi()
        {
            for (int i = 0; i<10; i = i +1)
            {
                Console.WriteLine("Edunova" +i);
            }


            int[] niz = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // ispisati sve brojeve jedne ispod drugih

            for (int i = 0;i < niz.Length;i++)
            {
                Console.WriteLine(niz[i]);
            }

            //ispisati sve parne brojeve od 3 do 43

            for(int i=3; i<=43; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            //koji je zbroj prvih 100 brojeva
            // 1+2+3+4

            int suma = 0;
            for(int i=1; i<=100; i++)
            {
                suma += i;
            }

            Console.WriteLine(suma);

            //petlja  moze ici i unazad
            // ispisi sve brojeve od 78 do 4

            for(int i=78; i>=4; i--)
            {
                Console.WriteLine(i);
            }


            //ispisi svaki 7 broj od 1 do 10
            for(int i=1; i<=100; i += 7)
            {
                Console.WriteLine(i);
            }

            // ispisite brojeve od 1 do 20 jedno pokraj drugog
            for(int i=1; i<=20; i++)
            {
                Console.Write(i + " ");
            }
           


            //petlje se mogu ugnjezditi
            for (int i=1; i<=10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }

            // DZ formatirati na ovaj nacin


            //petlja se moze preskoociti

            for(int i=0; i<10; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                {
                    Console.WriteLine(i);
                }
                
            }

            for(int i=0; i<10; i++)
            {
                if (i == 3) 
                {
                    break;
                }
               
                    Console.WriteLine(i);
                }

                for (int i = 0; 1 < 10; i++)
                {
                    for(int j=0; j<10; j++)
                    {
                        goto labela;
                    }
                }
                labela:
                Console.WriteLine("nastavljamo nakon vanjske petlje");

                for(; ; )
            {
                Console.WriteLine(new Random().NextInt64(1,100));
                break;
            }









            }


        }
    }

