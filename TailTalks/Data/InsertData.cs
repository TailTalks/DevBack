using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using TailTalks.Helper;
using TailTalks.Models;

namespace TailTalks.Data
{

    public class InsertData
    {
        public static IActionResult RegistredInsert(GetRegistration value)    
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
    }
}
