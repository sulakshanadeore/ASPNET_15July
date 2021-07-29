using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingDemo
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Label1.Text = DateTime.Now.ToLongDateString();
            Label1.Text = DateTime.Now.ToLongTimeString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedValue;
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox2.Text = DropDownList2.SelectedValue;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Page2.aspx?id=" + txtprodid.Text);
        }
    }
}