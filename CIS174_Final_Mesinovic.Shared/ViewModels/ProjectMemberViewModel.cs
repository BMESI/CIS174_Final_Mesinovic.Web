using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Shared.ViewModels
{
    public class ProjectMemberViewModel
    {
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Role { get; set; }
        public string Email { get; set; }
        public DateTime? DateCreated { get; set; }

        public List<ProjectMemberViewModel> projectmemberlist { get; set; }

    }
}
