using CIS174_Final_Mesinovic.Shared.Orchestrators;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using CIS174_Final_Mesinovic.Web.Models;
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
        // added 2/16/19 -- async for student 'troller
        /* dont think i need this now 
        public async TaskEventHandler<ActionResult> Index()
        {
            var studentViewModel = new StudentViewModel
            {
                Students = await _studentOrchestrator.GetAllStudents()
            };
            return View(studentViewModel);
        }*/
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
        public ActionResult Update()
        {
            return View();
        }
        //added 2/16/19 -- tbc at 13
        /// 2/17/19 -- not sure about this async task section , removing it. 
         /*
        public async Task<JsonResult> UpdateStudent(UpdateStudentModel student)
        {
            if(student.StudentId == Guid.Empty)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            var result = await _studentOrchestrator.UpdateStudent(new StudentViewModel
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Major = student.Major,
                Gender=student.Gender,
                DateofBirth=student.DateofBirth
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        } */
    }

}
