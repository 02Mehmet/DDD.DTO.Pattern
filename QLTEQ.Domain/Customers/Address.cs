using QLTEQ.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTEQ.Domain.Customers
{
    public class Address : ValueObjectAddress
    {
        [Key]
        public int Id { get; private set; }
        public string StreetAddress { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }

        public Address()
        {

        }

        public Address(string streetAddress, string city, string state, string zipCode)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return StreetAddress;
            yield return City;
            yield return State;
            yield return ZipCode;
        }
    }
}
