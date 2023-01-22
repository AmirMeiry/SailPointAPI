using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SailPointAPI.Models
{
    public class CitiesContext : DbContext
    {
        public CitiesContext(DbContextOptions<CitiesContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<City> Cities { get; set; }
    }
}
