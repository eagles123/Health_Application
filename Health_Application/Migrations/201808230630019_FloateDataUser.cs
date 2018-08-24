namespace Health_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FloateDataUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserDatas", "ProteinIntake", c => c.Single(nullable: false));
            AlterColumn("dbo.UserDatas", "CarbonIntake", c => c.Single(nullable: false));
            AlterColumn("dbo.UserDatas", "FatIntake", c => c.Single(nullable: false));
            AlterColumn("dbo.UserDatas", "CalorieIntake", c => c.Single(nullable: false));
            AlterColumn("dbo.UserDatas", "CalorieComsumption", c => c.Single(nullable: false));
            AlterColumn("dbo.UserDatas", "Distance", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserDatas", "Distance", c => c.Short(nullable: false));
            AlterColumn("dbo.UserDatas", "CalorieComsumption", c => c.Int(nullable: false));
            AlterColumn("dbo.UserDatas", "CalorieIntake", c => c.Int(nullable: false));
            AlterColumn("dbo.UserDatas", "FatIntake", c => c.Int(nullable: false));
            AlterColumn("dbo.UserDatas", "CarbonIntake", c => c.Int(nullable: false));
            AlterColumn("dbo.UserDatas", "ProteinIntake", c => c.Int(nullable: false));
        }
    }
}
