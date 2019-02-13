using CIS174_Final_Mesinovic.Domain;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace CIS174_Final_Mesinovic.Shared.Orchestrators
{
    public class StudentOrchestrator
    {
        private readonly SchoolContext _schoolContext;
        public StudentOrchestrator()
        {
            _schoolContext = new SchoolContext();
        }
        public List<StudentViewModel> GetAllStudents()
        {
            var students = _schoolContext.Students.Select(m => new StudentViewModel
            {
                // left side = view model ; right side = database
                FirstName = m.FirstName,
                LastName = m.LastName,
                DateofBirth = m.DateofBirth,
                Gender = m.Gender,
                Major = m.Major
            }).ToList();
            return students;
        }
    }
}
