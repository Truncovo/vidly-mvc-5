namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PasswordMinAndMaxLenghtAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teams", "Password", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Password", c => c.String());
        }
    }
}
