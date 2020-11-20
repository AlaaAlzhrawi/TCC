using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TCC
{
    public partial class page_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("the name is :" + Application["application_start"]);
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            ViewState["name"] = txtname.Text;
            ViewState["age"] = txtage.Text;
            txtname.Text = txtage.Text = "";
        }

        protected void btnview_Click(object sender, EventArgs e)
        {
            Response.Write("Name :" + ViewState["name"] + "Age :" + ViewState["age"]);

        }

        protected void btndone_Click(object sender, EventArgs e)
        {
            Response.Redirect("page4.aspx?name=" + txtname.Text);
        }

        protected void btnsession_Click(object sender, EventArgs e)
        {
            Session["name"] = txtname.Text;
            Response.Redirect("~/page4.aspx");
           // Label1.Text = "The Name is:" + Session["name"];

        }

        protected void btncookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("my name :" + txtname.Text);
            cookie.Expires=DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/page4.aspx");

        }
    }
}