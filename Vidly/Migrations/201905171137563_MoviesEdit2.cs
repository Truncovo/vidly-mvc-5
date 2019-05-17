namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesEdit2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "BirthDate");
        }
    }
}
