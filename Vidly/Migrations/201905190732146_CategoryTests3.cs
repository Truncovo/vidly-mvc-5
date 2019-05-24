namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryTests3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teams", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Teams", new[] { "Category_Id" });
            DropColumn("dbo.Teams", "Category_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Category_Id", c => c.Int());
            CreateIndex("dbo.Teams", "Category_Id");
            AddForeignKey("dbo.Teams", "Category_Id", "dbo.Categories", "Id");
        }
    }
}
