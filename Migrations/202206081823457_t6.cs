namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BusStops", "BusRoute_Id", c => c.Int());
            CreateIndex("dbo.BusStops", "BusRoute_Id");
            AddForeignKey("dbo.BusStops", "BusRoute_Id", "dbo.Bus_Route", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BusStops", "BusRoute_Id", "dbo.Bus_Route");
            DropIndex("dbo.BusStops", new[] { "BusRoute_Id" });
            DropColumn("dbo.BusStops", "BusRoute_Id");
        }
    }
}
