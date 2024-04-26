using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using TailTalks.Helper;
using TailTalks.Models;

namespace TailTalks.Data
{
    public class Request
    {
        private readonly ILogger _logger;
        public Request(ILogger logger)
        {
            _logger = logger;
        }
        public Leads GetAnyLead()
        {
            try
            {
                using (var db = new ApiContext())
                    return db.Leads.FirstOrDefault();
            }
            catch(Exception ex)
            {
                _logger.LogError("RegistredInsert:" + ex.Message);
                return null;
            }
        }
    }
}
