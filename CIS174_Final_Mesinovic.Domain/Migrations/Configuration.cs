using CIS174_Final_Mesinovic.Domain.Entities;
using System;
using System.Data.Entity.Migrations;

namespace CIS174_Final_Mesinovic.Domain.Migrations
{
    using CIS174_Final_Mesinovic.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
            context.Students.AddOrUpdate(new Student
            {
                // (x x x x x x x x-xxxx- xx xx -xxxx-xxx xxx xxx xxx)
                StudentId = Guid.Parse("21111111-2222-3333-4444-555555555555"),
                FirstName = "BEN MESI",
                LastName = "Mesi",
                DateofBirth = new DateTime(1955, 10, 10),
                Major = "Bis",
                Gender = "Male"

            });
            context.Students.AddOrUpdate(new Student
            {
                StudentId = Guid.Parse("31111111-3333-3333-4444-555555555555"),
                FirstName = "BEN MESI TWO",
                LastName = "Mesi",
                DateofBirth = new DateTime(1955, 10, 10),
                Major = "Bis",
                Gender = "Male"

            });
            context.ProjectMembers.AddOrUpdate(new Person
            {
                PersonId = Guid.Parse("41111111-4444-3333-4444-555555555555"),
                FirstName = "BEN MESI",
                LastName = "Mesi",
                Email = "BMe@dmacc.edu",
                DateCreated = new DateTime(2019, 2, 13)


            });
            context.Leaderboard.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("52111116-2555-3333-4444-555555555555"),
                PersonId = Guid.Parse("11111114-6662-3333-4444-555555555555"),
                Score = 5,
                DateAttained = new DateTime(2009, 1, 1)

            });
            context.Leaderboard.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("21111111-1999-3333-4444-555555555555"),
                PersonId = Guid.Parse("11119111-1522-1111-4444-555555555555"),
                Score = 5,
                DateAttained = new DateTime(2009, 1, 1)

            });
            context.Leaderboard.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("11111111-9922-3333-4444-555555555555"),
                PersonId = Guid.Parse("11111111-7700-3333-4444-555555555555"),
                Score = 5,
                DateAttained = new DateTime(2009, 1, 1)

            });
            context.Leaderboard.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("11111111-4422-1333-4444-555555555555"),
                PersonId = Guid.Parse("22111111-1111-3333-4444-555555555555"),
                Score = 5,
                DateAttained = new DateTime(2009, 1, 1)

            });

        }

    }
}
