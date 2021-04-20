using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationSystem.Models
{
    public class RegistrationDBContext : DbContext
    {
        public RegistrationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
