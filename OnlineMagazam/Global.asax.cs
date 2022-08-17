using OnlineMagazam.Entity;
using OnlineMagazam.Identity;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineMagazam
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer(new DataInitializer());
            Database.SetInitializer(new IdentityInitializer());
        }
    }
}
