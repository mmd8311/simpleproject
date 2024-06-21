using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace simpleproject.Entity
{
    public class EFCoreDbContext : DbContext
    {
        public EFCoreDbContext() { } // This one
        public EFCoreDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(q => q.Title).IsRequired().HasMaxLength(20);
            base.OnModelCreating(modelBuilder);
        }
    }
}
