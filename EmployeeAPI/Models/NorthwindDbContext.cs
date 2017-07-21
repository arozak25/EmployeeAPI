using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Models
{
    public class NorthwindDbContext : DbContext
    {
        public DbSet<Employee> Employees {get; set;}

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Office;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
