using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _2_scaffolding_database_and_linq_query.Data.EfCore
{
    public class CustomerOrder
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public int OrderCount { get; set; }
    }
    public class CustomNorthwindContext : NorthwindContext
    {
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public CustomNorthwindContext()
        {

        }
        public CustomNorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CustomerOrder>(entity =>
            {
                entity.HasNoKey();
                entity.Property(e => e.FirstName).HasColumnName("first_name");
                entity.Property(e => e.CustomerId).HasColumnName("id");
                entity.Property(e => e.OrderCount).HasColumnName("count");
            });
        }
    }
}