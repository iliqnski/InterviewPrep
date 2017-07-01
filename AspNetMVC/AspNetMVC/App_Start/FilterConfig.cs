namespace AspNetMVC
{
    using AspNetMVC.Filters;
    using System.Web;
    using System.Web.Mvc;

    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //check if it is already defined
            filters.Add(new AddSystemheaderStampActionFilter());
        }
    }
}
