using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Core.Contracts
{
    public class UpdateOrder
    {
        public int Id { get; set; }

        public OrderBody Order { get; set; }
    }
}
