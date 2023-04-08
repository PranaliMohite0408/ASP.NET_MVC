using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_Bag_Demo.Models;

namespace View_Bag_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Message From ViewBag !!";
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();

            string[] fruits = { "Apple", "Mango", "Orange", "Banana" };
            ViewBag.FruitsArray = fruits;

            ViewBag.SportsList = new List<string>()
            {
                   "Cricket",
                   "Footboll",
                   "Baseball",
                   "Hockey"
            };

            Employee obj = new Employee();

            obj.EmpID = 11;
            obj.EmpName = "Jay Ganesh";
            obj.EmpDesignation = "Software Developer";

            ViewBag.Employee = obj;

            //ViewBag.CommonMessage = "This Message is accessible by ViewBag and ViewData ";

            ViewData["CommonMessage"] = "This Message is accessible by ViewBag and ViewData ";

            return View();
        }
    }
}