namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCategoryToTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Category_Id", c => c.Int());
            CreateIndex("dbo.Teams", "Category_Id");
            AddForeignKey("dbo.Teams", "Category_Id", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Teams", new[] { "Category_Id" });
            DropColumn("dbo.Teams", "Category_Id");
        }
    }
}
