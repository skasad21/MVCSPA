using MVCSPA.Filters;
using System.Web;
using System.Web.Mvc;

namespace MVCSPA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new SpaResponseAttribute());
        }
    }
}
