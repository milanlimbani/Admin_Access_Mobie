using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Models
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Like> like { get; set; }
        public DbSet<UserHistory> UserHistorie { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                 new Category() { Id = 1, Name = "Mobiles" },
                 new Category() { Id = 2, Name = "Accessories" });

            modelBuilder.Entity<SubCategory>().HasData(
               new SubCategory() { Id = 1, Name = "Noise", CatId = 1 },
               new SubCategory() { Id = 2, Name = "Samsung", CatId = 1 },
               new SubCategory() { Id = 3, Name = "Boat", CatId = 1 },
               new SubCategory() { Id = 4, Name = "Realme", CatId = 1 },
               new SubCategory() { Id = 5, Name = "Onepluse", CatId = 1 },
               new SubCategory() { Id = 6, Name = "Apple", CatId = 1 });

            modelBuilder.Entity<Product>().HasData(
            new Product() { Id = 1, Name = "Noise 10R pro", Qty = 10, Rate = 15000, Profile = "defaults.jpg", IsActive = true, CatId = 1, SubId = 1, Brand = "Noise", Generation = "4g", Color = "Black", Sims = 2, OS = "11", RAM = 6, ROM = 32 },
            new Product() { Id = 2, Name = "Samsung Note10 pro", Qty = 10, Rate = 18000, Profile = "defaults.jpg", IsActive = true, CatId = 1, SubId = 2, Brand = "Samsung", Generation = "4g", Color = "Blue", Sims = 2, OS = "11", RAM = 8, ROM = 64 },
            new Product() { Id = 3, Name = "Onepluse 10 pro", Qty = 10, Rate = 12000, Profile = "defaults.jpg", IsActive = true, CatId = 1, SubId = 5, Brand = "Onepluse", Generation = "5g", Color = "White", Sims = 2, OS = "11", RAM = 4, ROM = 128 },
            new Product() { Id = 4, Name = "Realme Note4 ", Qty = 10, Rate = 10000, Profile = "defaults.jpg", IsActive = true, CatId = 1, SubId = 4, Brand = "Realme", Generation = "5g", Color = "Red", Sims = 2, OS = "11", RAM = 6, ROM = 256 },
            new Product() { Id = 5, Name = "Apple 14", Qty = 10, Rate = 19000, Profile = "defaults.jpg", IsActive = true, CatId = 1, SubId = 6, Brand = "Apple", Generation = "5g", Color = "Green", Sims = 2, OS = "11", RAM = 8, ROM = 128 }
            );

            modelBuilder.Entity<Registration>().HasData(
           new Registration() { Id = 1, Username = "akshay", Email = "akshay@gmail.com", Password = "123" });

        }
    }
}

