using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideStateMgtDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Session ID=  " + Session.SessionID);
            Response.Write("<br/>");
            Response.Write("Is a New Session= " + Session.IsNewSession);
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Prodid"] = Convert.ToInt32(txtprodid.Text);
            Session["pname"] = txtprodname.Text;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ShowProducts.aspx");
        }
    }
}