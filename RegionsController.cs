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
            RegionBAL bal=dal.FindRegion(id);
            M_Regions regions = new M_Regions();
            regions.RegionID = bal.RegionID;
            regions.RegionName = bal.RegionName;
            return View(regions);
        }

        // GET: Regions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Regions/Create
        [HttpPost]
        public ActionResult Create(M_Regions collection)
        {
            try
            {
                // TODO: Add insert logic here
                RegionBAL bal = new RegionBAL();
                bal.RegionID = collection.RegionID;
                bal.RegionName = collection.RegionName;
                dal.InsertRegion(bal);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Regions/Edit/5
        public ActionResult Edit(int id)
        {

            RegionBAL bal = dal.FindRegion(id);
            M_Regions regions = new M_Regions();
            regions.RegionID = bal.RegionID;
            regions.RegionName = bal.RegionName;
            return View(regions);
        }

        // POST: Regions/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, M_Regions collection)
        {
            try
            {
                // TODO: Add update logic here
                RegionBAL bal = new RegionBAL();
                bal.RegionID = id;
                bal.RegionName = collection.RegionName;
                dal.UpdateRegion(bal);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Regions/Delete/5
        public ActionResult Delete(int id)
        {

            RegionBAL bal = dal.FindRegion(id);
            M_Regions regions = new M_Regions();
            regions.RegionID = bal.RegionID;
            regions.RegionName = bal.RegionName;
            return View(regions);
        }

        // POST: Regions/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, M_Regions collection)
        {
            try
            {
                // TODO: Add delete logic here
                dal.DeleteRegion(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
