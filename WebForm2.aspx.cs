using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataViewsAndDataTablesDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = FillData();
            GridView1.DataSource = ds.Tables["cats"];
            GridView1.DataBind();
         

        }

        private static DataSet FillData()
        {
            SqlConnection cn = new SqlConnection("Data Source=spd;Initial Catalog=northwind;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from categories", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "cats");
            return ds;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet ds = FillData();
            DataView dv = new DataView();
            
            dv = ds.Tables[0].DefaultView;
            dv.Sort = "categoryid desc";
            
            GridView2.DataSource = dv;
            GridView2.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("Data Source=spd;Initial Catalog=northwind;Integrated Security=True");
            SqlDataAdapter da1 = new SqlDataAdapter("select orderid,customerid,orderdate from orders", cn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "ord");
            string expr = "OrderDate>='01.03.1998' and OrderDate<='31.12.1998'";
            string strSort = "OrderDate";
      DataView dv = new DataView(ds1.Tables["ord"], expr, strSort, DataViewRowState.OriginalRows);
            GridView3.DataSource = dv;
            GridView3.DataBind();
        }
    }
}