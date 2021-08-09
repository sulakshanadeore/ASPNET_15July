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

        public Category FindDetails(int catid)
        {
            SqlConnection cn = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand("[FindCategory]", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cn.Open();
            cmd.Parameters.AddWithValue("@catid", catid);
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@catname";
            p1.SqlDbType = SqlDbType.NVarChar;
            p1.Size = 15;
            p1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@desc";
            p2.SqlDbType = SqlDbType.NVarChar;
            p2.Direction = ParameterDirection.Output;
            p2.Size = 2000;
            cmd.Parameters.Add(p2);
            SqlDataReader dr=cmd.ExecuteReader();
            Category c = new Category();
            c.CatId = catid;
            c.CatName=cmd.Parameters["@catname"].Value.ToString();
            c.Desc = cmd.Parameters["@desc"].Value.ToString();



            cn.Close();
            cn.Dispose();

            return c;
        }

        public void InsertCategory(Category category)
        {
            SqlConnection cn = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand("[AddNewCategory]",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            string name = category.CatName;
            string desc = category.Desc;
            cmd.Parameters.AddWithValue("@catname", name);
            cmd.Parameters.AddWithValue("@desc", desc);
            cn.Open();
            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();



        }


        public void DeleteCategory(int id)
        {

            SqlConnection cn = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand("RemoveCategory", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@catid", id);
            cn.Open();
            cmd.ExecuteNonQuery();

            cn.Close();
            cn.Dispose();
        }

        public void UpdateCategory(Category c)
        {
            SqlConnection cn = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand("UpdateCategoryData", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@catid", c.CatId);
            cmd.Parameters.AddWithValue("@catname", c.CatName);
            cmd.Parameters.AddWithValue("@desc", c.Desc);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();



        }

    }
}
