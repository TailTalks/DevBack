using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TailTalks.Helper;
using TailTalks.Models;

namespace TailTalks.Data
{
    public class GetData
    {
        public static Leads GetValueLeads()
        {
            try
            {
                using (var db = new ApiContext())
                {
                    var s = db.Leads.FirstOrDefault();
                    return s;
                }
            }
            catch 
            {
                return null;
            }
        }
    }
}
