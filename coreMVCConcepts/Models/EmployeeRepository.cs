using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMVCConcepts.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee() { EmployeeId=101, Name="King Kochhar", Salary=30000, Designation="Manager"},
            new Employee() { EmployeeId=102, Name="Shreya Sharma", Salary=24000, Designation="Developer"},
            new Employee() { EmployeeId=103, Name="Gautam Bhalla", Salary=26000, Designation="Tester"},
            new Employee() { EmployeeId=104, Name="Sarah Bowling", Salary=50000, Designation="Sr. Manager"},
        };
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public Employee GetEmployeeById(int employeeId)
        {
            return employees.FirstOrDefault(e => e.EmployeeId == employeeId);
        }
        public IList<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
