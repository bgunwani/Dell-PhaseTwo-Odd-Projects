using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstApproachApplication.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EI4423A;Database=DemoDB;Integrated Security=true;");
            /*optionsBuilder.UseSqlServer("Server=DESKTOP-EI4423A;Database=DemoDB;User Id=sa;Password=sa@123456");*/
        }
    }
}
