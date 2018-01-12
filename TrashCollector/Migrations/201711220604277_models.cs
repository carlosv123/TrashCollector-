namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        streetName = c.String(),
                        city = c.String(),
                        zipcode = c.String(),
                        StartSchedule = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.requestforms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nopickupstart = c.DateTime(nullable: false),
                        nopickupend = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.requestforms");
            DropTable("dbo.Addresses");
        }
    }
}
