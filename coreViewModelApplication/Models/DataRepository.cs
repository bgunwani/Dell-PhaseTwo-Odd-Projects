using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreViewModelApplication.Models
{
    public class DataRepository
    {
        public CustomerAddressModel DataSource()
        {
            Customer customer = new Customer()
            {
                CustomerId = 1001,
                Name = "King Kochhar",
                Gender = "Male",
                Amount = 12000
            };
            Address address = new Address()
            {
                StreetName = "Civil Lines",
                City = "Delhi",
                PinCode = "110086",
                Country = "India"
            };
            CustomerAddressModel customerAddressModel = new CustomerAddressModel()
            {
                Customer = customer,
                Address = address,
                Title = "Customer Address Information"
            };
            return customerAddressModel;
        }
    }
}
