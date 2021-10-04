using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LogicTestQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogicTest7Controller : ControllerBase
    {
        // GET: api/<LogicTest7Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> excludeList = new List<string> { "bike", "boat", "car" };
            List<string> sentense = new List<string> { "I love bikes", "I have boat and car", "I no have truck" };
            var includeList = sentense.Where(m => !excludeList.Any(r => m.Contains(r)));
            return includeList;
        }

        // GET api/<LogicTest7Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LogicTest7Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LogicTest7Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LogicTest7Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
