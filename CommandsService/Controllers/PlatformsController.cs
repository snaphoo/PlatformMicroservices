using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controller
{
    [ApiController]
    [Route("api/c/{controller}")]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {
            
        }


        [HttpPost]
        public ActionResult TestInboundConnexion(){
            Console.WriteLine("--> Inbound POST # Command Service");

            return Ok("Inbound test OK from Platforms Controller");
        }
    }
}