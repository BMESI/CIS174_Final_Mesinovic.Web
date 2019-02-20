using CIS174_Final_Mesinovic.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace CIS174_Final_Mesinovic.Web.Models
{
    public class StudentModel
    {
        [Display(Name = "Name: ")]
        public string FirstName { get; set; }
        [Display(Name = "")]
        public string LastName { get; set; }
        [Display(Name = "Age: ")]
        public string Age { get; set; }
        [Display(Name = "Major: ")]
        public string Major { get; set; }
        [Display(Name = "Gender: ")]
        public String Gender { get; set; }
        public List<StudentViewModel> StudentsList { get; set; }
    }
}