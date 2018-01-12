namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatenew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.requestOffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        requestStart = c.String(),
                        requestEnd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.requestOffs");
        }
    }
}
