using System;
using QLTEQ.Domain.Customers.Orders;
using QLTEQ.Domain.SeedWork;

namespace QLTEQ.Domain.Payments
{
    public class PaymentCreatedEvent
    {
        public PaymentCreatedEvent(PaymentId paymentId, OrderId orderId)
        {
            this.PaymentId = paymentId;
            this.OrderId = orderId;
        }

        public PaymentId PaymentId { get; }

        public OrderId OrderId { get; }
    }
}