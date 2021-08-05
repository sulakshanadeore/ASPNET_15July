using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksLibraryDemo.Models;
namespace BooksLibraryDemo.Controllers
{
    public class BookController : Controller
    {
        static List<Book> booklist = new List<Book>();
         static BookController()
        {
            booklist.Add(new Book {BookID=1,BookTitle="C",BookPrice=200M });

            booklist.Add(new Book { BookID = 2, BookTitle = "C++", BookPrice = 250M });
            booklist.Add(new Book { BookID = 3, BookTitle = "C#", BookPrice = 300M });



        }
        public IActionResult Index()
        {

            return View(booklist);
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Book b) 
        {
            booklist.Add(b);
            return View();
        }

        public ActionResult Edit(int? id)
        {
            Book data = null;
            if (id!=null)
            {
                data=booklist.Find(b1 => b1.BookID == id);
            }

            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(int? id,Book newdata)
        {
            Book data = null;
            if (id != null)
            {
                data = booklist.Find(b1 => b1.BookID == id);
                data.BookTitle = newdata.BookTitle;
                data.BookPrice = newdata.BookPrice;

            }


            return RedirectToAction("Index");
            //return Redirect("http://www.google.com");
           // return RedirectToAction()
        }

        
        public ActionResult Delete(int? id)
        {
            Book data = null;
            if (id != null)
            {
                data = booklist.Find(b1 => b1.BookID == id);
                
            }
                return View(data);
        }
        [HttpPost]
        public ActionResult Delete(int? id,Book toDelete)
        {
            Book data = null;
            if (id != null)
            {
                data = booklist.Find(b1 => b1.BookID == id);
                booklist.Remove(data);
            }

            return RedirectToAction("Index");
        }

    }
}
