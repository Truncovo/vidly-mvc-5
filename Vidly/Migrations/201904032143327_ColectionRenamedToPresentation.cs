namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColectionRenamedToPresentation : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Catalogs", newName: "Presentations");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Presentations", newName: "Catalogs");
        }
    }
}
