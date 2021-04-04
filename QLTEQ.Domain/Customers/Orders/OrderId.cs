using System;
using QLTEQ.Domain.SeedWork;

namespace QLTEQ.Domain.Customers.Orders
{
    public class OrderId : TypedIdValueBase
    {
        public OrderId(Guid value) : base(value)
        {
        }
    }
}