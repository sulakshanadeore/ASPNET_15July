using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationsMVCDemo.Models;
namespace ValidationsMVCDemo.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            ViewBag.displayError=TempData["errorMsg"];
            return View();
        }
        public ActionResult AcceptData()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AcceptData(Employee empdata)
        {
            if (string.IsNullOrEmpty(empdata.Empname) || string.IsNullOrEmpty(empdata.City) || empdata.Empid==0)
            {
                ModelState.AddModelError("error", "Pls check the data");
                

            }
             if(!ModelState.IsValid)
            {

               return View();
            }


            return RedirectToAction("Index");


        }
    }
}