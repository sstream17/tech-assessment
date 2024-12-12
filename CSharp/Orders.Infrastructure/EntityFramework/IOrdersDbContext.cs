using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Orders.Infrastructure.EntityFramework.Models;

namespace Orders.Infrastructure.EntityFramework
{
    public interface IOrdersDbContext
    {
        DbSet<Order> Orders { get; set; }

        DbSet<Customer> Customers { get; set; }

        DbSet<Item> Items { get; set; }

        int SaveChanges();
    }
}
