using QLTEQ.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTEQ.DTOPattern.ViewModel
{
    public class CustomerAddRequest
    {
        public string Id { get; set; }
        public AddressVM Address { get; set; }
    }

    public class CustomerGetResponse
    {
        public string Id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
    }
}
