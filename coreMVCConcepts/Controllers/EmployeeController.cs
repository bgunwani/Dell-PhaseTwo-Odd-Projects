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
        IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employeeRepository.AddEmployee(employee);
            return RedirectToAction("Index");
        }

        public IActionResult GetEmployees([FromServices] IEmployeeRepository employeeRepository)
        {
            var employees = employeeRepository.GetEmployees();
            return View(employees);
        }
    }
}
