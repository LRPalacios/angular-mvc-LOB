using ProductManagement.domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProductManagement.datalayer.Mappings
{
    public class ProductMappings:EntityTypeConfiguration<Product>
    {
        public ProductMappings()
        {
            Property(p => p.ProductName).HasMaxLength(60).IsRequired();
            Property(p => p.ProductCode).HasMaxLength(10).IsRequired()
                .HasColumnAnnotation("Unique",
                new IndexAnnotation(new []
                    {
                        new IndexAttribute("ProductCode_Index") { IsUnique = true }
                    }));
            Property(p => p.Description).HasMaxLength(100).IsRequired();
            Property(p => p.ReleaseDate).HasColumnType("Date").IsRequired();
            Property(p => p.Price).IsRequired();
        }
    }
}
