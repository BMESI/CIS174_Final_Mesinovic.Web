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
    [Route("api/v1/students")]
    public class StudentApiController : ApiController
    {
        private readonly StudentOrchestrator _studentOrchestrator;
        public StudentApiController()
        {
            //(string actionName, string controllerName)
            _studentOrchestrator = new StudentOrchestrator();
        }
        [HttpGet]
        public List<StudentViewModel> GetAllStudents()
        {
            var students = _studentOrchestrator.GetAllStudents();
            return students.ToList();
        }
    }
}