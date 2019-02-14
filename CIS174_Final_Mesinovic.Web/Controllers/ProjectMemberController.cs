using CIS174_Final_Mesinovic.Shared.Orchestrators;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS174_Final_Mesinovic.Web.Controllers
{
    [Route("controller/ProjectMembers")]

    public class ProjectMemberController : Controller
    {

            private readonly ProjectMemberOrchestrator _projectmemberOrchestrator;
            public ProjectMemberController()
            {
                _projectmemberOrchestrator = new ProjectMemberOrchestrator();
            }
            [HttpGet]
            /// getallprojectmembers
            public List<ProjectMemberViewModel> GetAllMembers()
            {
                var members = _projectmemberOrchestrator.GetAllMembers();
                return members.ToList();
            }
            
            //GET: ProjectMember
            public ActionResult Members()
            {
                return View();
            }

    }
}