using CIS174_Final_Mesinovic.Shared.Orchestrators;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIS174_Final_Mesinovic.Web.Controllers
{
    [Route("controllers/students")]
    public class StudentController : Controller
    {
        private readonly StudentOrchestrator _studentOrchestrator;
        public StudentController()
        {
            _studentOrchestrator = new StudentOrchestrator();
        }
        [HttpGet]
        public List<StudentViewModel> GetAllStudents()
        {
            var students = _studentOrchestrator.GetAllStudents();
            return students;
        }
        //GET: Student
        public ActionResult ViewAllStudents()
        {
            return View();
        }
        
    }
}
