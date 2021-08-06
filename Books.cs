using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRazorPagesDemo.Models
{
    public class Books
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int Price { get; set; }

        public static List<Books> booksList = new List<Books>();

    }
}
