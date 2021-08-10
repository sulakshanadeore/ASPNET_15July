using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQToDataSetsDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string cnstring = "Data Source=SPD;Initial Catalog=Northwind;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cnstring);
            SqlDataAdapter da = new SqlDataAdapter("select * from products",cn);
            DataSet ds = new DataSet();//cache 
            da.Fill(ds, "p1");
            //Datatable is in dataset
            //p1 is datatable

            //Disconnect from db server
            //var query = (from d in ds.Tables["p1"].AsEnumerable()
            //      where d.Field<int>("CategoryID") == Convert.ToInt32(TextBox1.Text)
            //            select d).ToList();

            //foreach (var item in query)
            //{
            //    plist.Add(
            //        new Products
            //        {
            //            Prodid = item.Field<int>("ProductID"),
            //            ProdName = item.Field<string>("ProductName"),
            //            Price = item.Field<decimal>("UnitPrice")
            //        });



                var query = from d in ds.Tables["p1"].AsEnumerable()
                        where d.Field<int>("CategoryID") == Convert.ToInt32(TextBox1.Text)
                        select new 
                        { pid = d.Field<int>("ProductID"),
                            pname = d.Field<string>("ProductName") };

            List<Products> plist = new List<Products>();
            foreach (var item in query)
            {
                plist.Add(new Products { Prodid=item.pid,ProdName=item.pname});
            }
           
                //Response.Write(item.Field<int>("ProductID").ToString());

                //Response.Write(item.Field<string>("ProductName").ToString());
                //Response.Write("<br/>");

           

            GridView1.DataSource = plist;
            GridView1.DataBind();



        }
    }
}