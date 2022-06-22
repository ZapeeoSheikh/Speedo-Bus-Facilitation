namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t81 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bus_BusStop_Route", "BusId", "dbo.Buses");
            DropForeignKey("dbo.BusStop_Route", "BusStopId", "dbo.BusStops");
            DropForeignKey("dbo.BusStop_Route", "RouteId", "dbo.Routes");
            DropForeignKey("dbo.Bus_BusStop_Route", "BusStopRouteId", "dbo.BusStop_Route");
            DropForeignKey("dbo.Bus_Route", "busId", "dbo.Buses");
            DropForeignKey("dbo.Bus_Route", "routeId", "dbo.Routes");
            DropIndex("dbo.Bus_BusStop_Route", new[] { "BusId" });
            DropIndex("dbo.Bus_BusStop_Route", new[] { "BusStopRouteId" });
            DropIndex("dbo.BusStop_Route", new[] { "BusStopId" });
            DropIndex("dbo.BusStop_Route", new[] { "RouteId" });
            DropIndex("dbo.Bus_Route", new[] { "busId" });
            DropIndex("dbo.Bus_Route", new[] { "routeId" });
            AddColumn("dbo.BusStops", "RouteNo", c => c.Int(nullable: false));
            AddColumn("dbo.BusStops", "RouteName", c => c.String());
            DropTable("dbo.Bus_BusStop_Route");
            DropTable("dbo.BusStop_Route");
            DropTable("dbo.Bus_Route");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Bus_Route",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        busId = c.Int(nullable: false),
                        routeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BusStop_Route",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusStopId = c.Int(nullable: false),
                        RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bus_BusStop_Route",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusId = c.Int(nullable: false),
                        BusStopRouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.BusStops", "RouteName");
            DropColumn("dbo.BusStops", "RouteNo");
            CreateIndex("dbo.Bus_Route", "routeId");
            CreateIndex("dbo.Bus_Route", "busId");
            CreateIndex("dbo.BusStop_Route", "RouteId");
            CreateIndex("dbo.BusStop_Route", "BusStopId");
            CreateIndex("dbo.Bus_BusStop_Route", "BusStopRouteId");
            CreateIndex("dbo.Bus_BusStop_Route", "BusId");
            AddForeignKey("dbo.Bus_Route", "routeId", "dbo.Routes", "Id");
            AddForeignKey("dbo.Bus_Route", "busId", "dbo.Buses", "Id");
            AddForeignKey("dbo.Bus_BusStop_Route", "BusStopRouteId", "dbo.BusStop_Route", "Id");
            AddForeignKey("dbo.BusStop_Route", "RouteId", "dbo.Routes", "Id");
            AddForeignKey("dbo.BusStop_Route", "BusStopId", "dbo.BusStops", "Id");
            AddForeignKey("dbo.Bus_BusStop_Route", "BusId", "dbo.Buses", "Id");
        }
    }
}
