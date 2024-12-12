namespace Orders.Core.Contracts
{
    public class OrderBody
    {
        public int Id { get; set; }

        public CustomerBody Customer { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public Status Status { get; set; }

        public ICollection<ItemBody> Items { get; set; }

        public decimal Total { get; set; }
    }
}
