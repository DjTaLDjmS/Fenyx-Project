namespace Fenyx_Project.WebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Street = c.String(),
                        Zipcode = c.Int(nullable: false),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.Id)
                .Index(t => t.Id);
            
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
            DropIndex("dbo.Address", new[] { "Id" });
            DropTable("dbo.User");
            DropTable("dbo.Address");
        }
    }
}
