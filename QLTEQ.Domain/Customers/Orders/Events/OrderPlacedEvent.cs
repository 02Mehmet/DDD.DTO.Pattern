using System;
using QLTEQ.Domain.SeedWork;
using QLTEQ.Domain.SharedKernel;

namespace QLTEQ.Domain.Customers.Orders.Events
{
    public class OrderPlacedEvent
    {
        public OrderId OrderId { get; }

        public CustomerId CustomerId { get; }

        public MoneyValue Value { get; }

        public OrderPlacedEvent(
            OrderId orderId, 
            CustomerId customerId, 
            MoneyValue value)
        {
            this.OrderId = orderId;
            this.CustomerId = customerId;
            Value = value;
        }
    }
}