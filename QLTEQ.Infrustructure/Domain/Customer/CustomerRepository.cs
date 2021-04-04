using QLTEQ.Domain.Customers;
using QLTEQ.Domain.Customers.Orders;
using QLTEQ.DTOPattern.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTEQ.Infrastructure.Domain.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly postgrecontext _context;

        public CustomerRepository(postgrecontext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(CustomerAddRequest customer)
        {
            QLTEQ.Domain.Customers.Customer cust= new QLTEQ.Domain.Customers.Customer();
            QLTEQ.Domain.Customers.Address address = new QLTEQ.Domain.Customers.Address(customer.Address.StreetAddress, customer.Address.City, customer.Address.State, customer.Address.ZipCode);
            cust.id = customer.Id;
            cust.Address = address;
             this._context.Customers.Add(cust);
            this._context.SaveChanges();
        }

        public CustomerGetResponse GetById(CustomerAddRequest customerAddRequest)
        {
            return  this._context.Customers.Select(a=> new CustomerGetResponse()
            { 
                  Id=a.id,
                  name=a.name,
                  email=a.email
            }).FirstOrDefault(x => x.Id == customerAddRequest.Id);
        }
    }
}
