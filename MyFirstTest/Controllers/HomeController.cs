using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyFirstTest.Models;

namespace MyFirstTest.Controllers
{
    public class HomeController : Controller
    {
        IEnumerable<MyFirstTest.Models.Customers> r;
        public int idNumber;
        ForTestContext db;
        public HomeController(ForTestContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCostumer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCostumer( Customers customers)
        {
            customers.CreationData = $"{DateTime.Now}";
            idNumber = customers.Id;
            db.Custumers.Add(customers);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return RedirectToRoute(new { controller = "Home", action = "AddFounders", id= idNumber });
        }
        [HttpGet]
        public IActionResult AddFounders(int? id)
        {
            ViewBag.CustomerId = idNumber;
            return View();
        }
        [HttpPost]
        public IActionResult AddFounders(Founders founders)
        {
            founders.CreationData = $"{DateTime.Now}";
            db.Founders.Add(founders);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return RedirectToAction("FinishAdd");
        }
        public IActionResult FinishAdd()
        {
            return View();
        }
        public IActionResult AllCustomers()
        {
            return View(db.Custumers.ToList() );
        }

public IActionResult RemoveCustomers(int? id)
        {
            foreach (var customers in db.Custumers)
            {
                if (customers.Id == id)
                {
                    db.Entry(customers).State = EntityState.Deleted;
                    
                }
            }
            db.SaveChanges();
            return RedirectToAction("AllCustomers");
        }
        [HttpGet]
        public IActionResult UpdateCustomers(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.CustomersId = id;
            return View(db.Custumers.ToList());
        }
        [HttpPost]
        public IActionResult UpdateCustomers(Customers customers)
        {
            customers.UpdateDate = $"{DateTime.Now}";
            db.Entry(customers).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("AllCustomers");
        }

        public IActionResult AllFounders()
        {
            return View(db.Founders.ToList());
        }

        public IActionResult RemoveFounders(int? id)
        {
            foreach (var founders in db.Founders)
            {
                if (founders.FoundersId == id)
                {
                    db.Entry(founders).State = EntityState.Deleted;

                }
            }
            db.SaveChanges();
            return RedirectToAction("AllFounders");
        }
        [HttpGet]
        public IActionResult UpdateFounders(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.FoundersId = id;
            return View(db.Founders.ToList());
        }
        [HttpPost]
        public IActionResult UpdateFounders(Founders founders)
        {
            founders.UpdateDate = $"{DateTime.Now}";
            db.Entry(founders).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("AllFounders");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
