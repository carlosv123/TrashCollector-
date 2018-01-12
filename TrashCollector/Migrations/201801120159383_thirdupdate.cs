namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.requestforms", "firstName", c => c.String());
            AddColumn("dbo.requestforms", "lastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.requestforms", "lastName");
            DropColumn("dbo.requestforms", "firstName");
        }
    }
}
