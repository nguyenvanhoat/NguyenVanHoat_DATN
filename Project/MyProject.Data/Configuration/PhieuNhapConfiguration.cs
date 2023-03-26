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
    public class PhieuNhapConfiguration : IEntityTypeConfiguration<PhieuNhap>
    {
        public void Configure(EntityTypeBuilder<PhieuNhap> builder)
        {
            builder.ToTable("PhieuNhap");
            builder.HasKey(p => p.MaPhieu);
            builder.Property(x => x.MaPhieu).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.BenGiao).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.NgayGiao).HasColumnType("DateTime").HasMaxLength(50).IsRequired();
            builder.Property(x => x.NguoiNhan).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
        }
    }
}
