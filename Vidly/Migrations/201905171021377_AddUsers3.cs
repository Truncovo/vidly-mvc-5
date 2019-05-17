namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsers3 : DbMigration
    {
        public override void Up()
        {
           Sql("INSERT INTO Customers (name,NewsLetter,SubModel_Id,BirthDate) VALUES ('Hedulka',1,2,null)");

      }

      public override void Down()
        {
        }
    }
}
