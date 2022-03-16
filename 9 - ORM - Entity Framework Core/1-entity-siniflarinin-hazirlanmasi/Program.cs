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
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

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
    public class User {
        public User () {
            this.Addresses = new List<Address>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }
    }
    public class Address {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }

    public class Program {
        static void Main() {

                //  ** Insert sorgusu ile veri ekleme
            // InsertUsers();
            // InsertAddresses();
 
                //  ** Navigation Property'leri kullanarak veri ekleme
            using (var db = new ShopContext()) {
                var user = db.Users.FirstOrDefault(i => i.UserName == "Taha Akçatepe");

                if (user != null) {
                    user.Addresses.AddRange(
                        new List<Address>() { 
                            new Address() {FullName = "Taha Akçatepe", Title = "iş adresi 4", Body = "Eskişehir"},
                            new Address() {FullName = "Taha Akçatepe", Title = "iş adresi 5", Body = "Eskişehir"},
                            new Address() {FullName = "Taha Akçatepe", Title = "iş adresi 6", Body = "Eskişehir"},
                        }
                    );
                    db.SaveChanges();
                }    
            }
        }

        static void InsertUsers() {
            var users = new List<User>() {
                new User() { UserName ="Furkan Akçatepe", Email ="abc@gmail.com" },
                new User() { UserName = "Taha Akçatepe", Email = "def@gmail.com" },
                new User() { UserName = "Ayşe Akçatepe", Email = "ghi@gmail.com" },
                new User() { UserName = "Halil Akçatepe", Email = "jkl@gmail.com" }
            };

            using (var db = new ShopContext()) {
                db.Users.AddRange(users);
                db.SaveChanges();
            }
        }
        static void InsertAddresses() {
            var addresses = new List<Address>() {
                new Address() { FullName = "Furkan Akçatepe", Title = "Ev adresi", Body = "Eskişehir", UserId = 1 },
                new Address() { FullName = "Ayşe Akçatepe", Title = "İş adresi", Body = "Eskişehir", UserId = 3 },
                new Address() { FullName = "Halil Akçatepe", Title = "İş adresi", Body = "Eskişehir", UserId = 4 },
                new Address() { FullName = "Taha Akçatepe", Title = "İş adresi", Body = "Eskişehir", UserId = 2 },
                new Address() { FullName = "Furkan Akçatepe", Title = "Ev adresi", Body = "Eskişehir", UserId = 1 },
                new Address() { FullName = "Ayşe Akçatepe", Title = "Ev adresi", Body = "Eskişehir", UserId = 3 }
            };

            using (var db = new ShopContext()) {
                db.Addresses.AddRange(addresses);
                db.SaveChanges();
            }
        }

    }
}