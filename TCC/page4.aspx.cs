using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TCC
{
    public partial class page4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string fname = Request.QueryString.Get("fname");
            //string sname = Request.QueryString.Get("sname");
            //TextBox1.Text = "your first name is:" + fname+"<br>your second name is:"+sname;
            //string x = Request.Cookies["First_name:"].ToString();
            //TextBox1.Text = "your first name is:" + fname ;
            Response.Write("Hi "+Request.QueryString.Get("name")+"&how are you?");
             Label1.Text = "The Name is:" + Session["name"];
            HttpCookieCollection cookie = Request.Cookies;
            Label1.Text = "The Name is:" + cookie["name"].Value;

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //    Application["user"] = (int)Application["user" + 1];
            //  TextBox1.Text = Application["user"].ToString();
           // TextBox1.Text = "name :"+Session["name"];
        }
    }
}