namespace Health_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUserData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5337eb88-a45e-4e22-b2bc-306dd8c7500f', N'abc@gmail.com', 0, N'AMQCYXNEvZS8a061qPGyu67Qq/WjloLNArEjyoiWKj1dpQGC8W4nKYOmvPAXHmaDlA==', N'd327d230-be09-4945-9f7b-d4899c4c9824', NULL, 0, 0, NULL, 1, 0, N'abc@gmail.com')
SET IDENTITY_INSERT [dbo].[UserDatas] ON
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (1, N'2018-08-23 00:00:00', 230, 300, 130, 3020, 2200, 3.2, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (2, N'2018-08-24 00:00:00', 130, 320, 140, 3020, 2300, 4.1, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (3, N'2018-08-25 00:00:00', 233, 330, 150, 3020, 1000, 5.1, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (4, N'2018-08-26 00:00:00', 210, 230, 120, 3020, 3000, 4.8, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (5, N'2018-08-27 00:00:00', 220, 390, 110, 3020, 2400, 3.5, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (6, N'2018-08-28 00:00:00', 100, 380, 90, 3020, 2400, 5.0, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (7, N'2018-08-29 00:00:00', 330, 220, 80, 3020, 2600, 6.1, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (8, N'2018-08-30 00:00:00', 244, 130, 70, 3020, 2700, 4.7, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (9, N'2018-08-31 00:00:00', 430, 210, 40, 3020, 2900, 3.3, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (10, N'2018-09-01 00:00:00', 230, 350, 80, 3020, 2200, 5.5, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (11, N'2018-09-02 00:00:00', 130, 360, 55, 3020, 2300, 6.3, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (12, N'2018-09-03 00:00:00', 330, 320, 66, 3020, 2300, 3.8, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (13, N'2018-09-04 00:00:00', 100, 390, 76, 3020, 2300, 2.7, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (14, N'2018-09-05 00:00:00', 80, 370, 34, 3020, 1900, 3.4, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (15, N'2018-09-06 00:00:00', 120, 200, 65, 3020, 1800, 5.5, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (16, N'2018-09-07 00:00:00', 210, 200, 89, 3020, 2300, 3.6, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
INSERT INTO [dbo].[UserDatas] ([Id], [Date], [ProteinIntake], [CarbonIntake], [FatIntake], [CalorieIntake], [CalorieComsumption], [Distance], [User_Id]) VALUES (17, N'2018-09-08 00:00:00', 214, 203, 99, 2920, 2300, 3.7, N'5337eb88-a45e-4e22-b2bc-306dd8c7500f')
SET IDENTITY_INSERT [dbo].[UserDatas] OFF
");
        }
        
        public override void Down()
        {
        }
    }
}
