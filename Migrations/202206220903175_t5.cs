namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bus_BusStop", "busId", "dbo.Buses");
            DropForeignKey("dbo.BusStops", "Bus_Id", "dbo.Buses");
            DropForeignKey("dbo.BusStops", "BusRoute_Id", "dbo.Bus_Route");
            DropIndex("dbo.Bus_BusStop", new[] { "busId" });
            DropIndex("dbo.BusStops", new[] { "Bus_Id" });
            DropIndex("dbo.BusStops", new[] { "BusRoute_Id" });
            DropColumn("dbo.Bus_BusStop", "busId");
            DropColumn("dbo.BusStops", "Bus_Id");
            DropColumn("dbo.BusStops", "BusRoute_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BusStops", "BusRoute_Id", c => c.Int());
            AddColumn("dbo.BusStops", "Bus_Id", c => c.Int());
            AddColumn("dbo.Bus_BusStop", "busId", c => c.Int(nullable: false));
            CreateIndex("dbo.BusStops", "BusRoute_Id");
            CreateIndex("dbo.BusStops", "Bus_Id");
            CreateIndex("dbo.Bus_BusStop", "busId");
            AddForeignKey("dbo.BusStops", "BusRoute_Id", "dbo.Bus_Route", "Id");
            AddForeignKey("dbo.BusStops", "Bus_Id", "dbo.Buses", "Id");
            AddForeignKey("dbo.Bus_BusStop", "busId", "dbo.Buses", "Id");
        }
    }
}
