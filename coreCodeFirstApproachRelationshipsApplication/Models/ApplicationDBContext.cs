using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstApproachRelationshipsApplication.Models
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }
        public DbSet<Novel> Novels { get; set; }
        public DbSet <Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<NovelCategory>().HasKey(c => new { c.NovelId, c.CategoryId });

            modelBuilder.Entity<NovelCategory>()
                .HasOne(c => c.Novel)
                .WithMany(c => c.NovelCategories)
                .HasForeignKey(c => c.NovelId);

            modelBuilder.Entity<NovelCategory>()
                .HasOne(c => c.Category)
                .WithMany(c => c.NovelCategories)
                .HasForeignKey(c => c.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
