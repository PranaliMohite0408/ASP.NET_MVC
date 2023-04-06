using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Action_Method_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string Show()
        {
            return "This is a Second action method of home controller";
        }

        public ActionResult AboutUS()
        {
            return View();
        }
        public int StudentID(int id)
        {
            return id;
        }
    }
}