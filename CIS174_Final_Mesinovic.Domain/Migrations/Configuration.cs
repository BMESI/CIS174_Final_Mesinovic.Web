using CIS174_Final_Mesinovic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS174_Final_Mesinovic.Domain.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CIS174_Final_Mesinovic.Domain.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CIS174_Final_Mesinovic.Domain.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            // Adding some data right here
            context.Students.AddOrUpdate(new Student
            {
                FirstName = "BEN MESI",
                LastName = "Mesi",
                DateofBirth = new DateTime(1945, 10, 10),
                Major = "BIS",
                Gender = "MALE"

            });
            context.Students.AddOrUpdate(new Student
            {
                FirstName = "BEN ",
                LastName = "MESI TWO",
                DateofBirth = new DateTime(1955, 10, 10),
                Major="BIS2",
                Gender = "Male"

            });
        }
    }
}
