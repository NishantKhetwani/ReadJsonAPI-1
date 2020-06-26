using System.Web.Http;
using System.Web.Http.Filters;

namespace ReadJsonAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RegisterWebApiFilters(GlobalConfiguration.Configuration.Filters);
        }
        public static void RegisterWebApiFilters(HttpFilterCollection filters)
        {
            filters.Add(new HandleExceptionFilterAttribute());
        }
    }
}
