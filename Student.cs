using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
   public class Student
    {
        public string City { get; set; }
        public string Name { get; set; }
        public int[] Scores { get; set; }
    }


    class ObjectsDemo
    {
        static void Main(string[] args)
        {
            //List<Student> students = new List<Student>();
            //students.Add(new Student {Name="anita",City="Pune",Scores=new int[] {78,99,66 } });

            //students.Add(new Student { Name = "Sunita", City = "Mumbai",Scores = new int[] { 86, 89, 82 } });


            //students.Add(new Student { Name = "Vinita",City="Mumbai", Scores = new int[] { 67, 82, 61 } });

            //var studData = from s in students
            //               orderby s.Scores[0]
            //               where s.Scores[0] > 75
            //               select s;

            //foreach (var item in studData)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Scores[0]);
            //}


            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "anita", City = "Pune", Scores = new int[] { 78, 99, 66 } });

            students.Add(new Student { Name = "Sunita", City = "Mumbai", Scores = new int[] { 86, 89, 82 } });


            students.Add(new Student { Name = "Vinita", City = "Bhopal", Scores = new int[] { 67, 82, 61 } });

            students.Add(new Student { Name = "Ankita", City = "Mumbai", Scores = new int[] { 67, 82, 61 } });

            students.Add(new Student { Name = "Pranita", City = "Bangalore", Scores = new int[] { 67, 82, 61 } });

            students.Add(new Student { Name = "Savita", City = "Mumbai", Scores = new int[] { 67, 82, 61 } });

            foreach (var item in students)
            {
                Console.WriteLine(item.Name + " " + item.City);
            }

            Console.WriteLine("---------------------");

            //var cityGroups = students.GroupBy(s => s.City);
            var cityGroups = students.ToLookup(s => s.City);


            //var cityGroups = from s in students
            //                 group s by s.City;
                             

            foreach (var item in cityGroups)
            {
                Console.WriteLine("Students in "  + item.Key + ": ");
                Console.WriteLine("-------------------------");
                foreach (var item1 in item)
                {
                    Console.WriteLine("* "+ item1.Name);

                }
                Console.WriteLine();
                
            }


            Console.Read();
        }
    }
}
