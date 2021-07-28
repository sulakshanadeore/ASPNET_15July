using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WholeStateMgtDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusname.Text=="ran" && txtpwd.Text=="ran@1234")
            {
                // Session["username"] = txtusname.Text;
                Session.Add("username", txtusname.Text);
                Response.Redirect("~/Welcome.aspx");
            }
        }
    }
}