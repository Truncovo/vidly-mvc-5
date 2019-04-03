namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSLides : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Order = c.Int(nullable: false),
                        Presentation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Presentations", t => t.Presentation_Id)
                .Index(t => t.Presentation_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Slides", "Presentation_Id", "dbo.Presentations");
            DropIndex("dbo.Slides", new[] { "Presentation_Id" });
            DropTable("dbo.Slides");
        }
    }
}
