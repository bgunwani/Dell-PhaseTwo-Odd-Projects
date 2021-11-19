using ConfiguringMVcWebApplicationFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfiguringMVcWebApplicationFinal.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> students = new List<Student>()
        {
            new Student(){StudentId=101, Name="Kartik Sharma", City="Delhi", Gender="Male"},
            new Student(){StudentId=102, Name="Gautam Bhalla", City="Mumbai", Gender="Male"},
            new Student(){StudentId=103, Name="John Smith", City="Delhi", Gender="Male"},
            new Student(){StudentId=104, Name="King Kochhar", City="Mumbai", Gender="Male"},
            new Student(){StudentId=105, Name="Roger Lee", City="Delhi", Gender="Male"}
        };

        public IActionResult Index()
        {
            ViewBag.Message = "Student Management System";
            ViewBag.StudentCount = students.Count;
            ViewBag.StudentList = students;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }


    }
}
