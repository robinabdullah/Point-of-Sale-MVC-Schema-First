using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Point_of_Sale_MVC_Schema_First.Models;
using System.Web.Mvc;
using System.Web.Helpers;

namespace Point_of_Sale_MVC_Schema_First.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View(new POSDBEntities().Customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int? id)
        {
            Customer customer = new POSDBEntities().Customers.Where(x => x.ID == id).First();
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    POSDBEntities DB = new POSDBEntities();
                    DB.Customers.Add(c);
                    DB.SaveChanges();

                    return RedirectToAction("Index");
                }
                else return View(c);
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customer = new POSDBEntities().Customers.Where(x => x.ID == id).First();

            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    POSDBEntities DB = new POSDBEntities();
                    Customer customer = DB.Customers.Where(x => x.ID == id).First();

                    customer.Name = c.Name;
                    customer.ID = c.ID;
                    customer.Phone2 = c.Phone2;
                    customer.Address = c.Address;
                    DB.SaveChanges();
                    return RedirectToAction("Index");
                }
                else return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            POSDBEntities DB = new POSDBEntities();
            Customer customer = DB.Customers.Where(x => x.ID == id).First();
            return View(customer);
        }

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirm(int id)
        //{
        //    POSDBEntities DB = new POSDBEntities();
        //    Customer customer = DB.Customers.Where(x => x.ID == id).First();
        //      DB.SaveChanges();
        //    return View(customer);
        //}

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                POSDBEntities DB = new POSDBEntities();
                Customer customer = DB.Customers.Where(x => x.ID == id).First();

                DB.Customers.Remove(customer);
                DB.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
