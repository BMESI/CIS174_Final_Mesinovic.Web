namespace CIS174_Final_Mesinovic.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix_migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Password", c => c.String());
            DropColumn("dbo.Players", "UserPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "UserPassword", c => c.String());
            DropColumn("dbo.Players", "Password");
        }
    }
}
