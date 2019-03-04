namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateOfBirthPropertyinCustomer1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "DateOfBirt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DateOfBirt", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "DateOfBirth");
        }
    }
}
