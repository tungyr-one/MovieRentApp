namespace MovieRentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCustomerAdmin : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES(N'263cb27c-4d68-46ad-b6f0-0ad78ad350c5', N'adminTwo@movierent.ru', 0, N'AF5Iv1V6BuxOE4uEAqbar/EuBuTbZI+0g73AGc3EiVyGDHqFx7KMBNCmYZuClcmEAQ==', N'da505681-1cfc-4012-bbe1-e83cf8483d24', N'+74185296358', 0, 0, NULL, 1, 0, N'adminTwo@movierent.ru', N'097831485')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ea55594d-16ee-4993-92c8-ee911142b528', N'CanManageCustomers')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'263cb27c-4d68-46ad-b6f0-0ad78ad350c5', N'ea55594d-16ee-4993-92c8-ee911142b528')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
