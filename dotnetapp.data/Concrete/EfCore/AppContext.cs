using dotnetapp.entity;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.data.Concrete.EfCore
{
    public class AppContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=appDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<ProductCategory>()
                .HasKey(c=>new {c.CategoryId, c.ProductId});//key bilgileri
        }
    }
}