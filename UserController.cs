using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFClientDemo.ServiceReference1;
using WCFClientDemo.Models;
namespace WCFClientDemo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult SendMessage()
        {

            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(string n,string m)
        {
            Service1Client client = new Service1Client();
            bool msg = client.SendMessage(n, m);
            string res = null;
            if (msg==true)
            {
                res = "Your message is sent";
            }
            else
            {
                res = "Your message is not sent";
            }
            return Content(res);
        }



        public ActionResult CreateCategory()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(CategoryModel category)
        {
            Service1Client client = new Service1Client();
            Category cat = new Category();
            cat.Catid = category.CatId;
            cat.CatName = category.CatName;
            cat.Desc = category.CatDesc;
            client.InsertDataIntoCategories(cat);

            return View();
        }
    }
}