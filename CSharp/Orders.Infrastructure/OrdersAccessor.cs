using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Orders.Core.Contracts;
using Orders.Infrastructure.EntityFramework;
using Orders.Infrastructure.EntityFramework.Models;

namespace Orders.Infrastructure
{
    public class OrdersAccessor(IMapper mapper, IOrdersDbContext ordersDbContext) : IOrdersAccessor
    {
        private IMapper Mapper { get; } = mapper;

        private IOrdersDbContext OrdersDbContext { get; } = ordersDbContext;

        public async Task Add(AddOrder addOrder)
        {
            try
            {
                var order = Mapper.Map<Order>(addOrder.Order);
                await OrdersDbContext.Orders.AddAsync(order).ConfigureAwait(false);
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
