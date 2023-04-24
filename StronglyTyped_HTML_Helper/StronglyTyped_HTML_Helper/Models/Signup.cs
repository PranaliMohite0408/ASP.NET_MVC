using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StronglyTyped_HTML_Helper.Models
{
    public class Signup
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserGender { get; set; }
        public string UserEmail { get; set; }
        public string UserComment { get; set; }
    }
}