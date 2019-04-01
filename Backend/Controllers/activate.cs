using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Backend.Models.manager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    public class ActivateController : Controller
    {
        private readonly dbContext _dbContext;
        public ActivateController(dbContext dbContext) { _dbContext = dbContext; }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<state> Get()
        {
            return _dbContext.states.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]state value)
        {
            _dbContext.states.Add(value);
            _dbContext.SaveChanges();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id)
        {
            var broker = _dbContext.Brokers.FirstOrDefault(m => m.id == id);
            broker.isActive = broker.isActive == 1 ? (byte)0 : (byte)1;
            await _dbContext.SaveChangesAsync();
            return CreatedAtRoute("getBroker", new { id = id }, broker);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
