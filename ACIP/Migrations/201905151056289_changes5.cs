namespace ACIP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.registrations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        age = c.Int(nullable: false),
                        mobile = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.registrations");
        }
    }
}
