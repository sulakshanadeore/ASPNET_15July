using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAL;
using DAL;
using DatabaseConnect_DisconnectedDemo.Models;
namespace DatabaseConnect_DisconnectedDemo.Controllers
{
    public class RegionsController : Controller
    {
        // GET: Regions
        RegionDAL dal = new RegionDAL();
        public ActionResult Index()
        {
            List<RegionBAL> baldata=dal.ShowRegions();
            List<M_Regions> list = new List<M_Regions>();
            foreach (var item in baldata)
            {
                M_Regions r1 = new M_Regions();
                r1.RegionID = item.RegionID;
                r1.RegionName = item.RegionName;
                list.Add(r1);

            }
            return View(list);
        }

        // GET: Regions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Regions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Regions/Create
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

        // GET: Regions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Regions/Edit/5
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

        // GET: Regions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Regions/Delete/5
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
