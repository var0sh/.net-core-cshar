using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;
using static _1_entity_siniflarinin_hazirlanmasi.ShopContext;
using _2_scaffolding_database_and_linq_query.Data.EfCore;

namespace _1_entity_siniflarinin_hazirlanmasi {
    public class ShopContext : DbContext {
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder
            .UseLoggerFactory(MyLoggerFactory)
                .UseMySql(@"server=localhost;port=3306;database=northwind;user=root;password=12345;", new MySqlServerVersion(new Version(8, 0, 28)));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { // -> Fluent API
            
        }

    
    

        public class Program {
        static void Main() {
            using (var db = new NorthwindContext()) {
                // *** Tüm müşteri kayıtlarını getiriniz
                // var customers = db.Customers.ToList();
                // foreach (var customer in customers) {
                //     System.Console.WriteLine(customer.FirstName + " " + customer.LastName);
                // }

                // *** Tüm müşteri kayıtlarının sadece firstname ve lastname bilgilerini getiriniz
                // var customers = db.Customers.Select(c => new {
                //     c.FirstName,
                //     c.LastName
                // });
                // foreach (var customer in customers) {
                //     System.Console.WriteLine(customer.FirstName + " " + customer.LastName);
                // }

                // *** New York'da yaşayan müşterileri isim sırasına göre getiriniz
                // var customers = db.Customers
                //     .Where(i => i.City == "New York")
                //     .Select(p => new {
                //         p.FirstName,
                //         p.LastName  
                //     })
                //     .ToList();
                // foreach (var customer in customers) {
                //     System.Console.WriteLine(customer.FirstName + " " + customer.LastName);
                // }

                // *** "Beverages" kategorisine ait ürünlerin isimlerini getiriniz
                // var productNames = db.Products
                //     .Where(p => p.Category == "Beverages")
                //     .Select(p => p.ProductName)
                //     .ToList();
                // foreach (var name in productNames) {
                //     System.Console.WriteLine(name);
                // } 

                // *** En son eklenen 5 ürün bilgisini alınız
                // var products = db.Products
                //     .OrderByDescending(p => p.Id)
                //     .Select(p => p.ProductName)
                //     .Take(5);
                // foreach (var prd in products) {
                //     System.Console.WriteLine(prd);
                // }

                // *** Fiyatı 10-30 arasında olan ürünlerin isim ve fiyat bilgilerini alınız
                // var products = db.Products
                //     .Where(p => p.ListPrice >= 10 && p.ListPrice <= 30)
                //     .Select(p => new {
                //         p.ListPrice,
                //         p.ProductName
                //     })
                //     .ToList();
                // foreach (var prd in products) {
                //     System.Console.WriteLine($"name: {prd.ProductName} - price: {prd.ListPrice}");
                // }

                // *** "Beverages" kategorisinde ki ürünlerin ortalama fiyatı nedir
                // var ortalama = db.Products
                //     .Where(p => p.Category == "Beverages")
                //     .Select(p => p.ListPrice)
                //     .Average(p => p);
                // System.Console.WriteLine(ortalama); 

                // *** "Beverages" kategorisinde kaç ürün vardır
                // var adet = db.Products
                //     .Where(p => p.Category == "Beverages")
                //     .Select(p => p.Id)
                //     .Count();
                // System.Console.WriteLine(adet);

                // *** "Beverages" ve "Condiments" kategorilerinde ki ürünlerin toplam fiyatı nedir
                // var toplam = db.Products
                //     .Where(p => p.Category == "Beverages" || p.Category == "Condiments")
                //     .Select(p => p.ListPrice)
                //     .Sum(p => p);
                // System.Console.WriteLine(toplam);

                // *** "Tea" kelimesini içeren ürünleri getiriniz
                // var products = db.Products
                //     .Where(p => p.ProductName.Contains("Tea"))
                //     .Select(p => p.ProductName);
                // foreach (var product in products) {
                //     System.Console.WriteLine(product);
                // }

                // *** En pahalı ve en ucuz ürün hangisidir
                var minPrice = db.Products.Min(p => p.ListPrice);
                var maxPrice = db.Products.Max(p => p.ListPrice);
                System.Console.WriteLine($"min: {minPrice} - max: {maxPrice}");

                var minProduct = db.Products
                    .Where(p => p.ListPrice == (db.Products.Min(e => e.ListPrice)))
                    .FirstOrDefault();
                System.Console.WriteLine($"name: {minProduct.ProductName} - price: {minProduct.ListPrice}");
                
                var maxProdduct = db.Products
                    .Where(p => p.ListPrice == (db.Products.Max(e => e.ListPrice)))
                    .FirstOrDefault();
                System.Console.WriteLine($"name: {maxProdduct.ProductName} - price: {maxProdduct.ListPrice}");
            }
        }
    }
    }
}