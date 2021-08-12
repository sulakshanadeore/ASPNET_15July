using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NWBLL;
using NWDAL;
using System.IO;
namespace ErrorHandlingLoggingDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                CategoriesDAL dal = new CategoriesDAL();
                Console.WriteLine("Enter category id");
                Category data = new Category();
                int catid = Convert.ToInt32(Console.ReadLine());
                data = dal.FindDetails(catid);
                Console.WriteLine(data.CatId);
                if (data.CatName!="")
                {
                    Console.WriteLine(data.CatName);
                    Console.WriteLine(data.Desc);
                }
                else
                {
                    throw new ArgumentNullException("not found");
                }



            }
            catch (ArgumentNullException ex)
            {
                FileStream fs = new FileStream("logs.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(DateTime.Now.ToLongDateString());
                sw.WriteLine(DateTime.Now.ToLongTimeString());
                sw.WriteLine("Category doesn't exists");
                sw.WriteLine(ex.Message);
                sw.WriteLine(ex.StackTrace);
                sw.WriteLine(ex.Source);
                sw.WriteLine(ex.HelpLink);
                sw.WriteLine("***************");
                sw.Close();
                sw.Dispose();
                fs.Close();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                FileStream fs = new FileStream("logs.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(DateTime.Now.ToLongDateString());
                sw.WriteLine(DateTime.Now.ToLongTimeString());
                sw.WriteLine(ex.Message);
                sw.WriteLine(ex.StackTrace);
                sw.WriteLine(ex.Source);
                sw.WriteLine(ex.HelpLink);
                sw.WriteLine();
                sw.Close();
                sw.Dispose();
                fs.Close();
                fs.Dispose();


            }
            finally
            {
                Console.WriteLine("completed exection");

            }
            Console.ReadLine();
        }
    }
}
