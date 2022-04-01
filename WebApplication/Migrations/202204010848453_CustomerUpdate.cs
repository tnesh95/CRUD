namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "ContactNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "ContactNumber", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
