using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TCC
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string Label1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("numbel of online " + Application["user session"]);
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox2.Text = TxtBox1.Text;
           
        }
    }
}