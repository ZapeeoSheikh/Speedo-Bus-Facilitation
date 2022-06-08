namespace Speedo_Bus_Facilitation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class t61 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "Post", c => c.String());
            AddColumn("dbo.Jobs", "Location", c => c.String());
            DropColumn("dbo.Jobs", "Title");
            DropColumn("dbo.Jobs", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jobs", "Description", c => c.String());
            AddColumn("dbo.Jobs", "Title", c => c.String());
            DropColumn("dbo.Jobs", "Location");
            DropColumn("dbo.Jobs", "Post");
        }
    }
}
