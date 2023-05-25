namespace MovieRentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You go' WHERE ID = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE ID = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' WHERE ID = 3");
            Sql("UPDATE MembershipTypes SET Name = 'For real nuvorishes' WHERE ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}
