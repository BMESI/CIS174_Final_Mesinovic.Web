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
        /// keep this for later
        /**  private readonly context _context;
         public Orchestrator()
         {
             _context = new context();
         }**/

        /*            var members = _Context.members.Select(m => new ProjectMemberViewModel
        {
            // left side = view model ; right side = database
            FirstName = m.FirstName,

        }).ToList();*/
        public List<ProjectMemberViewModel> GetAllProjectMembers()
        {
            var members = new List<ProjectMemberViewModel>
                {
                new ProjectMemberViewModel
                    {
                    Name = "Ben",
                    Email = "Bme@Dmacc.edu",
                    Role ="Student"
                    }
            }.ToList();
            return members;
        }
    }
}
