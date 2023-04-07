using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_Data_Demo.Models;

namespace View_Data_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message"] = "Message from View Data !!";
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();

            string[] Fruits = {"Apple","Banana", "Orange", "Mango"};
            ViewData["FruitsArray"] = Fruits;

            ViewData["SportsList"] = new List<String>()
            {
                "Cricket",
                "Hockey",
                "Footboll",
                "Kho-Kho"
            };

            Employee John = new Employee();
            John.EmpID = 10;
            John.EmpName = "John Sen";
            John.EmpDesignation = "Manager";

            ViewData["Employee"] = John;
            
            return View();
        }
    }
}