using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class LoginData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            ValidateUser user = new ValidateUser();

            user.username = txtusername.Text;
            user.userpassword = txtpwd.Text;

            if (user.username == "Priti" && user.userpassword == "priti")
            {


        HttpCookie cookie = new HttpCookie("userlogin");
                cookie.Values.Add("username", user.username);
                cookie.Values.Add("pwd", user.userpassword);
                cookie.Expires = DateTime.Now.AddMinutes(5);
                Response.Cookies.Add(cookie);
                Response.Redirect("~/welcome.aspx");

            }
        }
    }
}