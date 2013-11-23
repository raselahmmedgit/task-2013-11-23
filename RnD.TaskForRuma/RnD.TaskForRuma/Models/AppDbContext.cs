using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RnD.TaskForRuma.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }

    #region Initial data

    // Change the base class as follows if you want to drop and create the database during development:
    //public class DBInitializer : DropCreateDatabaseAlways<AppDbContext>
    //public class DBInitializer : CreateDatabaseIfNotExists<AppDbContext>
    public class DBInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            // Create default categories.
            var categories = new List<Category>
                            {
                                new Category { CategoryId=1, Name = "X"},
                                new Category {CategoryId=2, Name = "Y"},
                                new Category {CategoryId=3, Name = "Z"},
                            };

            categories.ForEach(c => context.Categories.Add(c));

            context.SaveChanges();

            var subCategories = new List<SubCategory>
                            {
                                new SubCategory { SubCategoryId=1, Name = "A", CategoryId=1},
                                new SubCategory {SubCategoryId=2, Name = "B", CategoryId=1},
                                new SubCategory {SubCategoryId=3, Name = "C", CategoryId=1},
                                new SubCategory {SubCategoryId=4, Name = "D", CategoryId=1},
                                new SubCategory {SubCategoryId=5, Name = "E", CategoryId=1},
                                new SubCategory {SubCategoryId=6, Name = "F", CategoryId=1},
                                new SubCategory {SubCategoryId=7, Name = "G", CategoryId=1},

                            };

            subCategories.ForEach(c => context.SubCategories.Add(c));

            context.SaveChanges();

            // Create some products.
            var products = new List<Product> 
                        {
                            new Product {ProductId=1, Name="Apple", Rate=15, SubCategoryId=1},
                            new Product {ProductId=2, Name="Mango", Rate=20, SubCategoryId=1},
                            new Product {ProductId=3, Name="Orange", Rate=15, SubCategoryId=1},
                            new Product {ProductId=4, Name="Banana", Rate=20, SubCategoryId=1},
                            new Product {ProductId=5, Name="Licho", Rate=15, SubCategoryId=1},
                            new Product {ProductId=6, Name="Jack Fruit", Rate=20, SubCategoryId=1},

                            new Product {ProductId=7, Name="Toyota", Rate=15000, SubCategoryId=2},
                            new Product {ProductId=8, Name="Nissan", Rate=20000, SubCategoryId=2},
                            new Product {ProductId=9, Name="Tata", Rate=50000, SubCategoryId=2},
                            new Product {ProductId=10, Name="Honda", Rate=20000, SubCategoryId=2},
                            new Product {ProductId=11, Name="Kimi", Rate=50000, SubCategoryId=2},
                            new Product {ProductId=12, Name="Suzuki", Rate=20000, SubCategoryId=2},
                            new Product {ProductId=13, Name="Ferrari", Rate=50000, SubCategoryId=2},

                            new Product {ProductId=14, Name="T Shirt", Rate=20000, SubCategoryId=3},
                            new Product {ProductId=15, Name="Polo Shirt", Rate=50000, SubCategoryId=3},
                            new Product {ProductId=16, Name="Shirt", Rate=200, SubCategoryId=3},
                            new Product {ProductId=17, Name="Panjabi", Rate=500, SubCategoryId=3},
                            new Product {ProductId=18, Name="Fotuya", Rate=200, SubCategoryId=3},
                            new Product {ProductId=19, Name="Shari", Rate=500, SubCategoryId=3},
                            new Product {ProductId=19, Name="Kamij", Rate=400, SubCategoryId=3},

                            new Product {ProductId=20, Name="History", Rate=20000, SubCategoryId=4},
                            new Product {ProductId=21, Name="Fire Out", Rate=50000, SubCategoryId=4},
                            new Product {ProductId=22, Name="Apex", Rate=200, SubCategoryId=5},
                            new Product {ProductId=23, Name="Bata", Rate=500, SubCategoryId=5}

                        };

            products.ForEach(p => context.Products.Add(p));

            context.SaveChanges();

        }
    }

    #endregion
}