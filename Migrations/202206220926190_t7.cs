namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusStop_Route",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusStopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusStops", t => t.BusStopId)
                .Index(t => t.BusStopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BusStop_Route", "BusStopId", "dbo.BusStops");
            DropIndex("dbo.BusStop_Route", new[] { "BusStopId" });
            DropTable("dbo.BusStop_Route");
        }
    }
}
