using CIS174_Final_Mesinovic.Domain;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using System.Collections.Generic;
using System.Linq;
// 2/16/19 -- added eveyrhitng below asynch task
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
                StudentId = m.StudentId,
                FirstName = m.FirstName,
                LastName = m.LastName,
                DateofBirth = m.DateofBirth,
                Gender = m.Gender,
                Major = m.Major
            }).ToList();
            return students;
        }
        // 2/17/19 -- not sure about this code section/method
       /*  public async Task<bool> UpdateStudent(StudentViewModel student)
        {
            var updateEntity = await _schoolContext.Students.FindAsync(student.StudentId);
            if(updateEntity == null)
            {// if no id, dont send anything
                return false;
            }
            updateEntity.FirstName = student.FirstName;
            updateEntity.LastName = student.LastName;
            updateEntity.Gender = student.Gender;
            updateEntity.DateofBirth = student.DateofBirth;
            updateEntity.Major = student.Major;
            //tells how many rec'ds updated
            await _schoolContext.SaveChangesAsync();
            return true;
            throw new System.NotImplementedException();
        }*/
    }
}
