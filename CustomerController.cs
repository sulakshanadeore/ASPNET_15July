using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkingWithViewsDemo.Models;
namespace WorkingWithViewsDemo.Controllers
{
    public class CustomerController : Controller
    {
        static List<Cust> custs = new List<Cust>();
        // GET: Customer
        public ActionResult Index()
        {
            return View(custs);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            Cust c=custs.Find(customer => customer.Custid == id);
            return View(c);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Cust cobj = new Cust();
              
                cobj.Custid = Convert.ToInt32(Request.Form["Custid"]);
                //cobj.CustName = collection.CustName;
                //cobj.CustCity = collection.CustCity;
                

                custs.Add(cobj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {

            Cust c = custs.Find(customer => customer.Custid == id);
            return View(c);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cust collection)
        {
            try
            {
                // TODO: Add update logic here
                
                Cust c= custs.Find(customer => customer.Custid == id);
                custs.Remove(c);

                Cust cobj = new Cust();
                cobj.Custid = Convert.ToInt32(collection.Custid);
                cobj.CustName = collection.CustName;

                cobj.CustCity = collection.CustCity;
                custs.Add(cobj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            Cust c = custs.Find(customer => customer.Custid == id);

            return View(c);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Cust c = custs.Find(customer => customer.Custid == id);
                custs.Remove(c);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
