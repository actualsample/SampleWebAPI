using Microsoft.AspNetCore.Mvc;
using SampleApp.BackendAPI.Dto;
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
        public ActionResult<IEnumerable<SamuraiReadDto>> Get()
        {
            try
            {
                List<SamuraiReadDto> samuraiReadDtos = new List<SamuraiReadDto>();
                var results = _samurai.GetAll();
                foreach (var result in results)
                {
                    samuraiReadDtos.Add(new SamuraiReadDto
                    {
                        Name = result.Name
                    });
                }
                return Ok(samuraiReadDtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }

        // GET api/<SamuraisController>/5
        [HttpGet("{id}")]
        public ActionResult<SamuraiReadDto> Get(int id)
        {
            try
            {
                var result = _samurai.GetById(id);
                SamuraiReadDto samuraiReadDto = new SamuraiReadDto();
                samuraiReadDto.Name = result.Name;

                return Ok(samuraiReadDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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
