using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITMO.ASP.NET.Lab1.RSVP
{
    public partial class Reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Validate();
            if (!Page.IsValid) return;

            if (IsPostBack) // If responce => instance of responce.
            {
                GuestResponse rsvp =
                    new GuestResponse(name.Text, email.Text, phone.Text, CheckBoxYN.Checked);

                // Place the instance of responce to repository.
                ResponseRepository.GetRepository().AddResponse(rsvp);

                // Feedback to 
                if (rsvp.WillAttend.HasValue && rsvp.WillAttend.Value)
                {
                    Response.Redirect("seeyouthere.html");
                }
                else
                    Response.Redirect("sorryyoucantcome.html");
            }
            
        }
    }
}