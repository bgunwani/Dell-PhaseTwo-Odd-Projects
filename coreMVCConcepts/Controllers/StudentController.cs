using coreMVCConcepts.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMVCConcepts.Controllers
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
        public IActionResult About()
        {
            ViewData["Message"] = "Student Management System";
            ViewData["StudentCount"] = students.Count;
            ViewData["StudentList"] = students;
            ViewBag.Message = "Students Here";
            return View();
        }

        public IActionResult Info()
        {
            TempData["Message"] = "Student Management System";
            TempData["StudentCount"] = students.Count;
            TempData["StudentList"] = students;
            return View();
        }


        public IActionResult Details()
        {
            if(ViewBag.Message == null)
            {
                ViewBag.NewMessage = "New Message";
            }
            else
            {
                ViewBag.NewMessage = ViewBag.Message;
            }
            return View();
        }
        public IActionResult RequestA()
        {
            //TempData["Msg"] = "Hello World";
            //return RedirectToAction("RequestB");
            
            TempData["Msg"] = "Hello World";
            return View();
        }
        public IActionResult RequestB()
        {
            //if(TempData["Msg"] as string != null)
            //    return View();
            //return RedirectToAction("Index");

            if (TempData["Msg"] as string != null)
            {
                TempData["Msg"] = TempData["Msg"]; 
                return View();
            }
            else
                return RedirectToAction("Index");
        }
        public IActionResult StudentData()
        {
            return View(students);
        }
    }
}
