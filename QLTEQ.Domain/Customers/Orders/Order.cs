using System;
using System.Collections.Generic;
using System.Linq;
using QLTEQ.Domain.ForeignExchange;
using QLTEQ.Domain.Products;
using QLTEQ.Domain.SeedWork;
using QLTEQ.Domain.SharedKernel;

namespace QLTEQ.Domain.Customers.Orders
{
    public class Order : Entity,IAggregateRoot
    {
        private string Id { get; set; }

        private bool _isRemoved { get; set; }

        private MoneyValue _value { get; set; }

        private MoneyValue _valueInEUR { get; set; }

        //private List<OrderProduct> _orderProducts { get; set; }

        private OrderStatus _status { get; set; }

        private DateTime _orderDate { get; set; }

        private DateTime? _orderChangeDate { get; set; }

        //private Order()
        //{
        //    this._orderProducts = new List<OrderProduct>();
        //    this._isRemoved = false;
        //}



        //internal void Remove()
        //{
        //    this._isRemoved = true;
        //}

        internal bool IsOrderedToday()
        {
            return this._orderDate.Date == SystemClock.Now.Date;
        }

        //internal MoneyValue GetValue()
        //{
        //    return _value;
        //}

        //private void CalculateOrderValue()
        //{
        //    _value = _orderProducts.Sum(x => x.Value);

        //    _valueInEUR = _orderProducts.Sum(x => x.ValueInEUR);
        //}
    }
}