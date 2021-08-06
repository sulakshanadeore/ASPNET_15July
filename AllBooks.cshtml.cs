using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstRazorPagesDemo.Models;
namespace FirstRazorPagesDemo.Pages
{
    public class AllBooksModel : PageModel
    {
       public static List<Books> GetBooks = new List<Books>();

        static AllBooksModel()
        {
            Books.booksList.Add(new Books { BookId = 1, BookName = "C", Price = 200 });

            Books.booksList.Add(new Books { BookId = 2, BookName = "C++", Price = 250 });
        }
        public void OnGet()
        {
            
            GetBooks = Books.booksList;

        }

      



    }
}
