using System;
using System.Web.Mvc;

namespace ExceptionFilterMVC.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult Index()
        {
            throw new Exception();
            return View();
        }
      
        public ActionResult About()
        {
            throw new Exception();
            return View();
        }
    }
}