using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Data_Annotations.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "ID is Mandatory")]
        public int EmployeeId{ get; set; }

        [Required(ErrorMessage = "Name is Mandatory")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Age is Mandatory")]
        public int? EmployeeAge { get; set; }

        [Required(ErrorMessage = "Gender is Mandatory")]
        public string EmployeeGender { get; set; }
        
        [Required(ErrorMessage = "Email is Mandatory")]
        public string EmplpyeeEmail{ get; set; }

    }
}