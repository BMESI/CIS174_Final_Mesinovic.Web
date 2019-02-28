using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Domain.Entities
{
    public class ErrorLog
    {
        [Key]
        public Guid ErrorId { get; set; }
        public DateTime? ErrorDateTime { get; set; }

        public string ErrorMessage { get; set; }

        public string StackTrace { get; set; }

        public string InnerExceptions { get; set; }
    }
}
