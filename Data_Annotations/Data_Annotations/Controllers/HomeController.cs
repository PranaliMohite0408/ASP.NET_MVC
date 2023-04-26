using Data_Annotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Data_Annotations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee obj)
        {
            if(ModelState.IsValid == true)
            {
                ViewData["SuccessMessage"] = "<script>alert('Data Has been submited !!!')</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}