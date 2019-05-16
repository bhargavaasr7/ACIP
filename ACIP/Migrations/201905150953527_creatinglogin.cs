namespace ACIP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creatinglogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Logins");
        }
    }
}
