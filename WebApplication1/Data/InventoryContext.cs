using InventoryBeginners.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryBeginners.Data
{
    public class InventoryContext: DbContext
    {
        public InventoryContext(DbContextOptions options):base(options)
        {

        }


        public virtual DbSet<Unit> Units { get; set; } 
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        public virtual DbSet<ProductProfile> ProductProfiles { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Supplier> Suppliers { get; set; }


    }
}
