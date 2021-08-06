using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoutingTrial.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingTrial.Controllers
{
   
    //[Route("def")]
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        [Route("Home/Index")]
        [Route("~/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Pri")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/Con")]
        public ActionResult Contact()
        {

            return View();
        }

        //[Route("Home/Details/{id?}")]

        public ActionResult Details(int id)
        {

            return Content("Id passed = " + id);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
