namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t51 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HomeRoutes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BsuStopId = c.Int(nullable: false),
                        busStop_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusStops", t => t.busStop_Id)
                .Index(t => t.busStop_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HomeRoutes", "busStop_Id", "dbo.BusStops");
            DropIndex("dbo.HomeRoutes", new[] { "busStop_Id" });
            DropTable("dbo.HomeRoutes");
        }
    }
}
