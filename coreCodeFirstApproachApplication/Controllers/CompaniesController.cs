using coreCodeFirstApproachApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstApproachApplication.Controllers
{
    public class CompaniesController : Controller
    {

        ApplicationDBContext context = new ApplicationDBContext();

        // GET: CountriesController
        public ActionResult Index()
        {
            var companies = context.Companies.ToList();
            return View(companies);
        }

        // GET: CountriesController/Details/5
        public ActionResult Details(int id)
        {
            var company = context.Companies.Find(id);
            return View(company);
        }

        // GET: CountriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Company company)
        {
            try
            {
                context.Companies.Add(company);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CountriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CountriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CountriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CountriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
