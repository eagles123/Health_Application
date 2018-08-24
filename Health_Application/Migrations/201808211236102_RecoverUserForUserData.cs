namespace Health_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecoverUserForUserData : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserDatas", name: "ApplicationUser_Id", newName: "User_Id");
            RenameIndex(table: "dbo.UserDatas", name: "IX_ApplicationUser_Id", newName: "IX_User_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserDatas", name: "IX_User_Id", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.UserDatas", name: "User_Id", newName: "ApplicationUser_Id");
        }
    }
}
