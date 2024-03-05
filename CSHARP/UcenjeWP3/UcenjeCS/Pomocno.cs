using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Pomocno
    {
        public static int UcitajCijeliBoroj(string poruka)
        {

                while(true) { 
                Console.Write(poruka + ": ");

                try
                {
                    return int.Parse(Console.ReadLine());

                }
                catch (Exception) 
                {
                    Console.WriteLine("Nisi unio broj");

                }
            }
        }

        public static int UcitajCijeliBroj(string poruka, int min,int max)
        {
            int i;
            while(true)
            {
                i = UcitajCijelibroj(poruka);
                if(i<min || i > max)
                {
                    Console.WriteLine("Učitani broj nije u danom rasponu");
                }
                return i;

            }
        }

        private static int UcitajCijelibroj(string poruka)
        {
            throw new NotImplementedException();
        }

        public static float UcitajdecimalniiBoroj(string poruka)
        {

            while (true)
            {
                Console.Write(poruka + ": ");

                try
                {
                    return float.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Nisi unio cijeli broj");

                }
            }
        }

        public static string UcitajString(string poruka)
        {
            string s;
            for(; ; )
            {
                Console.Write(poruka + ": ");
                s=Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    Console.WriteLine("obavezan unos");
                }
                return s;
            }
        }

        internal static int UcitajCijelibroj(string v1, int v2, int count)
        {
            throw new NotImplementedException();
        }
    }
}


