using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Shared.ViewModels
{
    // 2/16/19 -- added "required" annotations, confirm password string, match annotation
    public class AccountViewModel
    {
        [Key]
        public int PersonId { get; set; }
        [Required(ErrorMessage = "Nicknae Required.")]
        public string PlayerName { get; set; }
        [Required(ErrorMessage = "First name Required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name Required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Age (number) Required.")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Gender Required.")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Email Required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone# Required.")]
        public int Phone { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("UserPassword", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
