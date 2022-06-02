namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BusStops", "cardId", "dbo.BusCards");
            DropForeignKey("dbo.BusStops", "stopId", "dbo.Stops");
            DropIndex("dbo.BusStops", new[] { "cardId" });
            DropIndex("dbo.BusStops", new[] { "stopId" });
            DropColumn("dbo.BusStops", "cardId");
            DropColumn("dbo.BusStops", "stopId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BusStops", "stopId", c => c.Int(nullable: false));
            AddColumn("dbo.BusStops", "cardId", c => c.Int(nullable: false));
            CreateIndex("dbo.BusStops", "stopId");
            CreateIndex("dbo.BusStops", "cardId");
            AddForeignKey("dbo.BusStops", "stopId", "dbo.Stops", "Id");
            AddForeignKey("dbo.BusStops", "cardId", "dbo.BusCards", "Id");
        }
    }
}
