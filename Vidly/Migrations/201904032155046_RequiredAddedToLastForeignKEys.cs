namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredAddedToLastForeignKEys : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Collections", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Collections", "Name", c => c.String());
        }
    }
}
