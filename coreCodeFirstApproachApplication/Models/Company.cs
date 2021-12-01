using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstApproachApplication.Models
{
    public class Company
    {
        // Scalar Properties
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        // Navigation Propeties
        public ICollection<Employee> Employees { get; set; }
    }
}
