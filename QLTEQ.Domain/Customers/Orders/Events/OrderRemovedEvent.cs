using QLTEQ.Domain.SeedWork;

namespace QLTEQ.Domain.Customers.Orders.Events
{
    public class OrderRemovedEvent
    {
        public OrderId OrderId { get; }

        public OrderRemovedEvent(OrderId orderId)
        {
            this.OrderId = orderId;
        }
    }
}