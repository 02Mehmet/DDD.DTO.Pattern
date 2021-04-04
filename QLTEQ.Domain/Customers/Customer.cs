using System;
using System.Collections.Generic;
using System.Linq;
using QLTEQ.Domain.Customers.Orders;
using QLTEQ.Domain.Customers.Orders.Events;
using QLTEQ.Domain.Customers.Rules;
using QLTEQ.Domain.ForeignExchange;
using QLTEQ.Domain.Products;
using QLTEQ.Domain.SeedWork;
using QLTEQ.Domain.SharedKernel;

namespace QLTEQ.Domain.Customers
{
    public class Customer : Entity, IAggregateRoot
    {
        public string id { get;  set; }

        public string email { get; set; }

        public string name { get; set; }

        public string tcid { get; set; }

        public string gender { get; set; }

        public bool welcomeEmailWasSent { get; set; }

        public int age { get; set; }

        public Address Address { get; set; }

        public void MarkAsWelcomedByEmail()
        {
            this.welcomeEmailWasSent = true;
        }
    }
}