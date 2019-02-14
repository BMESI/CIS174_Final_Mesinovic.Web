using CIS174_Final_Mesinovic.Domain;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Shared.Orchestrators
{
    public class ProjectMemberOrchestrator
    {
        private readonly SchoolContext _schoolContext;
        public ProjectMemberOrchestrator()
        {
            _schoolContext = new SchoolContext();
        }
        public List<ProjectMemberViewModel> GetAllMembers()
        {
            var members = _schoolContext.ProjectMembers.Select(m => new ProjectMemberViewModel
            {
                // left side = view model ; right side = database
              FirstName=m.FirstName,
              LastName=m.LastName,
              Role=m.Role,
              Email=m.Email,
              DateCreated=m.DateCreated,
              PersonId=m.PersonId
            }).ToList();
            return members;
        }
    }
}
