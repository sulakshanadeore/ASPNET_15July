using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using NWBLL;
using NWDAL;

namespace WcfServiceDemo1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int AddNos(int no1, int no2)
        {
            // throw new NotImplementedException();
            return no1 + no2;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void InsertDataIntoCategories(Category c)
        {
            // throw new NotImplementedException();
            NWBLL.Category c1 = new NWBLL.Category();
            c1.CatId = c.Catid;
            c1.CatName = c.CatName;
            c1.Desc = c.Desc;
            CategoriesDAL dal = new CategoriesDAL();
                dal.InsertCategory(c1);

         
        }

        public int Multiply(int no1, int no2)
        {
            return no1 * no2;
        }

        public bool SendMessage(string name, string msg)
        {
            
                string s= "Hello" + name + "this is message for you " + msg;

            return true;

         }
    }
}
