namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t51 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bus_BusStop",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusStopId = c.Int(nullable: false),
                        BusId = c.Int(nullable: false),
                        RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.BusId)
                .ForeignKey("dbo.BusStops", t => t.BusStopId)
                .ForeignKey("dbo.Routes", t => t.RouteId)
                .Index(t => t.BusStopId)
                .Index(t => t.BusId)
                .Index(t => t.RouteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bus_BusStop", "RouteId", "dbo.Routes");
            DropForeignKey("dbo.Bus_BusStop", "BusStopId", "dbo.BusStops");
            DropForeignKey("dbo.Bus_BusStop", "BusId", "dbo.Buses");
            DropIndex("dbo.Bus_BusStop", new[] { "RouteId" });
            DropIndex("dbo.Bus_BusStop", new[] { "BusId" });
            DropIndex("dbo.Bus_BusStop", new[] { "BusStopId" });
            DropTable("dbo.Bus_BusStop");
        }
    }
}
