using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NWBLL;
using NWDAL;
using System.Data;
using System.Data.SqlClient;
namespace DataViewsAndDataTablesDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=spd;Initial Catalog=northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from products where categoryid=1",cn);
            cn.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            int cnt=dt.Rows.Count;
            TextBox1.Text = cnt.ToString();
            
            cn.Close();
           
            GridView1.DataSource = dt;
            GridView1.DataBind();

            SqlCommand cmd1 = new SqlCommand("select * from products where categoryid=2", cn);
            cn.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);
            cnt = dt1.Rows.Count;
            TextBox2.Text = cnt.ToString();

            cn.Close();
            
            GridView2.DataSource = dt1;
            GridView2.DataBind();



            SqlCommand cmd2 = new SqlCommand("select avg(unitprice) from products where categoryid=1", cn);
            cn.Open();
            object avgprice = cmd2.ExecuteScalar();
                   
            
            TextBox3.Text = avgprice.ToString();

            cn.Close();
            cn.Dispose();
        }
    }
}