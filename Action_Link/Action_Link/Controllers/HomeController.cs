using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Action_Link.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUS()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }
}