namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeysAddedToPresentantionAndCollection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Presentations", "Collection_Id", c => c.Int());
            CreateIndex("dbo.Presentations", "Collection_Id");
            AddForeignKey("dbo.Presentations", "Collection_Id", "dbo.Collections", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Presentations", "Collection_Id", "dbo.Collections");
            DropIndex("dbo.Presentations", new[] { "Collection_Id" });
            DropColumn("dbo.Presentations", "Collection_Id");
        }
    }
}
