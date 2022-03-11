using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace _1_entity_siniflarinin_hazirlanmasi {
    public class ShopContext : DbContext {
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite("Data Source=shop.db");
    }
}
    public class Category {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Product {
        // primary key (Id, ProductId)
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
        
    public class Program {
        static void Main() {
            AddProduct();
        }

        static void AddProducts() {
            using (var db = new ShopContext()){
                var products = new List<Product> {
                    new Product {Name = "Samsung S5", Price = 2000},
                    new Product {Name = "Samsung S6", Price = 3000},
                    new Product {Name = "Samsung S7", Price = 4000},
                    new Product {Name = "Samsung S8", Price = 5000}
                };

                db.Products.AddRange(products);
                db.SaveChanges();

                System.Console.WriteLine("veriler eklendi");
            }
        }
        static void AddProduct() {
            using (var db = new ShopContext()){
                var product = new Product {Name = "Samsung 10", Price = 8000};
                db.Products.Add(product);
                db.SaveChanges();

                System.Console.WriteLine("veriler eklendi");
            }
        }
    }
}