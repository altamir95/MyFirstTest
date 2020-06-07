using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyFirstTest.Controllers
{
    public class OldItems
    {
        public string OldITN { get; set; }
        public string OldEntityType { get; set; }


    }
    public class CRUDController : Controller
    {

        //_____________________________________________________________________________
        BusinessContext db;
        public CRUDController(BusinessContext context)
        {
            db = context;
        }

        public IActionResult AddCostumer()
        {
            ViewBag.error = "";
            return View();
        }
        [HttpPost]
        public IActionResult AddCostumer(Customer customer)
        {
            customer.CustomerITN = customer.CustomerITN.Replace("  ", string.Empty);
            customer.CreationData = DateTime.Now;
            //_________________________________
            if (db.Custumers.FirstOrDefault(x => x.CustomerITN == customer.CustomerITN) != null)
            {
                ViewBag.error = "Подобный ИНН уже существует. Каждый ИНН должен быть индевидуален";
                return View("AddCostumer");
            }
            //..................................
            if (!Regex.IsMatch(customer.CustomerITN, "^[0-9а-яА-Я?-]*$"))
            {
                ViewBag.error = "ИНН может содержать только цифры";
                return View("AddCostumer");
            }
            //..................................
            if (customer.EntityType== "юридическое лицо")
            {
                if(customer.CustomerITN.Length != 10)
                {
                    ViewBag.error = "ИНН юридического лица состоит из 10 цифр";
                    return View("AddCostumer");
                }
            }
            //..................................
            if (customer.EntityType == "индивидуальный предприниматель")
            {
                if (customer.CustomerITN.Length != 12)
                {
                    ViewBag.error = "ИНН индивидуального предпринимателя состоит из 12 цифр";
                    return View("AddCostumer");
                }
            }
            //_________________________________
            db.Custumers.Add(customer);
            db.SaveChanges();
            if (customer.EntityType == "индивидуальный предприниматель")
            {
                return RedirectToRoute(new { controller = "CRUD", action = "AllCustomers" });
            }
            return RedirectToRoute(new { controller = "CRUD", action = "AddFounders", id = customer.Id });
        }

        [HttpGet]
        public IActionResult AddFounders(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFounders(Founder founders, int id)
        {
            //Проверка на возможность добовления учредителя
            Customer customerForCheck = db.Custumers.FirstOrDefault(x => x.Id == id);
            if (customerForCheck.EntityType== "индивидуальный предприниматель")
            {
                ViewBag.error = "Как вы суда попали? У индивидуального предпринимателя не может быть учредителя !";
                return View();
            }
            founders.CreationData = DateTime.Now;
            founders.CustomerId = id;
            founders.FounderITN = founders.FounderITN.Replace("  ", string.Empty);
            //_________________________________
            
            //..................................
            if (db.Custumers.FirstOrDefault(x => x.CustomerITN == founders.FounderITN) != null || db.Founders.FirstOrDefault(x => x.FounderITN == founders.FounderITN) != null)
            {
                ViewBag.error = "Подобный ИНН уже существует. Каждый ИНН должен быть индевидуален";
                return View();
            }
            //..................................
            if (!Regex.IsMatch(founders.FounderITN, "^[0-9а-яА-Я?-]*$"))
            {
                ViewBag.error = "ИНН может содержать только цифры";
                return View();
            }
            //..................................
            if (founders.FounderITN.Length != 12)
            {
                ViewBag.error = "Учредителем может быть только индивидуальный предпрениматель, следовотельно его ИНН состоит из 12 цифр ";
                return View();
            }
            //_________________________________
            db.Founders.Add(founders);
            db.SaveChanges();
            return RedirectToAction("AllCustomers");
        }

        //_____________________________________________________________________________
        public IActionResult AllCustomers()
        {
            SomeModel someModel = new SomeModel
            {
                Customers = db.Custumers.ToList(),
                Founders = db.Founders.ToList(),
                errorCarrier = ""
            };
            return View(someModel);
        }
        //.............................................................................
        [HttpPost]
        public IActionResult AllCustomers(Customer customer, OldItems oldItems)
        {
            customer.UpdateDate = DateTime.Now;
            customer.CustomerITN = customer.CustomerITN.Replace("  ", string.Empty);
            //_________________________________
            if (customer.CustomerITN != oldItems.OldITN)
            {
                if (db.Custumers.FirstOrDefault(x => x.CustomerITN == customer.CustomerITN) != null || db.Founders.FirstOrDefault(x => x.FounderITN == customer.CustomerITN) != null)
                {
                    SomeModel someModel = new SomeModel
                    {
                        Customers = db.Custumers.ToList(),
                        Founders = db.Founders.ToList(),
                        errorCarrier = "Подобный ИНН уже существует. Каждый ИНН должен быть индевидуален"
                    };
                    return View(someModel);
                }
            }
            
            //..................................
             if (!Regex.IsMatch(customer.CustomerITN, "^[0-9а-яА-Я?-]*$"))
            {
                SomeModel someModel = new SomeModel
                {
                    Customers = db.Custumers.ToList(),
                    Founders = db.Founders.ToList(),
                    errorCarrier = "ИНН может содержать только цифры"
                };
                return View(someModel);
            }
            //..................................
             if(customer.EntityType == "юридическое лицо")
            {
                if (customer.CustomerITN.Length != 10)
                {
                    SomeModel someModel = new SomeModel
                    {
                        Customers = db.Custumers.ToList(),
                        Founders = db.Founders.ToList(),
                        errorCarrier = "ИНН юридического лица состоит из 10 цифр"
                    };
                    return View(someModel);
                }
            }
            //..................................
             if(customer.EntityType == "индивидуальный предприниматель")
            {
                if (oldItems.OldEntityType != customer.EntityType)
                {
                    IEnumerable<Founder> founders = db.Founders.Where(x => x.CustomerId == customer.Id);

                    foreach (Founder founderForDelete in founders)
                    {
                        db.Entry(founderForDelete).State = EntityState.Deleted;
                    }
                }
                if (customer.CustomerITN.Length != 12)
                {
                    SomeModel someModel = new SomeModel
                    {
                        Customers = db.Custumers.ToList(),
                        Founders = db.Founders.ToList(),
                        errorCarrier = "ИНН индивидуального предпринимателя состоит из 12 цифр"
                    };
                    return View(someModel);
                }
            }
            //_________________________________
            
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();

            return RedirectToAction("AllCustomers");

        }
        //.............................................................................
        public  IActionResult RemoveCustomers(int? id)
        {
            Customer customer =  db.Custumers.FirstOrDefault(x => x.Id == id);
            db.Entry(customer).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("AllCustomers");
        }
        //_____________________________________________________________________________
        public IActionResult AllFounders()
        {
            return View(db.Founders.ToList());
        }
        //.............................................................................
        [HttpPost]
        public IActionResult AllFounders(Founder founders, OldItems oldItems)
        {
            founders.UpdateDate = DateTime.Now;
            founders.FounderITN = founders.FounderITN.Replace("  ", string.Empty);
            //_________________________________
            if (founders.FounderITN != oldItems.OldITN)
            {
                if (db.Custumers.FirstOrDefault(x => x.CustomerITN == founders.FounderITN) != null || db.Founders.FirstOrDefault(x => x.FounderITN == founders.FounderITN) != null)
                {
                    ViewBag.error = "Подобный ИНН уже существует. Каждый ИНН должен быть индевидуален";
                    return View(db.Founders.ToList());
                }
            }
            //..................................
            if (!Regex.IsMatch(founders.FounderITN, "^[0-9а-яА-Я?-]*$"))
            {
                ViewBag.error = "ИНН может содержать только цифры";
                return View(db.Founders.ToList());
            }
            //..................................
            if (founders.FounderITN.Length != 12)
                {
                    ViewBag.error = "Учредителем может быть только индивидуальный предпрениматель, следовотельно его ИНН состоит из 12 цифр ";
                return View(db.Founders.ToList());
            }
            //_________________________________
            db.Entry(founders).State = EntityState.Modified;
            db.SaveChanges();
            return View(db.Founders.ToList());
        }
        //.............................................................................
        public IActionResult RemoveFounders(int? id)
        {
            Founder founder = db.Founders.FirstOrDefault(x => x.FounderId == id);
            db.Entry(founder).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("AllFounders");
        }
        //_____________________________________________________________________________
    }
}
