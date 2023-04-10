using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["var1"] = "Data comes form View Data";
            ViewBag.var2 = "Data comes from view bag";
            TempData["var3"] = "Data comes from Temp Data";
            Session["var4"] = "Data comes from Session";

            string[] students = { "abc", "xyz", "pqr" };
            Session["var5"] = students;

            return View();
        }

        public ActionResult About()
        {
            if(Session["var4"] != null)
            {
                Session["var4"].ToString();
            }
            return View();
        }

        public ActionResult Contact()
        {
            if (Session["var4"] != null)
            {
                Session["var4"].ToString();
            }
            return View();
        }
    }
}