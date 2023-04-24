using StronglyTyped_HTML_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTyped_HTML_Helper.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
     
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculations C)
        {
            int num1 = C.num1;
            int num2 = C.num2;
            int Result = num1 + num2;

            ViewBag.Result = Result;
            return View();
        }

       
    }
}