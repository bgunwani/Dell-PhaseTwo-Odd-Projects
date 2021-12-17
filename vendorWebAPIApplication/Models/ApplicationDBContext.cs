using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vendorWebAPIApplication.Models
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User{ UserId = 1, Name = "king", Type = "admin" },
                new User { UserId = 2, Name = "kochhar", Type = "user" },
                new User { UserId = 3, Name = "sarah", Type = "user" }
                );
        }
    }
}
