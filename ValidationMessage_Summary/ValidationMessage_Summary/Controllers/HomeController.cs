using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ValidationMessage_Summary.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        string EmailPattern = "^[A - Z0 - 9 + _.-] +@[A-Z0-9.-]+$";
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string FullName,string Age,string Email)
        {
            if(FullName.Equals("") == true)
            {
                ModelState.AddModelError("FullName","Full Name is Required !!!");
                ViewData["FullNameError"] = "*";
            }

            if (Age.Equals("") == true)
            {
                ModelState.AddModelError("Age", " Age is Required !!!");
                ViewData["AgeError"] = "*";
            }

            if (Email.Equals("") == true)
            {
                ModelState.AddModelError("Email", "Email is Required !!!");
                ViewData["EmailError"] = "*";
            }

            if (ModelState.IsValid == true)
            {
                ViewData["SuccessMessage"] = "<script>alert('Data has been submited ')</script>";
                ModelState.Clear();
            }
            else
            {
                if(Regex.IsMatch(Email,EmailPattern) == false)
                {
                    ModelState.AddModelError("Email", "Invalid Email!!!");
                    ViewData["EmailError"] = "*";
                }
            }
            return View();
        }

    }
}