﻿using Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{
        //    HttpContext.Current.Items["_EntityContext"] = new CatalogContext();
        //}

        //protected void Application_EndRequest(object sender, EventArgs e)
        //{
        //    var entityContext = HttpContext.Current.Items["_EntityContext"] = new CatalogContext();
        //    if (entityContext != null)
        //        entityContext.Dispose();
        //}
    }
}