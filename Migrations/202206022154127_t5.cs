namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.BusStops", new[] { "busId" });
            DropIndex("dbo.BusStops", new[] { "routeId" });
            RenameColumn(table: "dbo.BusStops", name: "busId", newName: "bus_Id");
            RenameColumn(table: "dbo.BusStops", name: "routeId", newName: "route_Id");
            AlterColumn("dbo.BusStops", "bus_Id", c => c.Int());
            AlterColumn("dbo.BusStops", "route_Id", c => c.Int());
            CreateIndex("dbo.BusStops", "bus_Id");
            CreateIndex("dbo.BusStops", "route_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.BusStops", new[] { "route_Id" });
            DropIndex("dbo.BusStops", new[] { "bus_Id" });
            AlterColumn("dbo.BusStops", "route_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.BusStops", "bus_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.BusStops", name: "route_Id", newName: "routeId");
            RenameColumn(table: "dbo.BusStops", name: "bus_Id", newName: "busId");
            CreateIndex("dbo.BusStops", "routeId");
            CreateIndex("dbo.BusStops", "busId");
        }
    }
}
