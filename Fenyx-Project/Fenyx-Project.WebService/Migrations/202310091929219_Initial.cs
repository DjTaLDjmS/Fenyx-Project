namespace Fenyx_Project.WebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Street = c.String(),
                        Zipcode = c.Int(nullable: false),
                        City = c.String(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        PhotoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Address", "Id", "dbo.User");
            DropForeignKey("dbo.Address", "User_Id", "dbo.User");
            DropIndex("dbo.Address", new[] { "User_Id" });
            DropIndex("dbo.Address", new[] { "Id" });
            DropTable("dbo.User");
            DropTable("dbo.Address");
        }
    }
}
