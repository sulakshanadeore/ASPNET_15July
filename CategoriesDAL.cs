using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using NWBLL; 
namespace NWDAL
{
    public class CategoriesDAL
    {
        string cnstring = "Data Source=SPD;Initial Catalog=Northwind;Integrated Security=True";
        public List<Category> GetCategories()
        {
            SqlConnection cn = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[ShowCategories]()",cn);
            cn.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            //SQLDATAREADER--- read- only fwd only data
            List<Category> categories = new List<Category>();
            while (dr.Read())
            {
                Category c = new Category();
                c.CatId = Convert.ToInt32(dr["CategoryID"]);
                c.CatName = dr[1].ToString();
                c.Desc = dr[2].ToString();
                categories.Add(c);
            }
            cn.Close();
            cn.Dispose();
            return categories;
        }


    }
}
