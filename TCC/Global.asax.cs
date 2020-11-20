using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace TCC
{
    public class Global : System.Web.HttpApplication
    {


        protected void Application_Start(object sender, EventArgs e)
        {
        //    Application["AppstartMessage"] = "Welcome to CSharp Corner Developer Communtiy";
            Application["application_start"] = (int)Application["application_start"] +1;
        }
      
        void Application_Error(object sender, EventArgs e)
        {
            // Write an unhandled error code exception  

        }


        protected void Application_End(object sender, EventArgs e)
        {
        //    Application["AppEndMessage"] = "Application Closed";
         Application["application_end"] = (int)Application["application_end"] -1;
        }





    }
    }