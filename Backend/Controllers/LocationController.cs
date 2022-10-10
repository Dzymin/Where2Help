using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Data;

namespace Backend.Controllers
{
    [Route("api/location")]
    [ApiController]
    public class LocationController : Controller
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(long id)
        {
            var locationData = HttpContext.RequestServices.GetService<LocationData>();
            return locationData.GetLocation(id);
        }
    }
}
