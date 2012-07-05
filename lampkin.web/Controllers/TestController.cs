using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using System.Linq;

namespace Lampkin.Web.Controllers
{
    public class TestController : Controller
    {
        public TestController()
        {
        }

        public ActionResult Index()
        {           
            return View();
        }

        public ActionResult Boids()
        {
            return View();
        }

        public ActionResult WebGl()
        {
            return View();
        }
    }
}