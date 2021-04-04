using QLTEQ.Domain.SeedWork;

namespace QLTEQ.Domain.Customers.Orders.Events
{
    public class OrderChangedEvent 
    {
        public OrderId OrderId { get; }

        public OrderChangedEvent(OrderId orderId)
        {
            this.OrderId = orderId;
        }
    }
}