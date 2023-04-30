using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyProject.Data.Configuration;
using MyProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MediasConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewsConfiguration());
            modelBuilder.ApplyConfiguration(new ShopConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuNhapConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietPhieuNhapConfiguration());
            modelBuilder.ApplyConfiguration(new DatLichConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            //modelBuilder.ApplyConfiguration(new WishListConfiguration());
            modelBuilder.ApplyConfiguration(new GiaXeConfiguration());

            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "User", NormalizedName = "USER" },
                new IdentityRole { Name = "Saler", NormalizedName = "SALER" }
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

            // -----------------------------------------------------------------------------

            // Seed Users

            var passwordHasher = new PasswordHasher<AppUser>();

            List<AppUser> users = new List<AppUser>()
            {
                 // imporant: don't forget NormalizedUserName, NormalizedEmail 
                         new AppUser {
                            UserName = "user2@hotmail.com",
                            NormalizedUserName = "USER2@HOTMAIL.COM",
                            Email = "user2@hotmail.com",
                            NormalizedEmail = "USER2@HOTMAIL.COM",
                        },

                        new AppUser {
                            UserName = "user3@hotmail.com",
                            NormalizedUserName = "USER3@HOTMAIL.COM",
                            Email = "user3@hotmail.com",
                            NormalizedEmail = "USER3@HOTMAIL.COM",
                        },
            };


            modelBuilder.Entity<AppUser>().HasData(users);

            ///----------------------------------------------------

            // Seed UserRoles


            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            // Add Password For All Users

            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "User.123");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "User.155");

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId =
            roles.First(q => q.Name == "User").Id
            });

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId =
            roles.First(q => q.Name == "Admin").Id
            });


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Medias> Medias { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        //public DbSet<WishList> WishLists { get; set; }
        public DbSet<DatLich> DatLiches{ get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<GiaXe> GiaXes { get; set; }
    }
}
