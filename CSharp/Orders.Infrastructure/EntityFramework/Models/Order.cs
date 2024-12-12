using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Core;

namespace Orders.Infrastructure.EntityFramework.Models
{
    public class Order
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public Status Status { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public decimal Total { get; set; }

    }
}
