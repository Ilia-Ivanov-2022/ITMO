using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ITMO.ASP.NET.Lab1.RSVP
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            
            Application["Visitors"] = 0; // Visitors counter.
            // Increment visitors counter.
            Application["Visitors"] = long.Parse(Application["Visitors"].ToString()) + 1;

            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}