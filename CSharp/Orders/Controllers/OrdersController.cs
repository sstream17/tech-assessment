using Microsoft.AspNetCore.Mvc;
using Orders.Core.Contracts;
using Orders.Infrastructure;

namespace Orders.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        public OrdersController(IOrdersAccessor ordersAccessor)
        {
            OrdersAccessor = ordersAccessor;
        }

        private IOrdersAccessor OrdersAccessor { get; set; }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Add(AddOrder addOrder)
        {
            try
            {
                await OrdersAccessor.Add(addOrder).ConfigureAwait(false);
                return Ok();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{orderId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Cancel(int orderId)
        {
            try
            {
                await OrdersAccessor.Cancel(orderId).ConfigureAwait(false);
                return Ok();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPut("{orderId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(int orderId, [FromBody] AddOrder order)
        {
            try
            {
                var updateOrder = new UpdateOrder
                {
                    Id = orderId,
                    Order = order.Order,
                };
                await OrdersAccessor.Update(updateOrder).ConfigureAwait(false);
                return Ok();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
