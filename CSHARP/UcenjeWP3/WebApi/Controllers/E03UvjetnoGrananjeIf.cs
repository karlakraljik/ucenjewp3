

using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController ]
    [Route ("E03")]
    public class E03UvjetnoGrananjeIf : ControllerBase
    {



        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int a, int b)
        {
            // Ruta prima dva cijela broja
            //ako je zbroj primljenih brojeva paran broj
            //vraca njihov umnozhak inace vraca njihov zbroj
            return (a+b)%2==0 ? a+b : a+b;
        }
        // Ovdje završava ruta




        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad2")]
        public string Zad2(int ocjena)
        {
            // Ruta prima brojcanu ocjenu
            // Ruta vraca slovnu ocjenu
            switch (ocjena)
            {
                case 1:
                    return "Nedovoljan";
                case 2:
                    return "Dovoljan";
                case 3:
                    return "Dobar";
                case 4:
                    return "Vrlo dobar";
                case 5:
                    return "Odličan";
                default:
                    return "Nije ocjena";

            }

        }
        // Ovdje završava ruta











    }





}

