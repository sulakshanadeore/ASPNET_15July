using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.Controllers
{
    public class NWController : Controller
    {
        public ICategory CategoryData { get; set; }
        //Using Dependency using Constructor
        public NWController(ICategory category)
        {
            this.CategoryData = category;
        }
        public IActionResult Index()
        {
            List<Category> categories = CategoryData.GetCategories();
            return View(categories);
        }
    }
}
