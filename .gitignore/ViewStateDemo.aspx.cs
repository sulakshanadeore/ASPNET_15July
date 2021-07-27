using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class ViewStateDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)//Page.IsPostback
            {
                ViewState["counter"] = 1;
            }
            else
            {
             ViewState["counter"] = Convert.ToInt32(ViewState["counter"]) + 1;

            }
            txthits.Text = ViewState["hits"].ToString();
        }

       

        protected void btnacceptdata_Click(object sender, EventArgs e)
        {
            string s = txtname.Text;
            //storing value in viewstate
            ViewState["uname"] = s;
            //Dictionary-----key/value-----
            //object
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            //accessing/retriving/getting back value from viewstate
            txtdisplay.Text = ViewState["uname"].ToString();
                
        }
    }
}