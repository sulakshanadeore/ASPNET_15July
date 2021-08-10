using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Emp
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public int Sal { get; set; }
    }
    class EmpExample
    {
        static void Main(string[] args)
        {
            List<Emp> emps = new List<Emp>();
            emps.Add(new Emp {Empid=1,Name="Ajit",Sal=20000 });
            emps.Add(new Emp { Empid = 2, Name = "Sujit", Sal = 30000 });
            emps.Add(new Emp { Empid = 3, Name = "Manjit", Sal = 23000 });
            emps.Add(new Emp { Empid = 4, Name = "Jay", Sal = 25000 });
            emps.Add(new Emp { Empid = 5, Name = "Vijay", Sal = 21000 });

            var empdata = emps.Where(s => s.Sal > 21000).Select(n => n.Name).ToList();

            //ToList()----- immediate
            //No ToList()--- deferred
            emps.Add(new Emp { Empid = 6, Name = "Harish", Sal = 27000 });


            foreach (var item in empdata)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
    }
}
