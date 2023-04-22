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
    public class GiaXeConfiguration : IEntityTypeConfiguration<GiaXe>
    {
        public void Configure(EntityTypeBuilder<GiaXe> builder)
        {
            builder.ToTable("GiaXe");
            builder.HasKey(p => p.Id);
            builder.Property(x => x.Id).HasColumnType("int").UseIdentityColumn(1, 1);
        }
    }
}
