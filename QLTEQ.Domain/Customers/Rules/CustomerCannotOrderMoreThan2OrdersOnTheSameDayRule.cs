using System.Collections.Generic;
using System.Linq;
using QLTEQ.Domain.Customers.Orders;
using QLTEQ.Domain.SeedWork;

namespace QLTEQ.Domain.Customers.Rules
{
    public class CustomerCannotOrderMoreThan2OrdersOnTheSameDayRule : IBusinessRule
    {
        private readonly IList<Order> _orders;

        public CustomerCannotOrderMoreThan2OrdersOnTheSameDayRule(IList<Order> orders)
        {
            _orders = orders;
        }

        public bool IsBroken()
        {
           return _orders.Count(x => x.IsOrderedToday()) >= 2;
        }

        public string Message => "You cannot order more than 2 orders on the same day.";
    }
}