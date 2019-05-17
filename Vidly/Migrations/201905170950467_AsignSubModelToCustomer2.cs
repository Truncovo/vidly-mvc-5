namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AsignSubModelToCustomer2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "SubModel_Id", c => c.Int());
            CreateIndex("dbo.Customers", "SubModel_Id");
            AddForeignKey("dbo.Customers", "SubModel_Id", "dbo.SubModels", "Id");
            DropColumn("dbo.Customers", "SubModelId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "SubModelId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Customers", "SubModel_Id", "dbo.SubModels");
            DropIndex("dbo.Customers", new[] { "SubModel_Id" });
            DropColumn("dbo.Customers", "SubModel_Id");
        }
    }
}
