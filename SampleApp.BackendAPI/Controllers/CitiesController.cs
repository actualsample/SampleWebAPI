using Microsoft.AspNetCore.Mvc;
using SampleApp.BackendAPI.Models;

namespace SampleApp.BackendAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("v2")]
        public ActionResult<IEnumerable<CityDto>> GetCities2()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{name}")]
        public ActionResult<CityDto> GetCity(string name) 
        { 
            var cityToReturn = CitiesDataStore.Current.Cities.OrderBy(x=>x.Name)
                .FirstOrDefault(x => x.Name.ToLower().Contains(name.ToLower()));
            if(cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
