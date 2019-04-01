using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    public class BrokerController : Controller
    {
        ILogger _logger;
        private readonly IRepository<Broker> _broker;
        public BrokerController(IRepository<Broker> broker,ILogger<BrokerController> logger) { _broker = broker; _logger = logger; }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("entered the api/broker endpoint");
                var broker = _broker.getAll();
                return Ok(broker);
            
        }

        // GET api/<controller>/5
        [HttpGet("{id}",Name ="getBroker")]
        public IActionResult Get(int id)
        {
                var broker = _broker.get(id);
                if (broker == Enumerable.Empty<Broker>())
                {
                    return StatusCode(404, "The resource specified is not found");
                }
                return Ok(broker);  
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody]Broker value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            
            _broker.add(value);
            return CreatedAtRoute("getBroker",new {id=value.id},value);

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Broker value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _broker.update(id, value);
            return CreatedAtRoute("getBroker", new { id = id }, value);



        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _broker.delete(id);
            return Ok("Deleted successfully");
         }
    }
    }

