using Strongly_Typed_View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Strongly_Typed_View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee obj = new Employee();
            obj.ID = 11;
            obj.Name = "abc";
            obj.Age = 22;

            Employee obj1 = new Employee();
            obj1.ID = 21;
            obj1.Name = "xyz";
            obj1.Age = 23;

            Employee obj2 = new Employee();
            obj2.ID = 7;
            obj2.Name = "pqr";
            obj2.Age = 24;

            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(obj);
            EmployeeList.Add(obj1);
            EmployeeList.Add(obj2);

            ViewData["var1"] = obj;
            ViewBag.var2 = obj;

            return View(EmployeeList); //strongly Typed
        }
    }
}