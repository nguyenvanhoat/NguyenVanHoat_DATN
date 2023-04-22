using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Data.Entities;

namespace MyProject.Data.Configuration
{
    public class ShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.ToTable("Shop");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.HasIndex(p => p.ShopName).IsUnique();
            builder.HasIndex(p => p.Slug).IsUnique();
            builder.Property(x => x.ShopName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Slug).HasColumnType("nvarchar").HasMaxLength(256).IsRequired();
        }
    }
}