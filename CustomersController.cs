using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingTrial.Controllers
{
    [Route("[controller]/[action]")]
    public class CustomersController : Controller
    {
        //[Route("")]
        //[Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
        public ActionResult About()
        {

            return View();
        }
    }
}
