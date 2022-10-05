using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITMO.ASP.NET.Lab1.RSVP
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            long numVisitors = 0;

            if (Application["Visitors"] != null)
            {
                numVisitors = long.Parse(Application["Visitors"].ToString());
            }
            VisitorLiteral.Text = "Число посещений " + numVisitors.ToString();
        }
    }
}