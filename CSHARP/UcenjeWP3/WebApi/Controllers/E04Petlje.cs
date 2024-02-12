

using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController ]
    [Route ("E04")]
    public class E04Petlje : ControllerBase
    {



        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int a, int b)
        {
            int zhbroj = 0;
            for(int i=a; i<=b; i++)
            {
                if (i % 2 == 0)
                {
                    zhbroj += i;
                }
            }

            return zhbroj;
        }
        // Ovdje završava ruta











    }





}

