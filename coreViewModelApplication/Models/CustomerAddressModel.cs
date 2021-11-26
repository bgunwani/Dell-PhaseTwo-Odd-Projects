using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreViewModelApplication.Models
{
    public class CustomerAddressModel
    {
        public Customer Customer { get; set; }
        public Address Address { get; set; }
        public string Title { get; set; }
    }
}
