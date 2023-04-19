using Difference_ViewData_And_ViewBag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Difference_ViewData_And_ViewBag.Controllers
{
    public class HomeController : Controller
    {
        public object Empolyee { get; private set; }
        public object Empoloyee { get; private set; }

        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message1"] = "Data Comes from ViewData";

            ViewBag.Message2 = "Data Comes from ViewBag";

            ViewData["CurrentDate1"] = DateTime.Now.ToString();
            ViewBag.CurrentDate2 = DateTime.Now.ToString();

            string[] games = { "Hockey", "Cricket", "BaseBall", "Football" };

            ViewData["GamesArray1"] = games;
            ViewBag.GamesArray2 = games;

            Employee obj = new Employee();
            obj.EmpID = 11;
            obj.EmpName = "JayGanesh";
            obj.EmpAge = 21;

            ViewData["Employee1"] = obj;
            ViewBag.Employee2 = obj;

            return View();
        }
    }
}