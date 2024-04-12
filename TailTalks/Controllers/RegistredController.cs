using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TailTalks.Data;

namespace TailTalks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistredController : ControllerBase
    {
        // GET: api/<RegistredController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RegistredController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegistredController>
        [HttpPost]
        [Route("Registration")]
        public IActionResult Registration([FromBody] GetRegistration value)
        {
            return InsertData.RegistredInsert(value);
        }

        // PUT api/<RegistredController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegistredController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
