using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Orders.Core;

namespace Orders.Infrastructure.EntityFramework.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual Customer Customer { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public Status Status { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public decimal Total { get; set; }
    }
}
