using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TailTalks.Data;
using TailTalks.Logging;

namespace TailTalks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistredController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public RegistredController(ILoggerManager logger)
        {
            _logger = logger;
        }

        // GET: api/<RegistredController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here is info message from the controller.");
            _logger.LogDebug("Here is debug message from the controller.");
            _logger.LogWarning("Here is warn message from the controller.");
            _logger.LogError("Here is error message from the controller.");

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
