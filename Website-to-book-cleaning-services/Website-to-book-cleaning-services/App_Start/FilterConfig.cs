using System.Web;
using System.Web.Mvc;

namespace Website_to_book_cleaning_services
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
