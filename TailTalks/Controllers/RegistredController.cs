using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TailTalks.Data;
using TailTalks.Models;

namespace TailTalks.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegistredController : ControllerBase
    {
        /// <summary>
        /// Возвращает первый по списку лид
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Leads Get()
        {
            return GetData.GetValueLeads();
        }

        // GET <RegistredController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST <RegistredController>
        [HttpPost]
        [Route("Registration")]
        public IActionResult Registration([FromBody] GetRegistration value)
        {
            return InsertData.RegistredInsert(value);
        }

        // PUT <RegistredController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE <RegistredController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
