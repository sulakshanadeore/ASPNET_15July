using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class UseHidden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string s = TextBox1.Text;
            if (s.Contains("@"))
            {
                Response.Write("Found @");
            }
            else
            {
                Response.Write("Do it again");
            }
           
            //if (TextBox1.Text==HiddenField1.Value)
            //{
            //    Response.Write("Your answer is correct");
            //}
            //else
            //{
            //    Response.Write("Wrong answer");
            //}
        }
    }
}