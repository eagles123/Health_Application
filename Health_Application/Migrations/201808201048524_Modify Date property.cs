namespace Health_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyDateproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Time", c => c.DateTime(nullable: false));
            AddColumn("dbo.Responses", "Time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Responses", "Time");
            DropColumn("dbo.Posts", "Time");
        }
    }
}
