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
                        Id= result.Id,
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
        [HttpGet("{id}",Name = "GetById")]
        public ActionResult<SamuraiReadDto> Get(int id)
        {
            try
            {
                var result = _samurai.GetById(id);
                SamuraiReadDto samuraiReadDto = new SamuraiReadDto()
                {
                    Id = result.Id,
                    Name = result.Name
                };

                return Ok(samuraiReadDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<SamuraisController>
        [HttpPost]
        public ActionResult<SamuraiReadDto> Post(SamuraiInsertDto samuraiDto)
        {
            try
            {
                var samurai = new Samurai()
                {
                    Name = samuraiDto.Name
                };
                var result = _samurai.Insert(samurai);
                var samuraiReadDto = new SamuraiReadDto {
                    Id = result.Id,
                    Name = result.Name 
                };
                return CreatedAtRoute("GetById", new { Id = result.Id }, samuraiReadDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<SamuraisController>/5
        [HttpPut("{id}")]
        public ActionResult<SamuraiReadDto> Put(int id, SamuraiUpdateDto samuraiUpdateDto)
        {
            try
            {
                var samurai = new Samurai
                {
                    Name = samuraiUpdateDto.Name
                };
                var result = _samurai.Update(id, samurai);
                var samuraiReadDto = new SamuraiReadDto
                {
                    Id = result.Id,
                    Name = result.Name
                };
                return Ok(samuraiReadDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<SamuraisController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _samurai.Delete(id);
                return Ok($"Data samurai id {id} berhasil didelete");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
