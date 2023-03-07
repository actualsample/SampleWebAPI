using Microsoft.AspNetCore.Mvc;
using SampleApp.BackendAPI.Models;
using SampleApp.BackendAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleApp.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamuraisController : ControllerBase
    {
        private readonly ISamurai _samurai;
        public SamuraisController(ISamurai samurai)
        {
            _samurai = samurai;
        }

        // GET: api/<SamuraisController>
        [HttpGet]
        public IEnumerable<Samurai> Get()
        {
            var results = _samurai.GetAll();
            return results;
        }

        // GET api/<SamuraisController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SamuraisController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SamuraisController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SamuraisController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
