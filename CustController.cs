using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationsMVCDemo.Models;
namespace ValidationsMVCDemo.Controllers
{
    public class CustController : Controller
    {
        // GET: Cust
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AcceptData()
        {
           


            return View();
        }
        [HttpPost]
        public ActionResult AcceptData(Customers c)
        {

            if (!ModelState.IsValid)
            {

                return View();
            }


            return RedirectToAction("Index");
        }

    }
}