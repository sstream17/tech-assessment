using Microsoft.EntityFrameworkCore;
using Orders.Infrastructure.EntityFramework.Models;

namespace Orders.Infrastructure.EntityFramework
{
    public class OrdersDbContext(DbContextOptions<OrdersDbContext> dbContextOptions) : DbContext(dbContextOptions), IOrdersDbContext
    {
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Item> Items { get; set; }

        public async Task<List<Order>> GetOrdersByCustomerId(int customerId)
        {
            return await Orders.Where(order => order.Customer.Id == customerId).ToListAsync().ConfigureAwait(false);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(e => e.Items)
                .WithMany(e => e.Orders)
                .UsingEntity<OrderItem>();
        }

    }
}
