using Abc.MvcWebUI.Identity;
using Proje.MvcWebUI.Entity;
using Proje.MvcWebUI.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Proje.MvcWebUI
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
