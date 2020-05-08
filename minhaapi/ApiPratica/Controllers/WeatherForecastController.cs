using Microsoft.AspNetCore.Mvc;

namespace ApiPratica.Controllers
{
    [ApiController]
    [Route("api")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Oiiiiii");
        }
    }
}
