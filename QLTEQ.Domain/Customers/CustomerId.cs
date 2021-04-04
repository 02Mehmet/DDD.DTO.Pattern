using System;
using QLTEQ.Domain.SeedWork;

namespace QLTEQ.Domain.Customers
{
    public class CustomerId : TypedIdValueBase
    {
        public CustomerId(Guid value) : base(value)
        {
        }
    }
}