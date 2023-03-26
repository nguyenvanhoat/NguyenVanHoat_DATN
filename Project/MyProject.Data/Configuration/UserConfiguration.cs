using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Data.Entities;

namespace MyProject.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUser");
            builder.Property(x => x.CreateAt).HasColumnType("Date");
            builder.Property(x => x.UpdateAt).HasColumnType("Date");
            builder.Property(x => x.DeleteAt).HasColumnType("Date");
        }
    }
}