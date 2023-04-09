using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Var1"] = "Message from View Data";
            ViewBag.Var2 = "Message form View Bag";

            TempData["Var3"] = "Message from Temp Data";

            //string[] Games = {"Cricket", "Baseball", "Hockey"};
            //TempData["GamesArray"] = Games;

            return View();
        }

        public ActionResult About()
        {
            if(TempData["Var3"] != null)
            {
                TempData["Var3"].ToString();
            }
            return View();
        }
    }
}