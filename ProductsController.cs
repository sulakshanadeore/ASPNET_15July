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

        public ActionResult RemoveProduct(int id)
        {
            ElectronicsProducts product=prodList.Find(prod => prod.ProdId == id);
            prodList.Remove(product);

            return RedirectToAction("Index");
        }


        public ActionResult FindProduct(int id)
        {
            ElectronicsProducts product = prodList.Find(prod => prod.ProdId == id);

            return View(product);
        }

        public ActionResult UpdateProduct(int id)
        {
            ElectronicsProducts product = prodList.Find(prod => prod.ProdId == id);
            return View(product);
        }

        [HttpPost]
        public ActionResult UpdateProduct(int id,ElectronicsProducts data)
        {
            ElectronicsProducts product = prodList.Find(prod => prod.ProdId == id);
            product.ProdName = data.ProdName;
            product.Price = data.Price;

            return RedirectToAction("Index");
        }



    }
}