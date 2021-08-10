using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = new int[] { 1, 35, 4, 5, 6, 21, 2  };
            //select elementname from arr where elementname>5

            //var filterData = from a in arr
            //                 orderby a descending
            //                 where a>5
            //                 select a;

            //foreach (var item in filterData)
            //{
            //    Console.WriteLine(item);
            //}
            //METHOD SYNTAX--- extension methods

            //IEnumerable<int> filterData = arr.Where(a => a > 5);
            //var filterData = arr.Where(a => a > 5);

            //foreach (var item in filterData)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] s = new string[] {"Jack","Vinita","Sunita","Vinita" };
            //var searchString = from s1 in s
            //                   where s1.Contains("Vinita")
            //                   select s1;
            //foreach (var item in searchString)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------------------------------");
            //var serName = s.Where(s1 => s1.Contains("Abhay"));
            //foreach (var item in serName)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList al = new ArrayList();//Non-Generic
            List<Products> al = new List<Products>();
            al.Add(new Products {ProductName="Hard Disk",Price=2000 });
            al.Add(new Products { ProductName = "Monitor", Price = 3000 });
            al.Add(new Products { ProductName = "Mouse", Price = 800 });
            al.Add(new Products { ProductName = "SS Disk", Price = 1000 });
            al.Add(new Products {ProductName="Disk" ,Price=5000 });
            al.Add(new Products { ProductName = "PowerBank", Price = 3500 });

            //var data = from  d in al
            //           orderby d.Price ascending
            //            where d.ProductName.Contains("Disk")
            //           select d;

            var data = al.Where(p1 => p1.ProductName.Contains("Disk") && p1.Price > 1000).OrderBy(p2=>p2.Price);

            foreach (var item in data)
            {
                Console.WriteLine(item.ProductName + " " +  item.Price);
            }
                     





            Console.Read();
        }
    }
}
