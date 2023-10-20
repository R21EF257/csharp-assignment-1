using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello World (Rock, Paper, Scissors)";
        }
    }
}
