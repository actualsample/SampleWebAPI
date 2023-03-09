using AutoMapper;
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
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public SamuraisController(ISamurai samurai,IMapper mapper,ILogger<SamuraisController> logger)
        {
            _samurai = samurai;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/<SamuraisController>
        [HttpGet]
        public ActionResult<IEnumerable<SamuraiReadDto>> Get()
        {
            try
            {
                /*List<SamuraiReadDto> samuraiReadDtos = new List<SamuraiReadDto>();
                var results = _samurai.GetAll();
                foreach (var result in results)
                {
                    samuraiReadDtos.Add(new SamuraiReadDto
                    {
                        Id= result.Id,
                        Name = result.Name
                    });
                }
                return Ok(samuraiReadDtos);*/

                var results = _samurai.GetAll();
                var lstSamuraiReadDto = _mapper.Map<IEnumerable<SamuraiReadDto>>(results);
                return Ok(lstSamuraiReadDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }

        [HttpGet("withQuotes")]
        public ActionResult<IEnumerable<SamuraiWithQuotesReadDto>> GetAllWithQuotes()
        {
            /*List<SamuraiWithQuotesReadDto> listSamuraiWithQuotesDto = new List<SamuraiWithQuotesReadDto>();
            var results = _samurai.GetAllWithQuotes();
            foreach(Samurai samurai in results)
            {
                var listQuotes = new List<QuoteReadDto>();
                foreach (var quote in samurai.Quotes)
                {
                    listQuotes.Add(new QuoteReadDto
                    {
                        Id = quote.Id,
                        Text = quote.Text,
                        SamuraiId = samurai.Id
                    });
                }
                listSamuraiWithQuotesDto.Add(new SamuraiWithQuotesReadDto
                { 
                    Id = samurai.Id, 
                    Name=samurai.Name, 
                    Quotes=listQuotes 
                });
            }
            return Ok(listSamuraiWithQuotesDto);*/

            var results = _samurai.GetAllWithQuotes();
            var listSamuraiWithQuotesDto = _mapper.Map<IEnumerable<SamuraiWithQuotesReadDto>>(results);
            return Ok(listSamuraiWithQuotesDto);
        }

        // GET api/<SamuraisController>/5
        [HttpGet("{id}",Name = "GetById")]
        public ActionResult<SamuraiReadDto> Get(int id)
        {
            try
            {
                /*var result = _samurai.GetById(id);
                SamuraiReadDto samuraiReadDto = new SamuraiReadDto()
                {
                    Id = result.Id,
                    Name = result.Name
                };
                return Ok(samuraiReadDto);*/

                var result = _samurai.GetById(id);
                var samuraiReadDto = _mapper.Map<SamuraiReadDto>(result);
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
                /*var samurai = new Samurai()
                {
                    Name = samuraiDto.Name
                };
                var result = _samurai.Insert(samurai);
                var samuraiReadDto = new SamuraiReadDto {
                    Id = result.Id,
                    Name = result.Name 
                };
                return CreatedAtRoute("GetById", new { Id = result.Id }, samuraiReadDto);*/
                
                var samurai = _mapper.Map<Samurai>(samuraiDto);
                var result = _samurai.Insert(samurai);
                var samuraiReadDto = _mapper.Map<SamuraiReadDto>(result);
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
                /*var samurai = new Samurai
                {
                    Name = samuraiUpdateDto.Name
                };
                var result = _samurai.Update(id, samurai);
                var samuraiReadDto = new SamuraiReadDto
                {
                    Id = result.Id,
                    Name = result.Name
                };
                return Ok(samuraiReadDto);*/
                var samurai = _mapper.Map<Samurai>(samuraiUpdateDto);
                var result = _samurai.Update(id, samurai);
                var samuraiReadDto = _mapper.Map<SamuraiReadDto>(result);
                return Ok(result);
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

        [HttpPost("Battle")]
        public ActionResult AddSamuraiToBattle(AddSamuraiToBattleDto samuraiToBattleDto)
        {
            try
            {
                _logger.LogInformation($"{samuraiToBattleDto.SamuraiId} - {samuraiToBattleDto.BattleId}");
                //return NoContent();
                _samurai.AddSamuraiToBattle(samuraiToBattleDto.SamuraiId, samuraiToBattleDto.BattleId);
                return Ok($"Samurai id {samuraiToBattleDto.SamuraiId} berhasil ditambahkan ke battle dengan id {samuraiToBattleDto.BattleId}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("WithBattle")]
        public ActionResult<SamuraiWithBattleDto> GetSamuraiWithBattle(int samuraiId)
        {
            var samurai = _samurai.GetSamuraiWithBattle(samuraiId);
            var samuraiWithBattleDto = _mapper.Map<SamuraiWithBattleDto>(samurai);
            return Ok(samuraiWithBattleDto);

        }

        [HttpGet("WithAllBattle")]
        public async Task<ActionResult<IEnumerable<SamuraiWithBattleDto>>> GetSamuraiWithBattle()
        {
            var samurai = await _samurai.GetAllSamuraiWithBattle();
            var samuraiWithBattleDto = _mapper.Map<IEnumerable<SamuraiWithBattleDto>>(samurai);
            return Ok(samuraiWithBattleDto);

        }
    }
}
