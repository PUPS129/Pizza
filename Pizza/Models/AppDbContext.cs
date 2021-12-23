using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizza.Models.Entities;

namespace Pizza.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

     
       public DbSet<Comment> Comments { get; set; }


        public DbSet<OrderDetail> orderDetails { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Category>()
          .HasMany(e => e.products)
          .WithOne(e => e.Category)
          .HasForeignKey(e => e.CategoryID);

            

            modelBuilder.Entity<Products>()
          .HasMany(e => e.OrderProduct)
          .WithOne(e => e.Product)
          .HasForeignKey(e => e.productID);
            modelBuilder.Entity<UserOrder>()
        .HasMany(e => e.OrderProduct)
        .WithOne(e => e.Order)
        .HasForeignKey(e => e.orderID);



            //Добавление роли пользователя

           

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-5557e12qrtyu",
                Name = "user",
                NormalizedName = "USER",

            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e8827qw3245",
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@email.com",
                NormalizedEmail = "USER@EMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "+79054058055",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "userpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-5557e12qrtyu",
                UserId = "3b62472e-4f66-49fa-a20f-e8827qw3245"
            });




            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber="+79043846733",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

     




        }
    }
}
