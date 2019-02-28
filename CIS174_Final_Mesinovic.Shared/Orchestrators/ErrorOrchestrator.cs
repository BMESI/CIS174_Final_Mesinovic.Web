using CIS174_Final_Mesinovic.Domain;
using CIS174_Final_Mesinovic.Domain.Entities;
using CIS174_Final_Mesinovic.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Shared.Orchestrators
{
    public class ErrorOrchestrator
    {

        private readonly SchoolContext _schoolContext;
        public ErrorOrchestrator()
        {
            _schoolContext = new SchoolContext();
        }
        public ErrorOrchestrator(Exception ome)
        {
            _schoolContext = new SchoolContext();
            Error(ome);

        }
        public void Error(Exception ome)
        {
            ErrorLog _error = new ErrorLog();
            _error.ErrorId = Guid.NewGuid();
            _error.ErrorDateTime = DateTime.Now;
            _error.ErrorMessage = ome.Message;
            _error.StackTrace = ome.StackTrace;
            while(ome.InnerException != null)
            {
                _error.InnerExceptions += ome.InnerException.ToString();

            }

            _schoolContext.Error.Add(_error);
            _schoolContext.SaveChanges();

        }

    }
}
