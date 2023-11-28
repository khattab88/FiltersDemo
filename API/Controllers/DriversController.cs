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
        public IActionResult Get()
        {
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
