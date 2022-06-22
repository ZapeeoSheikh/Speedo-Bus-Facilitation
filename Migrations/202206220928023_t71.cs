namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t71 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BusStop_Route", "RouteId", c => c.Int(nullable: false));
            CreateIndex("dbo.BusStop_Route", "RouteId");
            AddForeignKey("dbo.BusStop_Route", "RouteId", "dbo.Routes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BusStop_Route", "RouteId", "dbo.Routes");
            DropIndex("dbo.BusStop_Route", new[] { "RouteId" });
            DropColumn("dbo.BusStop_Route", "RouteId");
        }
    }
}
