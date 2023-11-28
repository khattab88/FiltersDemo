using API.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [ActionFilterAttribute(nameof(DriversController))]
    public class DriversController : ControllerBase
    {
        public static List<string> drivers = new List<string>() 
        {
            "Lewis Hamilton", "George Russel", "Valteri Bottas"
        };

        [HttpGet(Name = "GetDrivers")]
        [ActionFilterAttribute($"{nameof(DriversController)}.{nameof(Get)}()")]
        [AsyncActionFilterAttribute($"{nameof(DriversController)}.{nameof(Get)}()")]
        [SecondAsyncActionFilterAttribute($"{nameof(DriversController)}.{nameof(Get)}()")]
        public IActionResult Get()
        {
            Console.WriteLine($"Controller: {nameof(WeatherForecastController)} - Action: {nameof(Get)}");
            return Ok(drivers);
        }

        [HttpPost(Name = "AddDriver")]
        public IActionResult Post(string driver) 
        {
            drivers.Add(driver);
            return Created("", driver);
        }


    }
}
