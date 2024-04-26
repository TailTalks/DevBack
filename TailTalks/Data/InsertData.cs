using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using TailTalks.Helper;
using TailTalks.Model;
using TailTalks.Models;

namespace TailTalks.Data
{

    public class InsertData
    {
        //private readonly ILoggerManager _logger;
        private readonly ILogger _logger;
        public InsertData(ILogger logger)
        {
            _logger = logger;
        }
        public IActionResult RegistredInsert(GetRegistration value)    
        {
            try
            {
                using (var db = new ApiContext())
                {
                    var entity = new Leads();
                    entity.Name = value.Name;
                    entity.Email = value.Email;
                    entity.DateCreated = DateTime.UtcNow;
                    db.Leads.Add(entity);
                    db.SaveChanges();
                }
                return new OkResult();
            }
            catch (Exception ex)
            {
                _logger.LogError("RegistredInsert:" + ex.Message);
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}
