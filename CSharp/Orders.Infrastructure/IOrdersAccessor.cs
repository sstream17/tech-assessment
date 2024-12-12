using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Core.Contracts;

namespace Orders.Infrastructure
{
    public interface IOrdersAccessor
    {
        Task Add(AddOrder addOrder);

        Task Update(UpdateOrder updateOrder);

        Task Cancel();
    }
}
