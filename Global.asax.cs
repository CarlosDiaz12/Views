using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Views.Infrastructure;

namespace Views
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Removing the Other View Engines
            ViewEngines.Engines.Clear();

            // ViewEngines.Engines.Insert(0, new DebugDataViewEngine()); - the first view engine that MVC will use

            // Registering a Custom View Engine
            ViewEngines.Engines.Add(new DebugDataViewEngine());
        }
    }
}
