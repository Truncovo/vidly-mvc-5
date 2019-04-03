namespace Vidly.Migrations
{
   using System;
   using System.Data.Entity.Migrations;

   public partial class PopulateCatalogs : DbMigration
   {
      public override void Up()
      {
         Sql("INSERT INTO Catalogs (Name) VALUES ('WestFjords')");
         Sql("INSERT INTO Catalogs (Name) VALUES ('Iceland')");
         Sql("INSERT INTO Catalogs (Name) VALUES ('Landmanalaugar')");
      }

      public override void Down()
      {
      }
   }
}
