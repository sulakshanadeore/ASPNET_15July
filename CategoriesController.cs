using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NWBLL;
using NWDAL;
using DatabaseConnectivityDemo_Connected.Models;
namespace DatabaseConnectivityDemo_Connected.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesDAL dal = new CategoriesDAL();
        // GET: Categories
        public ActionResult Index()
        {
            
            List<Category> categories=dal.GetCategories();
            List<M_Category> mlist = new List<M_Category>();
            foreach (var item in categories)
            {
                M_Category c = new M_Category();
                c.CatID = item.CatId;
                c.CatName = item.CatName;
                c.CatDesc = item.Desc;
                mlist.Add(c);
            }



            return View(mlist);
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            Category data=dal.FindDetails(id);
            M_Category c = new M_Category();
            c.CatID = data.CatId;
            c.CatName = data.CatName;
            c.CatDesc = data.Desc;
            return View(c);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public ActionResult Create(M_Category c)
        {
            try
            {
                // TODO: Add insert logic here
                Category c1 = new Category();
                c1.CatId = 0;
                c1.CatName = c.CatName;
                c1.Desc = c.CatDesc;
                dal.InsertCategory(c1);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            M_Category c = new M_Category();

            try
            {
                Category data = dal.FindDetails(id);
                
                c.CatID = data.CatId;
                c.CatName = data.CatName;
                c.CatDesc = data.Desc;
            }
            catch (Exception ex)
            {

                ViewBag.errorMsg = ex.Message;
            }
            finally
            { 
            
            }
            return View(c);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, M_Category collection)
        {
            try
            {
                // TODO: Add update logic here
                Category c = new Category();
                c.CatId = id;
                c.CatName = collection.CatName;
                c.Desc = collection.CatDesc;
                dal.UpdateCategory(c);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            Category data = dal.FindDetails(id);
            M_Category c = new M_Category();
            c.CatID = data.CatId;
            c.CatName = data.CatName;
            c.CatDesc = data.Desc;
            return View(c);
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, M_Category c)
        {
            try
            {
                // TODO: Add delete logic here
                dal.DeleteCategory(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult FindCategory()
        {

            return View();
        }

        [HttpPost]
        public ActionResult FindCategory(int id)
        {
            Category c1=dal.FindDetails(id);

            try
            {

            
            if (c1.CatName!=null)
            {
                M_Category cFound = new M_Category();
                cFound.CatID = c1.CatId;
                cFound.CatName = c1.CatName;
                cFound.CatDesc = c1.Desc;
                    ViewBag.errorMsg = "Found";
                }
                else
                {
                    throw new CategoryNotFoundException("Not finding");

                }
            }
            catch (CategoryNotFoundException ex)
            {
                //FileStream Code

                ViewBag.errorMsg = ex.Message;
            }
            return View();
        }
    }
}
