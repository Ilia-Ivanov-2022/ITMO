using System.Web;
using System.Web.Mvc;

namespace ITMO.ASP.NET.MVC.Lab4.MvcCreditApp1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
