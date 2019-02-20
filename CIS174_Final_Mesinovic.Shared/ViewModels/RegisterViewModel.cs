using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Shared.ViewModels
{
    // 2/16/19 -- added "required" annotations, confirm password string, match annotation
    public class RegisterViewModel
    {   [Key]
        public int PersonId { get; set; }
        [Required]
        public string PlayerName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int? Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        [DataType(DataType.Password)]
        [Compare("UserPassword", ErrorMessage ="Passwords do not match.")]
        public string ConfirmUserPassword { get; set; }

    }
}
