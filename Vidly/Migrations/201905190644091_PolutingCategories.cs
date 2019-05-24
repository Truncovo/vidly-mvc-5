namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PolutingCategories : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String());

           Sql("INSERT INTO Categories (Name, MaxAge) VALUES ('Mlad�� ��kyn�', 14 )");
           Sql("INSERT INTO Categories (Name, MaxAge) VALUES ('Star�� ��kyn�', 16 )");
           Sql("INSERT INTO Categories (Name, MaxAge) VALUES ('Kadetky', 18 )");
           Sql("INSERT INTO Categories (Name, MaxAge) VALUES ('Juniorky', 20 )");

      }

      public override void Down()
        {
            AlterColumn("dbo.Categories", "Name", c => c.Int(nullable: false));
        }
    }
}
