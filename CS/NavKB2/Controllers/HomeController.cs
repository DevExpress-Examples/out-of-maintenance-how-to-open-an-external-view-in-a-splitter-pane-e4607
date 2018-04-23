using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NavKB2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowFirst() {
            return View("SampleView1");
        }
        public ActionResult ShowSecond() {
            return View("SampleView2");
        }
    }
}