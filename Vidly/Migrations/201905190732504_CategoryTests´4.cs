namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryTests4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Teams", "CategoryId");
            AddForeignKey("dbo.Teams", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Teams", new[] { "CategoryId" });
            DropColumn("dbo.Teams", "CategoryId");
        }
    }
}
