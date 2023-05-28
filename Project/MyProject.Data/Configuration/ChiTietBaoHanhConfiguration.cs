using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data.Configuration
{
    public class ChiTietBaoHanhConfiguration : IEntityTypeConfiguration<ChiTietBaoHanh>
    {
        public void Configure(EntityTypeBuilder<ChiTietBaoHanh> builder)
        {
            builder.ToTable("ChiTietBaoHanh");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.BaoHanh).WithMany(x => x.ChiTietBaoHanhs).HasForeignKey(x => x.BaoHanhId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
