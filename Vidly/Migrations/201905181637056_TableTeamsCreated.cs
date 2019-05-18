namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableTeamsCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SleepInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerCount = c.Int(nullable: false),
                        MenCount = c.Int(nullable: false),
                        WomanCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Coach = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Note = c.String(),
                        SleepInfoDayOne_Id = c.Int(),
                        SleepInfoDayTwo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SleepInfoes", t => t.SleepInfoDayOne_Id)
                .ForeignKey("dbo.SleepInfoes", t => t.SleepInfoDayTwo_Id)
                .Index(t => t.SleepInfoDayOne_Id)
                .Index(t => t.SleepInfoDayTwo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "SleepInfoDayTwo_Id", "dbo.SleepInfoes");
            DropForeignKey("dbo.Teams", "SleepInfoDayOne_Id", "dbo.SleepInfoes");
            DropIndex("dbo.Teams", new[] { "SleepInfoDayTwo_Id" });
            DropIndex("dbo.Teams", new[] { "SleepInfoDayOne_Id" });
            DropTable("dbo.Teams");
            DropTable("dbo.SleepInfoes");
        }
    }
}
