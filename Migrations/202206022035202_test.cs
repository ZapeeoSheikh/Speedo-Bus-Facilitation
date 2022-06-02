namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusAttendents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Salary = c.Int(nullable: false),
                        cardId = c.Int(nullable: false),
                        busId = c.Int(nullable: false),
                        roleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.busId)
                .ForeignKey("dbo.BusCards", t => t.cardId)
                .ForeignKey("dbo.Roles", t => t.roleId)
                .Index(t => t.cardId)
                .Index(t => t.busId)
                .Index(t => t.roleId);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        No = c.Int(nullable: false),
                        Start = c.String(),
                        End = c.String(),
                        TotalStops = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BusCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CardNo = c.Int(nullable: false),
                        Limit = c.Int(nullable: false),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BalanceHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cardId = c.Int(nullable: false),
                        History = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusCards", t => t.cardId)
                .Index(t => t.cardId);
            
            CreateTable(
                "dbo.BusStops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        busId = c.Int(nullable: false),
                        cardId = c.Int(nullable: false),
                        stopId = c.Int(nullable: false),
                        routeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.busId)
                .ForeignKey("dbo.BusCards", t => t.cardId)
                .ForeignKey("dbo.Routes", t => t.routeId)
                .ForeignKey("dbo.Stops", t => t.stopId)
                .Index(t => t.busId)
                .Index(t => t.cardId)
                .Index(t => t.stopId)
                .Index(t => t.routeId);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Distance = c.Int(nullable: false),
                        lineId = c.Int(nullable: false),
                        stopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lines", t => t.lineId)
                .ForeignKey("dbo.Stops", t => t.stopId)
                .Index(t => t.lineId)
                .Index(t => t.stopId);
            
            CreateTable(
                "dbo.Lines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CurrentStop = c.String(),
                        NextStop = c.String(),
                        PrevStop = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.Depots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NoOfBus = c.Int(nullable: false),
                        NoServiceBus = c.Int(nullable: false),
                        busId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.busId)
                .Index(t => t.busId);
            
            CreateTable(
                "dbo.Directions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        routeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Routes", t => t.routeId)
                .Index(t => t.routeId);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Salary = c.Int(nullable: false),
                        RoutePerDay = c.Int(nullable: false),
                        busCardId = c.Int(nullable: false),
                        busId = c.Int(nullable: false),
                        routeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.busId)
                .ForeignKey("dbo.BusCards", t => t.busCardId)
                .ForeignKey("dbo.Routes", t => t.routeId)
                .Index(t => t.busCardId)
                .Index(t => t.busId)
                .Index(t => t.routeId);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Department = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        busCardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusCards", t => t.busCardId)
                .Index(t => t.busCardId);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        ValidTime = c.DateTime(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passengers", "busCardId", "dbo.BusCards");
            DropForeignKey("dbo.Drivers", "routeId", "dbo.Routes");
            DropForeignKey("dbo.Drivers", "busCardId", "dbo.BusCards");
            DropForeignKey("dbo.Drivers", "busId", "dbo.Buses");
            DropForeignKey("dbo.Directions", "routeId", "dbo.Routes");
            DropForeignKey("dbo.Depots", "busId", "dbo.Buses");
            DropForeignKey("dbo.BusStops", "stopId", "dbo.Stops");
            DropForeignKey("dbo.BusStops", "routeId", "dbo.Routes");
            DropForeignKey("dbo.Routes", "stopId", "dbo.Stops");
            DropForeignKey("dbo.Routes", "lineId", "dbo.Lines");
            DropForeignKey("dbo.BusStops", "cardId", "dbo.BusCards");
            DropForeignKey("dbo.BusStops", "busId", "dbo.Buses");
            DropForeignKey("dbo.BalanceHistories", "cardId", "dbo.BusCards");
            DropForeignKey("dbo.BusAttendents", "roleId", "dbo.Roles");
            DropForeignKey("dbo.BusAttendents", "cardId", "dbo.BusCards");
            DropForeignKey("dbo.BusAttendents", "busId", "dbo.Buses");
            DropIndex("dbo.Passengers", new[] { "busCardId" });
            DropIndex("dbo.Drivers", new[] { "routeId" });
            DropIndex("dbo.Drivers", new[] { "busId" });
            DropIndex("dbo.Drivers", new[] { "busCardId" });
            DropIndex("dbo.Directions", new[] { "routeId" });
            DropIndex("dbo.Depots", new[] { "busId" });
            DropIndex("dbo.Routes", new[] { "stopId" });
            DropIndex("dbo.Routes", new[] { "lineId" });
            DropIndex("dbo.BusStops", new[] { "routeId" });
            DropIndex("dbo.BusStops", new[] { "stopId" });
            DropIndex("dbo.BusStops", new[] { "cardId" });
            DropIndex("dbo.BusStops", new[] { "busId" });
            DropIndex("dbo.BalanceHistories", new[] { "cardId" });
            DropIndex("dbo.BusAttendents", new[] { "roleId" });
            DropIndex("dbo.BusAttendents", new[] { "busId" });
            DropIndex("dbo.BusAttendents", new[] { "cardId" });
            DropTable("dbo.Tokens");
            DropTable("dbo.Passengers");
            DropTable("dbo.Jobs");
            DropTable("dbo.Drivers");
            DropTable("dbo.Directions");
            DropTable("dbo.Depots");
            DropTable("dbo.Stops");
            DropTable("dbo.Lines");
            DropTable("dbo.Routes");
            DropTable("dbo.BusStops");
            DropTable("dbo.BalanceHistories");
            DropTable("dbo.Roles");
            DropTable("dbo.BusCards");
            DropTable("dbo.Buses");
            DropTable("dbo.BusAttendents");
        }
    }
}
