using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using System.Linq;

namespace Lampkin.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {            
        }

        public ActionResult Index()
        {           
            return View();
        }
    }


}