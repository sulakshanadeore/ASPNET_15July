using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class ReceiveData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write(Request.QueryString["custname"].ToString());

            Response.Write(Request.QueryString["emailid"].ToString());


        }
    }
}