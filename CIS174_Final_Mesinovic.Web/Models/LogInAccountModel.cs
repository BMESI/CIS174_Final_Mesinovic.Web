using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CIS174_Final_Mesinovic.Web.Models
{
    public class LogInAccountModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int Phone { get; set; }
        public string UserPassword { get; set; }
        //  public string ConfirmUserPassword { get; set; }
    }
}