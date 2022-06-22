namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bus_BusStop_Route",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusId = c.Int(nullable: false),
                        BusStopRouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.BusId)
                .ForeignKey("dbo.BusStop_Route", t => t.BusStopRouteId)
                .Index(t => t.BusId)
                .Index(t => t.BusStopRouteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bus_BusStop_Route", "BusStopRouteId", "dbo.BusStop_Route");
            DropForeignKey("dbo.Bus_BusStop_Route", "BusId", "dbo.Buses");
            DropIndex("dbo.Bus_BusStop_Route", new[] { "BusStopRouteId" });
            DropIndex("dbo.Bus_BusStop_Route", new[] { "BusId" });
            DropTable("dbo.Bus_BusStop_Route");
        }
    }
}
