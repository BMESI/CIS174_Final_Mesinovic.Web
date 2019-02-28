using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Shared.ViewModels
{
    public class ErrorViewModel
    {
        public Guid ErrorId { get; set; }
        public DateTime? ErrorDateTime { get; set; }

        public string ErrorMessage { get; set; }

        public string StackTrace { get; set; }

        public string InnerExceptions { get; set; }


     
        

    }
}
