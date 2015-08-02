using ProductManagement.datalayer.Mappings;
using ProductManagement.domain;
using System.Data.Entity;

namespace ProductManagement.datalayer
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMappings());
            base.OnModelCreating(modelBuilder);
        }
    }
}
