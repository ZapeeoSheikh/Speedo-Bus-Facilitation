namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t53 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bus_Route",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        busId = c.Int(nullable: false),
                        routeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.busId)
                .ForeignKey("dbo.Routes", t => t.routeId)
                .Index(t => t.busId)
                .Index(t => t.routeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bus_Route", "routeId", "dbo.Routes");
            DropForeignKey("dbo.Bus_Route", "busId", "dbo.Buses");
            DropIndex("dbo.Bus_Route", new[] { "routeId" });
            DropIndex("dbo.Bus_Route", new[] { "busId" });
            DropTable("dbo.Bus_Route");
        }
    }
}
