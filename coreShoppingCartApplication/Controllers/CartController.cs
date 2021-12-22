using coreShoppingCartApplication.Helpers;
using coreShoppingCartApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreShoppingCartApplication.Controllers
{
    public class CartController : Controller
    {
        ApplicationDBContext _context;
        public CartController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            return View();
        }

        public IActionResult Buy(int id)
        {
            if(SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = _context.Products.Find(id), Quantity = 1 });
                SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if(index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = _context.Products.Find(id), Quantity = 1 });
                }
                SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        public int isExist(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.setObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
    }
}
