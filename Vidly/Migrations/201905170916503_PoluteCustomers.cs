namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PoluteCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "NewsLetter", c => c.Boolean(nullable: false));
           

      }

      public override void Down()
        {
            DropColumn("dbo.Customers", "NewsLetter");
        }
    }
}
