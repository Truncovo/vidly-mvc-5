namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteSecond : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Catalogs", "CatalogCollection_Id", "dbo.CatalogCollections");
            DropIndex("dbo.Catalogs", new[] { "CatalogCollection_Id" });
            DropColumn("dbo.Catalogs", "CatalogCollection_Id");
            DropTable("dbo.CatalogCollections");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CatalogCollections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Catalogs", "CatalogCollection_Id", c => c.Int());
            CreateIndex("dbo.Catalogs", "CatalogCollection_Id");
            AddForeignKey("dbo.Catalogs", "CatalogCollection_Id", "dbo.CatalogCollections", "Id");
        }
    }
}
