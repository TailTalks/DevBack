using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using TailTalks.Models;


namespace TailTalks.Helper
{
    /// <summary>
    /// Класс контекста
    /// </summary>
    public class ApiContext : DbContext
    {
        public virtual DbSet<Leads> Leads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"));
        }

    }
}
