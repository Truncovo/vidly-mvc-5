namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsers : DbMigration
    {
        public override void Up()
        {
           Sql("INSERT INTO Customers (name,NewsLetter,SubModel_Id) VALUES ('Trunda',1,2)");
        }
        
        public override void Down()
        {
        }
    }
}
