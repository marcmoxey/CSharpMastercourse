using EFHomework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework.DataAccess
{
    public class PersonContext: DbContext
    {
        public DbSet<Person> Peoples { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Employer> Employers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json");
            var config = builder.Build();
            options.UseSqlServer(config.GetConnectionString("Default"));
        }
    }
}
