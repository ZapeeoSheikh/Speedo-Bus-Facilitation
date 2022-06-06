namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t54 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BusStops", "busId", "dbo.Buses");
            DropForeignKey("dbo.BusStops", "routeId", "dbo.Routes");
            DropIndex("dbo.BusStops", new[] { "busId" });
            DropIndex("dbo.BusStops", new[] { "routeId" });
            DropColumn("dbo.BusStops", "busId");
            DropColumn("dbo.BusStops", "routeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BusStops", "routeId", c => c.Int(nullable: false));
            AddColumn("dbo.BusStops", "busId", c => c.Int(nullable: false));
            CreateIndex("dbo.BusStops", "routeId");
            CreateIndex("dbo.BusStops", "busId");
            AddForeignKey("dbo.BusStops", "routeId", "dbo.Routes", "Id");
            AddForeignKey("dbo.BusStops", "busId", "dbo.Buses", "Id");
        }
    }
}
