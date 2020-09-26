namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6c58e699-879c-46fc-a683-8eb1ebdffd6e', N'admin@gmail.com', 0, N'AOMipxeRELYfXsP120JXs/1moDoLJBtmuOlYw/Sl5IbGkHkDa/GAaHJ1YZLX74/vRg==', N'098cb06c-7dff-4105-91ab-9bbb6c71736b', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ffa089f6-d0ff-4048-a96f-d007765f1160', N'guest@gmail.com', 0, N'AMqixQ/TA0gtOk5CRAMidYT/PZzjcWCBJ0LDeVwcepgcYgMEMEubPV5vThoqRd09Og==', N'c2a64cf8-904a-4144-b082-77c87554f086', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1f7dd8b6-b27f-42a9-b1c5-c5d9e0851f50', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6c58e699-879c-46fc-a683-8eb1ebdffd6e', N'1f7dd8b6-b27f-42a9-b1c5-c5d9e0851f50')
");
        }
        
        public override void Down()
        {
        }
    }
}
