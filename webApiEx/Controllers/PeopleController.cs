using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webApiEx.Contracts;

namespace webApiEx.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly ILogger<PeopleController> _logger;
        private readonly IPeopleService _peopleService;

        [HttpGet]
        public ActionResult<List<Person>> GetAllPeople()
        {
            return Ok(_peopleService.GetAll());
        }

        [HttpGet("byid")]
        public ActionResult<Person> GetById(int id)
        {
            var person = _peopleService.GetById(id);
            if(person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        public PeopleController(ILogger<PeopleController> logger, IPeopleService peopleService)
        {
            _logger = logger;
            _peopleService = peopleService;
        }


      
    }
}
