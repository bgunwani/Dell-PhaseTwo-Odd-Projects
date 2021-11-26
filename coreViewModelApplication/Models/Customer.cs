using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreViewModelApplication.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Amount { get; set; }
    }
}
