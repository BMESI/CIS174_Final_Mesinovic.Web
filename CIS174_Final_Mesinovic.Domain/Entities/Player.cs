using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// added 2/15/19 : player class for registration and such
namespace CIS174_Final_Mesinovic.Domain.Entities
{
    public class Player
    {
        [Key]
        public int PersonId { get; set; }
        public string PlayerName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string UserPassword { get; set; }
      //  public string ConfirmUserPassword { get; set; }

    }
}
