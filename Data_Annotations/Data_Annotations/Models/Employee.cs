using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Data_Annotations.Models
{
    public class Employee
    {
        [DisplayName("ID")]
        [Required(ErrorMessage = "ID is Mandatory")]
        public int EmployeeId{ get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is Mandatory")]
        [StringLength(20,MinimumLength =5, ErrorMessage ="Name should be between 5 to 20 ")]
        public string EmployeeName { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is Mandatory")]
        [Range(20,60,ErrorMessage ="Age should be in the range 20 to 6ZX0")]
        public int? EmployeeAge { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is Mandatory")]
        public string EmployeeGender { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is Mandatory")]
        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$",ErrorMessage ="Enter Valid Email ID !!")]
        public string EmplpyeeEmail{ get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is Mandatory")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage ="Enter Valid Password")]
        public int EmpPassword { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Employee Password is Mandatory")]

        [Compare("EmpPassword", ErrorMessage = "Employee Confirm Password is Mandatory")]
        public int EmpConfirmPassword { get; set; }


        [DisplayName("Organization Name")]
        [ReadOnly(true)]
        public string EmpOrganizationName { get; set; }
    }
}