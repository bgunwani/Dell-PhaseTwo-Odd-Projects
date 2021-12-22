using coreShoppingCartApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreShoppingCartApplication.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDBContext _context;
        public ProductsController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}
