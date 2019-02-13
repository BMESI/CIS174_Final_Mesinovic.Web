using CIS174_Final_Mesinovic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Domain
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

    }
}
