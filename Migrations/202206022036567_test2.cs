namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Routes", "lineId", "dbo.Lines");
            DropForeignKey("dbo.Routes", "stopId", "dbo.Stops");
            DropIndex("dbo.Routes", new[] { "lineId" });
            DropIndex("dbo.Routes", new[] { "stopId" });
            AddColumn("dbo.Routes", "Name", c => c.String());
            AddColumn("dbo.Routes", "Number", c => c.Int(nullable: false));
            DropColumn("dbo.Routes", "lineId");
            DropColumn("dbo.Routes", "stopId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Routes", "stopId", c => c.Int(nullable: false));
            AddColumn("dbo.Routes", "lineId", c => c.Int(nullable: false));
            DropColumn("dbo.Routes", "Number");
            DropColumn("dbo.Routes", "Name");
            CreateIndex("dbo.Routes", "stopId");
            CreateIndex("dbo.Routes", "lineId");
            AddForeignKey("dbo.Routes", "stopId", "dbo.Stops", "Id");
            AddForeignKey("dbo.Routes", "lineId", "dbo.Lines", "Id");
        }
    }
}
