using Microsoft.EntityFrameworkCore;
using Orders.Core.Contracts;
using Orders.Infrastructure.EntityFramework;

namespace Orders.Infrastructure
{
    public class OrdersAccessor(IOrdersDbContext ordersDbContext) : IOrdersAccessor
    {
        private IOrdersDbContext OrdersDbContext { get; } = ordersDbContext;

        public async Task Add(AddOrder addOrder)
        {
            try
            {
                // TODO: map incoming order object to DB object
                await OrdersDbContext.Orders.AddAsync(addOrder).ConfigureAwait(false);
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public Task Cancel()
        {
            throw new NotImplementedException();
        }

        public Task Update(UpdateOrder updateOrder)
        {
            throw new NotImplementedException();
        }
    }
}
