using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstRazorPagesDemo.Models;
namespace FirstRazorPagesDemo.Pages
{
    public class AddNewBookModel : PageModel
    {
        //public void OnGet()
        //{
        //}
        public void OnPost(int BookId,string BookName,int Price)
        {
            Books b = new Books();
            b.BookId = BookId;
            b.BookName = BookName;
            b.Price = Price;

            Books.booksList.Add(b);

        }
    }
}
