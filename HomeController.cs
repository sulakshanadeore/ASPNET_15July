using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PassingData.Models;
namespace PassingData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //pass string from index action of the home controller to the view-- - index view
            //  dynamic---feature of C#--- uses data dictionary---- dictionary means key value pairs
            //any type of data---(object type)
            //key--title
            //value = "Index Page/View";//string
            //View bag is responsible for holding the data till it is rendered / given / printed on the view
            ViewBag.title = "Index Page/View";
            ViewBag.usercnt = 10;
            List<string> Lstr = new List<string>();
            Lstr.Add("Hello");
            Lstr.Add("Welcome");
            Lstr.Add("Thank you");
            Lstr.Add("Visit again");
            ViewBag.mygreetings = Lstr;

            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee {Empid=10,Ename="Ajay" });

            emplist.Add(new Employee { Empid = 20, Ename = "Vijay" });

            emplist.Add(new Employee { Empid = 30, Ename = "Sujay" });

            ViewBag.employees = emplist;
            Employee emp = new Employee();
            emp.Empid = 1;
            emp.Ename = "Ganesh";
            ViewBag.oldestEmp = emp;
            return View();
        }

        public ActionResult About()
        {
            ViewData["PageTitle"] = "About The Company";
            ViewData["usercount"] = 20;
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { Empid = 10, Ename = "Ajay" });

            emplist.Add(new Employee { Empid = 20, Ename = "Vijay" });

            emplist.Add(new Employee { Empid = 30, Ename = "Sujay" });

            ViewData["employees"] = emplist;

            List<string> Lstr = new List<string>();
            Lstr.Add("Hello");
            Lstr.Add("Welcome");
            Lstr.Add("Thank you");
            Lstr.Add("Visit again");
            ViewData["greetings"] = Lstr;

            return View();
        }
        [HttpPost]
        public ActionResult About(int eid)
        {
            TempData["employeeid"] = eid;
            return RedirectToAction("Contact");
        }

        public ActionResult Contact()
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            TempData["joiningDate"] = dt;
            
            //TempData["receivedEmpData"] = TempData["employeeid"];
            ViewBag.myempid= TempData["employeeid"];
            TempData.Keep();
            
            return View();
        }
        [HttpPost]
        public ActionResult Contact(int data=0)
        {

            TempData["myUserData"]= TempData["employeeid"];
            TempData.Keep();
            return RedirectToAction("SaveData");
        }
        public ActionResult SaveData()
        {
            
            ViewBag.againGotit=TempData["employeeid"];

            return View();
        }
    }
}