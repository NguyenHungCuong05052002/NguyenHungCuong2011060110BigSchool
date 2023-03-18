using System.Web;
using System.Web.Mvc;

namespace NguyenHungCuong2011060110
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
