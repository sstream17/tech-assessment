using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Orders.Infrastructure.EntityFramework.Models;

namespace Orders.Infrastructure.EntityFramework
{
    public class OrdersDbContext(DbContextOptions<OrdersDbContext> dbContextOptions) : DbContext(dbContextOptions), IOrdersDbContext
    {
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(e => e.Items)
                .WithMany(e => e.Orders)
                .UsingEntity<OrderItem>();
        }

    }
}
