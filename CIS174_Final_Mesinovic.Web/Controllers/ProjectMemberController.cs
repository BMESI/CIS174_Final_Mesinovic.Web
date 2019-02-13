using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS174_Final_Mesinovic.Web.Controllers
{
    public class ProjectMemberController : Controller
    {


       // [Route("api/v1/ProjectMembers")]

            /*private readonly ProjectMemberOrchestrator _projectmemberOrchestrator;
            public ProjectMemberController()
            {
                _projectmemberOrchestrator = new ProjectMemberOrchestrator();
            }
            [HttpGet]
            public List<ProjectMemberViewModel> GetAllProjectMembers()
            {
                var members = _projectmemberOrchestrator.GetAllProjectMembers();
                return members.ToList();
            }
            */
            //GET: ProjectMember
            public ActionResult Members()
            {
                return View();
            }

    }
}