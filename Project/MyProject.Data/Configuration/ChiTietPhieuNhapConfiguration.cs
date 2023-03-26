using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using MyProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data.Configuration
{
    public class ChiTietPhieuNhapConfiguration : IEntityTypeConfiguration<ChiTietPhieuNhap>
    {
        public void Configure(EntityTypeBuilder<ChiTietPhieuNhap> builder)
        {
            builder.ToTable("ChiTietPhieuNhap");
            builder.HasKey(p => p.ID);
            builder.Property(x => x.ID).UseIdentityColumn(1, 1);
            builder.HasOne(p => p.PhieuNhap).WithMany(p => p.ChiTietPhieuNhaps).HasForeignKey(x => x.PhieuNhapId);
            builder.HasOne(p => p.Product).WithMany(p => p.ChiTietPhieuNhaps).HasForeignKey(x => x.ProductId);
        }
    }
}
