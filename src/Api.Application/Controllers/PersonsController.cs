using System.Collections.Generic;
using Api.Application.Interfaces;
using Api.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [ApiController]
    [Route("/v1/person")]
    public class PersonsController : ControllerBase
    {
        [HttpPost("create")]
        public IActionResult Save([FromServices] IPersonRepository repository, [FromBody] Person person)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.ValidationState);
            }

            repository.Save(person);
            return Ok(person);
        }

        [HttpPost("remove/{id}")]
        public IActionResult Remove([FromServices] IPersonRepository repository, int id)
        {
            try
            {
                repository.Remove(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("persons")]
        public IEnumerable<Person> GetAll([FromServices] IPersonRepository repository)
        {
            return repository.GetAll();
        }

        [HttpPost("update/{id}")]
        public IActionResult Update([FromServices] IPersonRepository repository,[FromBody] Person person, int id)
        {
            try
            {
                repository.Update(id, person);
                return Ok();  
            }
            catch
            {
                
                return BadRequest();
            }
        }
    }
}