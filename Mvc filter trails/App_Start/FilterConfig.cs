using System.Web;
using System.Web.Mvc;
using MVC_filter_trails.infra;
namespace MVC_filter_trails
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // filters.Add(new HandleErrorAttribute());
            filters.Add(new myappexceptionAttribute());
        }
    }
}
