using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CachingInMVC.Models;
using System.IO;
namespace CachingInMVC.Controllers
{
    public class EmployeesController : Controller
    {
        static List<Emp> emplist = new List<Emp>();
        static EmployeesController()
        {
            emplist.Add(new Emp { Empid=1,Name = "anita", Age = 20, City = "Pune" });
           
            emplist.Add(new Emp {Empid=2 ,Name = "Sunita", Age = 21, City = "Pune" });

            emplist.Add(new Emp {Empid=3 ,Name = "Nita", Age = 19, City = "Pune" });

        }
        // GET: Employees
        //[OutputCache(Duration=20)]
        [OutputCache(CacheProfile = "cacheOneMinute")]

        public ActionResult Index()
        {
        
            return View(emplist);
        }

        [OutputCache(Duration =int.MaxValue,VaryByParam="id")]
        public ActionResult Details(int id)
        {
            Emp refemp=emplist.Find(emp => emp.Empid == id);
            return View(refemp);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection f,HttpPostedFileBase file)
        {
            Emp obj = new Emp();
            obj.Empid = Convert.ToInt32(Request.Form["Empid"]);
            obj.Name = Request.Form["Name"];
            obj.Age = Convert.ToInt32(Request.Form["Age"]);
            obj.City = Request.Form["City"];
            //obj.FileName = Request.Form["FileName"];

            if (file!=null)
            {
                string path = Path.Combine(Server.MapPath("~/UploadedDocs"), Path.GetFileName(file.FileName));
                file.SaveAs(path);
                ViewBag.msg = "file uploaded successfully";
            }
            emplist.Add(obj);
            return View();
        }
        
    }
}
