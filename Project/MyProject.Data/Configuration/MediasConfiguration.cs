using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data.Configuration
{
    public class MediasConfiguration : IEntityTypeConfiguration<Medias>
    {
        public void Configure(EntityTypeBuilder<Medias> builder)
        {
            builder.ToTable("Medias");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(p => p.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.HasOne(p => p.Product).WithMany(p => p.Medias).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
