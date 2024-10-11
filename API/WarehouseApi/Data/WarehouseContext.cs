using Microsoft.EntityFrameworkCore;
using WarehouseModels.Models;

namespace WarehouseApi.Data
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductCategory>().HasKey(ck => new { ck.ProductId, ck.CategoryId });
        }

        public DbSet<WarehouseModels.Models.Product> Product { get; set; }
        public DbSet<WarehouseModels.Models.Category> Category { get; set; }
        public DbSet<WarehouseModels.Models.ProductCategory> ProductCategory { get; set; }
    }
}
