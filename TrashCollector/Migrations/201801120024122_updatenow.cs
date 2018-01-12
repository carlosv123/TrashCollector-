namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatenow : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.infoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        firstname = c.String(),
                        lastname = c.String(),
                        Amountid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Amounts", t => t.Amountid, cascadeDelete: true)
                .Index(t => t.Amountid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.infoes", "Amountid", "dbo.Amounts");
            DropIndex("dbo.infoes", new[] { "Amountid" });
            DropTable("dbo.infoes");
        }
    }
}
