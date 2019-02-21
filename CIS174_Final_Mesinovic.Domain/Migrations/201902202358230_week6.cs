namespace CIS174_Final_Mesinovic.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class week6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(),
                        Gender = c.String(),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                        UserPassword = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
