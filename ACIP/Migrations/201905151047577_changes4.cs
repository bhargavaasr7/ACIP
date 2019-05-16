namespace ACIP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logins", "UserName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logins", "UserName", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
