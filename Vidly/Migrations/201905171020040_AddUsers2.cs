namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsers2 : DbMigration
    {
        public override void Up()
        {
           Sql("INSERT INTO Customers (name,NewsLetter,SubModel_Id,BirthDate) VALUES ('Truncovo',1,2,'07.07.1992')");

      }

      public override void Down()
        {
        }
    }
}
