using coreViewModelApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreViewModelApplication.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Details()
        {
            DataRepository dataRepository = new DataRepository();
            return View(dataRepository.DataSource());
        }
    }
}
