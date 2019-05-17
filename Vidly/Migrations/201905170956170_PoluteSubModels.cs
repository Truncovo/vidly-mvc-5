namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PoluteSubModels : DbMigration
    {
        public override void Up()
        {
           Sql("INSERT INTO SubModels (name, discount) VALUES ('monthly',25)");
           Sql("INSERT INTO SubModels (name, discount) VALUES ('yearly',40)");
           Sql("INSERT INTO SubModels (name, discount) VALUES ('none',0)");


      }

      public override void Down()
        {
        }
    }
}
