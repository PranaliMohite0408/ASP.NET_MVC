using Strongly_Typed_PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Strongly_Typed_PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        List<Product> ProductsList = new List<Product>()
        {
            new Product {Id = 1, Name = "Reebok Shoes", Price=1000, Picture = "~/Images/IMG1.jfif"},      
            new Product {Id = 2, Name = "Sparks", Price=2000, Picture = "~/Images/IMG2.jfif"},
            new Product {Id = 3, Name = "Reebok Shoes", Price=3000, Picture = "~/Images/IMG3.jfif"}
        };

        public ActionResult Index()
        {         
            return View(ProductsList);
        }
    }
}
