namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateadressmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "firstName", c => c.String());
            AddColumn("dbo.Addresses", "lastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Addresses", "lastName");
            DropColumn("dbo.Addresses", "firstName");
        }
    }
}
