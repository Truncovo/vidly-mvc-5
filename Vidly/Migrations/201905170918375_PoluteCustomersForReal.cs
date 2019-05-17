namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PoluteCustomersForReal : DbMigration
    {
        public override void Up()
        {
           Sql("INSERT INTO Customers (name,NewsLetter) VALUES ('Bill Gates', 1)");
           Sql("INSERT INTO Customers (name,NewsLetter) VALUES ('Elon Musk', 0)");
           Sql("INSERT INTO Customers (name,NewsLetter) VALUES ('Steave Jobs', 0)");
      }
        
        public override void Down()
        {
        }
    }
}
