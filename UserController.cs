using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CachingInMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Index(HttpPostedFileBase file1)
        //{
        //    //if (file1 != null)
        //    //{
        //    var httpPostedFile = HttpContext.Request.Form["file1"];
        // ViewBag.msg = "file uploaded successfully";
        //    //}
        //    return View();
        //}

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase uploadFile)
        {
            if (uploadFile != null && uploadFile.ContentLength>0)
            {
                
                string contentType=uploadFile.ContentType;

                string filePath = Path.Combine(Server.MapPath("/UploadedDocs"), Path.GetFileName(uploadFile.FileName));
                uploadFile.SaveAs(filePath);
                ViewBag.msg = "File Uploaded Successfully";
            }
            return View();
        }


    }
}