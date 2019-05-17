namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBrithDate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "SubModel_Id", "dbo.SubModels");
            DropIndex("dbo.Customers", new[] { "SubModel_Id" });
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "SubModel_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "SubModel_Id");
            AddForeignKey("dbo.Customers", "SubModel_Id", "dbo.SubModels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "SubModel_Id", "dbo.SubModels");
            DropIndex("dbo.Customers", new[] { "SubModel_Id" });
            AlterColumn("dbo.Customers", "SubModel_Id", c => c.Int());
            DropColumn("dbo.Customers", "BirthDate");
            CreateIndex("dbo.Customers", "SubModel_Id");
            AddForeignKey("dbo.Customers", "SubModel_Id", "dbo.SubModels", "Id");
        }
    }
}
