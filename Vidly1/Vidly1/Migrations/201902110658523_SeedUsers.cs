namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'563253f9-8e9b-47fd-8413-6bee995dad96', N'guest@vidly.com', 0, N'AItkl2DlHFBySB21C8Xe9E9DP+V09tK/Lc+aj3gS0JVR/SOTsxBDfaUwp5H7qJHBNg==', N'2aec24bd-8183-45fc-b0b2-4c785248a054', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e2f6a6f8-09f1-44e5-87b7-e860eff2160e', N'admin@vidly.com', 0, N'AKX2OG8TAjunlxkQKjm+vPw5/N12vXjz1ihF0MOuWvaDKdY4rzUpKquQULyAhd4oIQ==', N'd337fb6d-d18e-49cd-965b-c27995d10c02', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5b7ebdb4-fead-496a-aafa-4bc70c51caf9', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e2f6a6f8-09f1-44e5-87b7-e860eff2160e', N'5b7ebdb4-fead-496a-aafa-4bc70c51caf9')

");
        }
        
        public override void Down()
        {
        }
    }
}
