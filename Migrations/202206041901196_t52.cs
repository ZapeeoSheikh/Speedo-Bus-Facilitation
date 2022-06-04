namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t52 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bus_BusStop",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        busId = c.Int(nullable: false),
                        busStopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.busId)
                .ForeignKey("dbo.BusStops", t => t.busStopId)
                .Index(t => t.busId)
                .Index(t => t.busStopId);
            
            DropTable("dbo.Stops");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Stops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Names = c.String(),
                        StopNumber = c.Int(nullable: false),
                        NumberOfStops = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Bus_BusStop", "busStopId", "dbo.BusStops");
            DropForeignKey("dbo.Bus_BusStop", "busId", "dbo.Buses");
            DropIndex("dbo.Bus_BusStop", new[] { "busStopId" });
            DropIndex("dbo.Bus_BusStop", new[] { "busId" });
            DropTable("dbo.Bus_BusStop");
        }
    }
}
