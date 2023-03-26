using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Data.Entities;

namespace MyProject.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.ProductName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Slug).HasColumnType("nvarchar").HasMaxLength(256).IsRequired();
            builder.Property(x => x.ProductDetails).HasColumnType("ntext").IsRequired();
            builder.Property(x => x.Price).HasColumnType("decimal").IsRequired();
            builder.Property(x => x.Views).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.Shop).WithMany(x => x.Products).HasForeignKey(x => x.ShopId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}