using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreShoppingCartApplication.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Product>  Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id=1, Name="Product One", Image= "https://d3nn873nee648n.cloudfront.net/900x600/8384/5-SM205485.jpg", Price=234},
                new Product { Id = 2, Name = "Product Two", Image = "https://d3nn873nee648n.cloudfront.net/900x600/8384/5-SM205485.jpg", Price = 200 },
                new Product { Id = 3, Name = "Product Three", Image = "https://d3nn873nee648n.cloudfront.net/900x600/8384/5-SM205485.jpg", Price = 120 },
                new Product { Id = 4, Name = "Product Four", Image = "https://d3nn873nee648n.cloudfront.net/900x600/8384/5-SM205485.jpg", Price = 400 },
                new Product { Id = 5, Name = "Product Five", Image = "https://d3nn873nee648n.cloudfront.net/900x600/8384/5-SM205485.jpg", Price = 350 }
                );
        }
    }
}
