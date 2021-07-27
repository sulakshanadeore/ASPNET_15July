using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie=Request.Cookies["userlogin"];
            Label1.Text=cookie.Values["username"].ToString();
            // cookie.Values["pwd"].ToString();
        }
    }
}