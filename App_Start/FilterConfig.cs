using System.Web;
using System.Web.Mvc;

namespace MVRWebsite_Unibit_5sem_MWT_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
