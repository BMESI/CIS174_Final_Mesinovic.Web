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
    [Route("api/v1/members")]
    public class ProjectMemberApiController : ApiController
    {

            private readonly Shared.Orchestrators.ProjectMemberOrchestrator _projectmemberorchestrator;
            public ProjectMemberApiController()
            {
                _projectmemberorchestrator = new ProjectMemberOrchestrator();
            }
            [HttpGet]
            public List<ProjectMemberViewModel> GetAllProjectMembers()
            {
                var members = _projectmemberorchestrator.GetAllProjectMembers();
                return members.ToList();
            }



            /* Default code - might need later 
             * // GET api/<controller>
            public IEnumerable<string> Get()
            {
                return new string[] { "value1", "value2" };
            }

            // GET api/<controller>/5
            public string Get(int id)
            {
                return "value";
            }

            // POST api/<controller>
            public void Post([FromBody]string value)
            {
            }

            // PUT api/<controller>/5
            public void Put(int id, [FromBody]string value)
            {
            }

            // DELETE api/<controller>/5
            public void Delete(int id)
            {
            }
            */

        
    }
}