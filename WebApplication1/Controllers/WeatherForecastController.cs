using Microsoft.AspNetCore.Mvc;
using WebApplication1.DI;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : Controller
    {
        private readonly ISample _sample;
        private readonly IDIExample dIExample;

        public WeatherForecastController(ISample sample, IDIExample dIExample)
        {
  
            _sample = sample;
            _sample.Name = "Demo";
            this.dIExample = dIExample;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            dIExample.Sample();
            return BadRequest();
        }
    }
}