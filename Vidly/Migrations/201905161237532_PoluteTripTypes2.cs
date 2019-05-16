namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PoluteTripTypes2 : DbMigration
    {
        public override void Up()
        {
           Sql("INSERT INTO TripTypes (Name) VALUES ('Car')");
        }
        
        public override void Down()
        {
        }
    }
}
