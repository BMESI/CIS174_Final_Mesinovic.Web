namespace CIS174_Final_Mesinovic.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class err_migr2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ErrorLogs", "ErrorDateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ErrorLogs", "ErrorDateTime", c => c.DateTime(nullable: false));
        }
    }
}
