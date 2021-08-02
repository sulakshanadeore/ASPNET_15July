
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using PassingData.Models;

namespace PassingData.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            //ViewBag.userid = Session["loggedInUser"].ToString();
            string s= Session["loggedInUser"].ToString();

            return RedirectToAction("Welcome");
        }

        public ActionResult Welcome()
        {
            
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(User data)
        {
            if (data.UserID=="abc" && data.Password=="abc@1234")
            {

                HttpCookie cook = new HttpCookie("userLogindata");
                cook.Values.Add("username", data.UserID);

                cook.Values.Add("pwd", data.Password);
                cook.Expires = DateTime.Now.AddMinutes(10);
                Response.Cookies.Add(cook);


                Session["loggedInUser"] = data.UserID;
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}