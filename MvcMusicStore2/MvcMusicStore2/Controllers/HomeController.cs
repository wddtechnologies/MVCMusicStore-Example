﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
      public ActionResult Index()
     // public string Index()
        {
          //  return "Hello from Home";
           return View();
        }
    }
}