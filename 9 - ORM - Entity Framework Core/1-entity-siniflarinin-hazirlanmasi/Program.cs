using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;
using static _1_entity_siniflarinin_hazirlanmasi.ShopContext;

namespace _1_entity_siniflarinin_hazirlanmasi {
    public class ShopContext : DbContext {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder
            .UseLoggerFactory(MyLoggerFactory)
                .UseSqlite("Data Source=shop.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { // -> Fluent API
            modelBuilder.Entity<ProductCategory>()
                .HasKey(t => new {t.ProductId, t.CategoryId});

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductId);

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(pc => pc.CategoryId);

            // modelBuilder.Entity<ProductCategory>()
            //     .ToTable("UrunKategorileri"); //  Veri tabanın da bu tablonun isminin berlittiğimiz şekil de görünmesini sağlar

            // modelBuilder.Entity<User>()
            //     .HasIndex(u => u.UserName)
            //     .IsUnique();
        }
        public static class DataSeeding {
            public static void Seed(DbContext context) {
                if (context.Database.GetPendingMigrations().Count() == 0) {
                    if (context is ShopContext) {
                        ShopContext _context = context as ShopContext;

                        if (_context.Products.Count() == 0) {
                            _context.Products.AddRange(Products);
                        }

                        if (_context.Categories.Count() == 0) {
                            _context.Categories.AddRange(Categories);
                        }
                    }
                context.SaveChanges();
                }
            }
        private static Product[] Products = {
            new Product() { Name = "Phone 1", Price = 1000 },
            new Product() { Name = "Phone 2", Price = 2000 },
            new Product() { Name = "Phone 3", Price = 3000 },
            new Product() { Name = "Phone 4", Price = 4000 },
        };
        private static Category[] Categories = {
            new Category() { Name = "Telefon" },
            new Category() { Name = "Elektronik" },
            new Category() { Name = "Bilgisayar" },
        };
    }
    }
    public class Category {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
    public class Product {
        // [DatabaseGenerated(DatabaseGeneratedOption.None)] // -> PrimaryKey'in otomatik artmamasını belirtiyoruz
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity -> EF Core bir kereliğine değer üretir fakat artarak gitmez. 
        // public DateTime InsertedDate { get; set; } = DateTime.Now;

        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)] // 
        // public DateTime LastUpdatedDate { get; set; } = DateTime.Now;
        public List<ProductCategory> ProductCategories { get; set; }
    }
    
    [NotMapped] // -> DATA ANNOTATION - ProductCategory tablosunun veri tabanına eklenmemesini sağlar
    [Table("UrunKategorileri")] // -> DATA ANNOTATION - Veri tabanın da bu tablonun isminin berlittiğimiz şekil de görünmesini sağlar
    public class ProductCategory {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
    public class User {
        public User () {
            this.Addresses = new List<Address>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }
        public Customer Customer { get; set; }
    }
    public class Address {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
    public class Customer {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        [NotMapped]
        public string FullName { get; set; }
        public User User { get; set; }

        public int UserId { get; set; }
    }
    public class Supplier {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
    }

    public class Program {
        static void Main() {
            // *** One To Many Relation
                    //  ** Insert sorgusu ile veri ekleme
                // InsertUsers();
                // InsertAddresses();
    
                    //  ** Navigation Property'leri kullanarak veri ekleme
            //     using (var db = new ShopContext()) {
            //         var user = db.Users.FirstOrDefault(i => i.UserName == "Taha Akçatepe");

            //         if (user != null) {
            //             user.Addresses.AddRange(
            //                 new List<Address>() { 
            //                     new Address() {FullName = "Taha Akçatepe", Title = "iş adresi 4", Body = "Eskişehir"},
            //                     new Address() {FullName = "Taha Akçatepe", Title = "iş adresi 5", Body = "Eskişehir"},
            //                     new Address() {FullName = "Taha Akçatepe", Title = "iş adresi 6", Body = "Eskişehir"},
            //                 }
            //             );
            //             db.SaveChanges();
            //         }    
            //     }
            // }
            // static void InsertUsers() {
            //     var users = new List<User>() {
            //         new User() { UserName ="Furkan Akçatepe", Email ="abc@gmail.com" },
            //         new User() { UserName = "Taha Akçatepe", Email = "def@gmail.com" },
            //         new User() { UserName = "Ayşe Akçatepe", Email = "ghi@gmail.com" },
            //         new User() { UserName = "Halil Akçatepe", Email = "jkl@gmail.com" }
            //     };

            //     using (var db = new ShopContext()) {
            //         db.Users.AddRange(users);
            //         db.SaveChanges();
            //     }
            // }
            // static void InsertAddresses() {
            //     var addresses = new List<Address>() {
            //         new Address() { FullName = "Furkan Akçatepe", Title = "Ev adresi", Body = "Eskişehir", UserId = 1 },
            //         new Address() { FullName = "Ayşe Akçatepe", Title = "İş adresi", Body = "Eskişehir", UserId = 3 },
            //         new Address() { FullName = "Halil Akçatepe", Title = "İş adresi", Body = "Eskişehir", UserId = 4 },
            //         new Address() { FullName = "Taha Akçatepe", Title = "İş adresi", Body = "Eskişehir", UserId = 2 },
            //         new Address() { FullName = "Furkan Akçatepe", Title = "Ev adresi", Body = "Eskişehir", UserId = 1 },
            //         new Address() { FullName = "Ayşe Akçatepe", Title = "Ev adresi", Body = "Eskişehir", UserId = 3 }
            //     };

            //     using (var db = new ShopContext()) {
            //         db.Addresses.AddRange(addresses);
            //         db.SaveChanges();
            //     }
            // }
            // ***

            // *** One To One Relation
            // using (var db = new ShopContext()) {
            // var customer = new Customer() {IdentityNumber = "124123125", FirstName = "Taha", LastName = "Akçatepe", UserId = 2};
            // db.Customers.Add(customer);
            // db.SaveChanges();

            // var customer = new Customer() {
                // IdentityNumber = "124123125", 
                // FirstName = "Taha", 
                // LastName = "Akçatepe",
                // User = db.Users.FirstOrDefault(i => i.Id == 3)
            // };
            // db.Customers.Add(customer);
            // db.SaveChanges();

            //     var user = new User() {
            //         UserName = "deneme",
            //         Email = "deneme@gmail.com",
            //         Customer = new Customer() {
            //             FirstName = "Deneme",
            //             LastName = "DENEME",
            //             IdentityNumber = "34695345"
            //         }
            //     };
            //     db.Users.Add(user);
            //     db.SaveChanges();
            // }
            // ***

            // *** ManyToManyRelation
            // using (var db = new ShopContext()) {
            //     var products = new List<Product>() {
            //         new Product() {Name = "Phone 1", Price = 1000},
            //         new Product() {Name = "Phone 2", Price = 2000},
            //         new Product() {Name = "Phone 3", Price = 3000},
            //         new Product() {Name = "Phone 4", Price = 4000},
            //     };
            //     var categories = new List<Category>() {
            //         new Category() {Name = "Telefon"},
            //         new Category() {Name = "Elektronik"},
            //         new Category() {Name = "Bilgisayar"},
            //     };

            //     int[] ids = new int[2] {1, 2};
            //     var p = db.Products.Find(1);
            //     p.ProductCategories = ids.Select(categoryId => new ProductCategory() {
            //         CategoryId = categoryId,
            //         ProductId = p.Id
            //     }).ToList();

            //     db.Products.AddRange(products);
            //     db.Categories.AddRange(categories);

            //     db.SaveChanges();
            // }
            // ***

            // *** DataSeeding
            DataSeeding.Seed(new ShopContext());
            // ***
        }
    }
}