using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp.Models;
namespace FirstMVCApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        static List<ElectronicsProducts> prodList = new List<ElectronicsProducts>();
        //IEnumerable
        public ActionResult Index()
        {

            return View(prodList);
        }
        

        public ActionResult AddProduct()
        {
            return View();
        }
       
        [HttpPost]
        public RedirectToRouteResult AddProduct(ElectronicsProducts data)
        {
            //ModelBinder
            ElectronicsProducts p = new ElectronicsProducts();
            p.ProdId = data.ProdId;
            p.ProdName = data.ProdName;
            p.Price = data.Price;
            prodList.Add(p);
            //return Content("Product successfully added to the list");
            return RedirectToAction("Index");
        }

    }
}