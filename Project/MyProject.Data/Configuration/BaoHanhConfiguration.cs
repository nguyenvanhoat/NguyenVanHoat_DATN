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
    public class BaoHanhConfiguration : IEntityTypeConfiguration<BaoHanh>
    {
        public void Configure(EntityTypeBuilder<BaoHanh> builder)
        {
            builder.ToTable("BaoHanh");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
