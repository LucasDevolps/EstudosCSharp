using ApiRest5.Model;
using ApiRest5.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        private IPersonServices _personServices;

        public PersonController(ILogger<PersonController> logger, IPersonServices personServices)
        {
            _logger = logger;
            _personServices = personServices;
        }
        /* Criando o get */
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personServices.FindAll());
        }
        //Fazendo bading com parêmetro
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personServices.FindByID(id);

            if (person == null) return NotFound();

            return Ok(person);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest();


            return Ok(_personServices.Create(person));

        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null) return BadRequest();

            return Ok(_personServices.Update(person));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personServices.Delete(id);
            return NoContent();
        }
    }
}
