using CIS174_Final_Mesinovic.Shared.Orchestrators;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CIS174_Final_Mesinovic.Web.API
{
    [Route("api/v1/ProjectMembers")]
    public class ProjectMemberApiController : ApiController
    {

        private readonly Shared.Orchestrators.ProjectMemberOrchestrator _projectmemberorchestrator;
        public ProjectMemberApiController()
        {
            _projectmemberorchestrator = new ProjectMemberOrchestrator();
        }
        [HttpGet]
        public List<ProjectMemberViewModel> GetAllMembers()
        {
            // members == 
            var ProjectMembers = _projectmemberorchestrator.GetAllMembers();
            return ProjectMembers.ToList();
        }

    }
}