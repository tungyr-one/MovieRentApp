namespace MovieRentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5d1c5f8a-16ff-49c0-945a-e966ac77e172', N'guest@movierent.com', 0, N'APuhsLLgLGXKNPu7+WKJ2mN+IXzLyHw5UGbU5LUMw4pWT2A9rDRqtglPKpIyibcX+A==', N'365cb9d0-d9e8-4662-8b34-9f045a483086', NULL, 0, 0, NULL, 1, 0, N'guest@movierent.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'86777828-51d5-4810-9878-9586a5525a84', N'admin@movierent.ru', 0, N'AGFpFLVuRE5jCX+mWeuGwh/Sf/jf/7gNvg4VFKVmx3GSFX1M+2ePGLiBxadFNFB9yw==', N'6d1eefa6-5486-4c1f-a8e7-5c05271e444c', NULL, 0, 0, NULL, 1, 0, N'admin@movierent.ru')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9ba6c7a8-56d4-429b-95f9-332daed86dbe', N'CanManageMovies')
            INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'86777828-51d5-4810-9878-9586a5525a84', N'9ba6c7a8-56d4-429b-95f9-332daed86dbe')

");
        }
        
        public override void Down()
        {
        }
    }
}
