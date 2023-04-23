using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Strongly_Typed_PartialView.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Picture { get; set; }

    }
}