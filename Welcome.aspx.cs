using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WholeStateMgtDemo
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Label1.Text = Session["username"].ToString();
            Label1.Text = Session.Contents["username"].ToString();
            Label2.Text = Application["appusers"].ToString();
        }
    }
}