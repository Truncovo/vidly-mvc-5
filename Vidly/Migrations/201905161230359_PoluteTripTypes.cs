namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PoluteTripTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TripTypes", "Name", c => c.String());
           
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TripTypes", "Name", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
