namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Catalogs", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Catalogs", "Name", c => c.String());
        }
    }
}
