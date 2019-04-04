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
        // just add new set here
        public DbSet<Person> ProjectMembers { get; set; }
        public DbSet<HighScore> Leaderboard { get; set; }
        // add: player Dbset 2/14 
        public DbSet<Player> Player { get; set; }
        public DbSet<ErrorLog> Error { get; set; }
        // trying to use a list of highscores instead of dbset 
        //
        public List<HighScore> LeaderboardTestList { get; set; }
    //   public DbSet<ApplicationUser> ApplicationUser        { get; set; }

}
   /* public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
    }*/

    }
