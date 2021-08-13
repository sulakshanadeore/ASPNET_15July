using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowCategory(int id)
        {

            SqlConnection cn = new SqlConnection("server=SPD;Initial Catalog=Northwind;Integrated Security=true");
            Category c = new Category();
            SqlCommand cmd = new SqlCommand("select * from categories where categoryid=" + id, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            c.catid = Convert.ToInt32(dr[0]);
            c.name = dr[1].ToString();
            c.desc = dr[2].ToString();
            byte[] photo_img = (byte[])dr[3];
            ImageConverter imageConverter = new System.Drawing.ImageConverter();
            
            Image img1 = imageConverter.ConvertFrom(photo_img) as Image;

            string p = Server.MapPath("~/Images/");
            string filename = "C" + c.catid.ToString();
            filename=string.Concat(filename, ".jpg");
            p=string.Concat(p,filename);
            img1.Save(p);
            ViewBag.img = filename;


            //img1.Save("abc.jpg");
            //ViewBag.img = "abc.jpg";
            
        
            cn.Close();
            cn.Dispose();
            return View(c);
        }



        //[HttpPost]
        //public ActionResult ShowCategory()
        //{
           
        //}

    }
}