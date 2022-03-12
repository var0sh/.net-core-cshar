using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace _1_entity_siniflarinin_hazirlanmasi {
    public class ShopContext : DbContext {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder
            .UseLoggerFactory(MyLoggerFactory)
                .UseSqlite("Data Source=shop.db");
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
            UpdateProduct();
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
        static void GetAllProducts() {
            using (var context = new ShopContext()) {
                var products = context
                    .Products
                        .Select(prd => new {
                            prd.Name,
                            prd.Price
                        } )
                            .ToList();

                foreach (var prd in products) {
                    System.Console.WriteLine($"name: {prd.Name}\nprice: {prd.Price}");
                }
            }
        }
        static void GetProductById(int id) {
            using (var context = new ShopContext()) {
                var product = context.Products
                    .Where(prd => prd.Id == id)
                        .Select(prd => new {
                            prd.Name,
                            prd.Price
                        } )
                            .FirstOrDefault();
                if (product != null)
                    System.Console.WriteLine($"name: {product.Name}\nprice: {product.Price}");
                else
                    System.Console.WriteLine("girilen id'de kayıt bulunamadı");
            }
        }
        static void GetProductByName(string name) {
            using (var context = new ShopContext()) {
                var products = context.Products
                    .Where(prd => prd.Name.ToLower().Contains(name.ToLower()))
                        .Select(prd => new {
                            prd.Name,
                            prd.Price
                        } )
                            .ToList();
                foreach (var prd in products) {
                    System.Console.WriteLine($"name: {prd.Name}\nprice: {prd.Price}");
                }
            }
        }
        static void UpdateProduct() {
                // ** En Doğrusu Bu - Diğerlerinde Sadece PRİCE Alanını Güncellesek Bile Diğer Alanlarda Güncelleniyor
            // using (var db = new ShopContext()) {
            //     var entity = new Product() {Id = 2};
            //     db.Products.Attach(entity);
            //     entity.Price = 1200;
            //     db.SaveChanges();
            //     System.Console.WriteLine("güncelleme yapıldı");
            // }

            using (var db = new ShopContext()) {
                var prd = db.Products.Where(prd => prd.Id == 2).FirstOrDefault();

                if (prd != null) {
                    prd.Price = 2000;
                    db.Products.Update(prd);
                    db.SaveChanges();
                    System.Console.WriteLine("güncellendi");
                }
            }


            // using (var db = new ShopContext()) {
            //     var p = db.Products.AsNoTracking().Where(i => i.Id == 2).FirstOrDefault();

            //     if (p != null) {
            //         p.Price *= 1.2m;
            //         db.SaveChanges();
            //         System.Console.WriteLine("güncelleme yapıldı");
            //     } else {
            //         System.Console.WriteLine("güncelleme yapılamadı");
            //     }

            // }
        }
    }
}