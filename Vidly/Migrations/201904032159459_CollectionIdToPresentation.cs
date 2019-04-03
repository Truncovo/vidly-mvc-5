namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CollectionIdToPresentation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Presentations", "Collection_Id", "dbo.Collections");
            DropIndex("dbo.Presentations", new[] { "Collection_Id" });
            RenameColumn(table: "dbo.Presentations", name: "Collection_Id", newName: "CollectionId");
            AlterColumn("dbo.Presentations", "CollectionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Presentations", "CollectionId");
            AddForeignKey("dbo.Presentations", "CollectionId", "dbo.Collections", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Presentations", "CollectionId", "dbo.Collections");
            DropIndex("dbo.Presentations", new[] { "CollectionId" });
            AlterColumn("dbo.Presentations", "CollectionId", c => c.Int());
            RenameColumn(table: "dbo.Presentations", name: "CollectionId", newName: "Collection_Id");
            CreateIndex("dbo.Presentations", "Collection_Id");
            AddForeignKey("dbo.Presentations", "Collection_Id", "dbo.Collections", "Id");
        }
    }
}
