using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CIS174_Final_Mesinovic.Web.Models
{
    public class RegisterAccountModel
    {
        public int PersonId { get; set; }
        public string PlayerName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public int Phone { get; set; }
        [Required]
        // these data annotations cause errors 
       // [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
       // [DataType(DataType.Password)]
       // [Display(Name = "UserPassword")]
        public string UserPassword { get; set; }
        //[DataType(DataType.Password)]
       // [Display(Name = "ConfirmUserPassword")]
     //   [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmUserPassword { get; set; }
        //  public string ConfirmUserPassword { get; set; }
    }
}