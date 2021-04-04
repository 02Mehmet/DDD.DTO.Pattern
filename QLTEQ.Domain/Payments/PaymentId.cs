using System;
using QLTEQ.Domain.SeedWork;

namespace QLTEQ.Domain.Payments
{
    public class PaymentId : TypedIdValueBase
    {
        public PaymentId(Guid value) : base(value)
        {
        }
    }
}