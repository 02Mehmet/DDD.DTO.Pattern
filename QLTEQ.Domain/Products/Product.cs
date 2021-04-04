using System;
using System.Collections.Generic;
using System.Linq;
using QLTEQ.Domain.SeedWork;
using QLTEQ.Domain.SharedKernel;

namespace QLTEQ.Domain.Products
{
    public class Product : Entity, IAggregateRoot
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public int Quantity { get; private set; }

        public string Type { get; private set; }

        public decimal Amount { get; private set; }

        //private List<ProductPrice> _prices;

        //private Product()
        //{

        //}
    }
}