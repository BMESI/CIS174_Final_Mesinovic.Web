using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 2/16/19 -- added LoginViewmodel and props playername and userpassword
namespace CIS174_Final_Mesinovic.Shared.ViewModels
{
    public  class LoginViewModel
    {
        [Required(ErrorMessage = "Email Required.")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password Required.")]
        public string UserPassword { get; set; }

    }
}
