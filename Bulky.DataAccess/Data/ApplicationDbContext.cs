using Bulky.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers{get;set;}//line-3355

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Action",
                    DisplayOrder = 1 
                },
                new Category
                {
                    Id = 2,
                    Name = "SciFi",
                    DisplayOrder=2
                },
                new Category
                {
                    Id=3,
                    Name = "History",
                    DisplayOrder=3
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "Praesent vitae sodales libero. praesent Molw",
                    ISBN = "SJJ0999999",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "Fortune of Time second",
                    Author = "Billy Spark second",
                    Description = "Praesent vitae sodales libero. praesent Molw second.",
                    ISBN = "SJJ7999099",
                    ListPrice = 199,
                    Price = 190,
                    Price50 = 185,
                    Price100 = 180,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Fortune of Time third",
                    Author = "Billy Spark third",
                    Description = "Praesent vitae sodales libero. praesent Molw third",
                    ISBN = "SJJ7999999",
                    ListPrice = 299,
                    Price = 290,
                    Price50 = 285,
                    Price100 = 280,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Fortune of Time fourth",
                    Author = "Billy Spark fourth",
                    Description = "Praesent vitae sodales libero. praesent Molw fourth",
                    ISBN = "SEEJJ7999999",
                    ListPrice = 399,
                    Price = 390,
                    Price50 = 385,
                    Price100 = 380,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Fortune of Time fifth",
                    Author = "Billy Spark fifth",
                    Description = "Praesent vitae sodales libero. praesent Molw fifth",
                    ISBN = "SJJ79999999",
                    ListPrice = 499,
                    Price = 490,
                    Price50 = 485,
                    Price100 = 480,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "Fortune of Time sixth",
                    Author = "Billy Spark sixth",
                    Description = "Praesent vitae sodales libero. praesent Molw sixth",
                    ISBN = "SJJZ7999999",
                    ListPrice = 599,
                    Price = 590,
                    Price50 = 585,
                    Price100 = 580,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
        }
    }
}
