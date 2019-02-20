using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS174_Final_Mesinovic.Web.Models
{
    public class UpdateAccountModel
    {
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