namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bus_BusStop", "BusId", "dbo.Buses");
            DropForeignKey("dbo.Bus_BusStop", "BusStopId", "dbo.BusStops");
            DropForeignKey("dbo.Route_BusStop", "BusStopId", "dbo.BusStops");
            DropForeignKey("dbo.Route_BusStop", "RouteId", "dbo.Routes");
            DropIndex("dbo.Bus_BusStop", new[] { "BusStopId" });
            DropIndex("dbo.Bus_BusStop", new[] { "BusId" });
            DropIndex("dbo.BusStops", new[] { "bus_Id" });
            DropIndex("dbo.BusStops", new[] { "route_Id" });
            DropIndex("dbo.Route_BusStop", new[] { "BusStopId" });
            DropIndex("dbo.Route_BusStop", new[] { "RouteId" });
            RenameColumn(table: "dbo.BusStops", name: "bus_Id", newName: "busId");
            RenameColumn(table: "dbo.BusStops", name: "route_Id", newName: "routeId");
            AlterColumn("dbo.BusStops", "busId", c => c.Int(nullable: false));
            AlterColumn("dbo.BusStops", "routeId", c => c.Int(nullable: false));
            CreateIndex("dbo.BusStops", "busId");
            CreateIndex("dbo.BusStops", "routeId");
            DropTable("dbo.Bus_BusStop");
            DropTable("dbo.Route_BusStop");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Route_BusStop",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusStopId = c.Int(nullable: false),
                        RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bus_BusStop",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusStopId = c.Int(nullable: false),
                        BusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropIndex("dbo.BusStops", new[] { "routeId" });
            DropIndex("dbo.BusStops", new[] { "busId" });
            AlterColumn("dbo.BusStops", "routeId", c => c.Int());
            AlterColumn("dbo.BusStops", "busId", c => c.Int());
            RenameColumn(table: "dbo.BusStops", name: "routeId", newName: "route_Id");
            RenameColumn(table: "dbo.BusStops", name: "busId", newName: "bus_Id");
            CreateIndex("dbo.Route_BusStop", "RouteId");
            CreateIndex("dbo.Route_BusStop", "BusStopId");
            CreateIndex("dbo.BusStops", "route_Id");
            CreateIndex("dbo.BusStops", "bus_Id");
            CreateIndex("dbo.Bus_BusStop", "BusId");
            CreateIndex("dbo.Bus_BusStop", "BusStopId");
            AddForeignKey("dbo.Route_BusStop", "RouteId", "dbo.Routes", "Id");
            AddForeignKey("dbo.Route_BusStop", "BusStopId", "dbo.BusStops", "Id");
            AddForeignKey("dbo.Bus_BusStop", "BusStopId", "dbo.BusStops", "Id");
            AddForeignKey("dbo.Bus_BusStop", "BusId", "dbo.Buses", "Id");
        }
    }
}
