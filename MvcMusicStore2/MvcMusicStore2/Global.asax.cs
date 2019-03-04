﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcMusicStore2.Models;

namespace MvcMusicStore2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer(
                new MvcMusicStore2.Models.SampleData());
            AreaRegistration.RegisterAllAreas();
           // RegisterGlobalFilter(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
