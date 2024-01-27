

using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController ]
    [Route ("E01")]
    public class E01ulazizlaz: ControllerBase
    {
        [HttpGet]
    [Route ("Hello")]
   
        public string Hellowold( string ime)
    {
        return "Dobro vecer" + ime;



    }





    }
}
