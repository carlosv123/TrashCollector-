namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        amount = c.Double(nullable: false),
                        paymentType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.paymentTypes", t => t.paymentType_Id)
                .Index(t => t.paymentType_Id);
            
            CreateTable(
                "dbo.paymentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.payments", "paymentType_Id", "dbo.paymentTypes");
            DropIndex("dbo.payments", new[] { "paymentType_Id" });
            DropTable("dbo.paymentTypes");
            DropTable("dbo.payments");
        }
    }
}
