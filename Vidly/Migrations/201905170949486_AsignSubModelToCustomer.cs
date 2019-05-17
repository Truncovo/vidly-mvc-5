namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AsignSubModelToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "SubModelId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "SubModelId");
        }
    }
}
