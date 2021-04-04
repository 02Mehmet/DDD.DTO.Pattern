using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLTEQ.Domain.Customers.Orders;
using QLTEQ.Domain.SeedWork;
using QLTEQ.DTOPattern.ViewModel;
using QLTEQ.Infrastructure.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace QLTEQ.WEBAPI.Controllers
{
    [Route("api/v1/customer")]
    [ApiController]
    public class Customer : ControllerBase
    {
        private  ICustomerRepository _customerRepository;

        public Customer(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        [HttpPost]
        [Route("getcustomer")]
        public CustomerGetResponse GetCustomerById(CustomerAddRequest customer)
        {
             var result=this._customerRepository.GetById(customer);

            return result;
        }

        [HttpPost]
        [Route("savecustomer")]
        public void SaveCustomer(CustomerAddRequest customer)
        {
            this._customerRepository.Add(customer);
        }
    }
}
