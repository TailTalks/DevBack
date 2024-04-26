using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using TailTalks.Data;
using TailTalks.Model;
using TailTalks.Models;

namespace TailTalks.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegistredController : ControllerBase
    {
        //private readonly ILoggerManager _logger;
        private readonly ILogger<RegistredController> _logger;
        private readonly InsertData _insertData;
        private readonly Request _request;
        public RegistredController(ILogger<RegistredController> logger)
        {
            _logger = logger;
            _insertData = new InsertData(_logger);
            _request = new Request(_logger);
        }

        /// <summary>
        /// Тестовый запрос на первую запись в таблице Leads
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("TestGetLead")]
        public Leads GetFirstLead()
        {
            return _request.GetAnyLead();
        }

        // GET api/<RegistredController>/5
        [HttpGet("{id}")]
        public string GetFirstLead(int id)
        {
            return "value";
        }

        /// <summary>
        /// Запись регистрационных данных
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Registration")]
        public IActionResult Registration([FromBody] GetRegistration value)
        {
            try
            {
                return _insertData.RegistredInsert(value);
            }
            catch (Exception e)
            {
                _logger.LogError("PostRegistration:" + e.Message);
                return NotFound();
            }
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
