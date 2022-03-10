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
           
       }
    }
}