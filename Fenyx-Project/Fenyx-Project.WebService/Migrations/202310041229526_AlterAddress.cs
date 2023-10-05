namespace Fenyx_Project.WebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterAddress : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Address", new[] { "Id" });
            DropPrimaryKey("dbo.Address");
            AlterColumn("dbo.Address", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Address", "Id");
            CreateIndex("dbo.Address", "Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Address", new[] { "Id" });
            DropPrimaryKey("dbo.Address");
            AlterColumn("dbo.Address", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Address", "Id");
            CreateIndex("dbo.Address", "Id");
        }
    }
}
