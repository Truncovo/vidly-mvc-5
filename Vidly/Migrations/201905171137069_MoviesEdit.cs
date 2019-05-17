namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesEdit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "TotalCopies", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "AvalibleCopies", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AvalibleCopies");
            DropColumn("dbo.Movies", "TotalCopies");
        }
    }
}
