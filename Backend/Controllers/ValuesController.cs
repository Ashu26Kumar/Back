using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models.manager;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly dbContext _dbContext;
        public ValuesController(dbContext context) { _dbContext = context; }
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            var active = _dbContext.Brokers.Count(m => m.isActive == 1);
            var inactive = _dbContext.Brokers.Count(m => m.isActive != 1);
            return Ok(new { active = active, inactive = inactive });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
