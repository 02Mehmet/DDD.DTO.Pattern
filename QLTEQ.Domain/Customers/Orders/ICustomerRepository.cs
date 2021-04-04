using QLTEQ.DTOPattern.ViewModel;
using System;
using System.Threading.Tasks;

namespace QLTEQ.Domain.Customers.Orders
{
    public interface ICustomerRepository
    {
        CustomerGetResponse GetById(CustomerAddRequest customer);

         void Add(CustomerAddRequest customer);
    }
}