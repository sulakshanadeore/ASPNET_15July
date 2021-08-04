using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MVCAppWithAPI.Models;
using Newtonsoft.Json;

namespace MVCAppWithAPI.Controllers
{
    public class EmployeeGenralController : Controller
    {
        static List<Empl> list = new List<Empl>();
        string baseurl = "http://localhost:62455";
        // GET: EmployeesGenral
        public async Task<ActionResult> Index()
        {
         
            using (var client=new HttpClient())
            {
                client.BaseAddress = new Uri(baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("/api/Emp");
                if (res.IsSuccessStatusCode)
                {
                    var empres = res.Content.ReadAsStringAsync().Result;
                    list = JsonConvert.DeserializeObject<List<Empl>>(empres);
                }
                
            }
            return View(list);
        }

        // GET: EmployeesGenral/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeesGenral/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesGenral/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesGenral/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeesGenral/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesGenral/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesGenral/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
