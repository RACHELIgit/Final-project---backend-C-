using Common_DTO.DTOs;
using Microsoft.AspNetCore.Mvc;
using Services_Bll.interfaces;
namespace WebApi.Controllers
{
      [Route("api/[controller]")]
        [ApiController]
    public class UsersController : Controller
    {
            readonly IService<UsersDto> _service;
            public UsersController(IService<UsersDto> service)
            {
                _service = service;
            }
            // GET: api/<ValuesController>
            [HttpGet]
            public async Task<IEnumerable<UsersDto>> Get()
            {
                return await _service.GetAllAsync();
            }

            // GET api/<ValuesController>/5
            [HttpGet("{id}")]
            public string Get(int id)
            {
                return "value";
            }

            // POST api/<ValuesController>
            [HttpPost]
            //public void Post([FromBody] string value)
            //{
            //    _service.AddAsync(new UsersDto() { Name = value });
            //}

            // PUT api/<ValuesController>/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE api/<ValuesController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        }
    }


