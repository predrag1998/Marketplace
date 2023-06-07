//using Microsoft.AspNetCore.Mvc;
using Marketplace.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Marketplace.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Sedan", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SUV", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Sport", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Opel",
                    Price = 2000,
                    ProductionYear = 2010,
                    Location="Kumanovo",
                    Description = "Agila",
                    CreatedDate = DateTime.Now,
                    CategoryId=1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "Audi",
                    Price = 3000,
                    ProductionYear = 2015,
                    Location = "Kumanovo",
                    Description = "A6",
                    CreatedDate = DateTime.Now,
                    CategoryId = 2,
                    ImageUrl = ""
                },
               new Product
               {
                   Id = 3,
                   Title = "Peugeot",
                   Price = 4000,
                   ProductionYear = 2018,
                   Location = "Kumanovo",
                   Description = "106",
                   CreatedDate = DateTime.Now,
                   CategoryId = 3,
                   ImageUrl = ""
               });
            
        }
    }
}
