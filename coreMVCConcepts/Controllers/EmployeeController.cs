using coreMVCConcepts.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMVCConcepts.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();
        public IActionResult Index()
        {
            var employees = employeeRepository.GetEmployees();
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            var employee = employeeRepository.GetEmployeeById(id);
            return View(employee);
        }
    }
}
