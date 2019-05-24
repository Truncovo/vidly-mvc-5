namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryTests2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Teams", name: "CategoryId", newName: "Category_Id");
            RenameIndex(table: "dbo.Teams", name: "IX_CategoryId", newName: "IX_Category_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Teams", name: "IX_Category_Id", newName: "IX_CategoryId");
            RenameColumn(table: "dbo.Teams", name: "Category_Id", newName: "CategoryId");
        }
    }
}
