using System;
using QLTEQ.Domain.SeedWork;

namespace QLTEQ.Domain.Products
{
    public class ProductId : TypedIdValueBase
    {
        public ProductId(Guid value) : base(value)
        {
        }
    }
}