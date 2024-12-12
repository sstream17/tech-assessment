namespace Orders.Infrastructure.EntityFramework.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ItemId { get; set; }
    }
}
