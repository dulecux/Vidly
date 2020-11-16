namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'129b1265-81a1-4360-bda1-5df8fbb75712', N'admin@vidly.com', 0, N'ANgMS5Le6QuYpZfjSw5k0QIJGMx4qLy/PUlZEVlN+NsfB6AdWJ7mTrz/8mfogsbGiQ==', N'cc103719-a6c4-4319-abc2-8bf69a002cb0', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'97ccf062-c0b9-41ce-8a93-bb4bb48dd661', N'guest@vidly.com', 0, N'AI+MgnCgE5BGFza7U3HfLMYh0mkAqjuydUvUp65hUJqperro7s7lm4zyrWGOViXV1w==', N'cab9e92c-c31a-4cc9-9fb4-a5ec533db808', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cdf0a1ee-356e-4333-a3fd-d4505dd4e813', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'129b1265-81a1-4360-bda1-5df8fbb75712', N'cdf0a1ee-356e-4333-a3fd-d4505dd4e813')
");
        }
        
        public override void Down()
        {
        }
    }
}
