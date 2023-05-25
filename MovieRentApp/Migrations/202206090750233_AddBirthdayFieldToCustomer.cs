namespace MovieRentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayFieldToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime(storeType: "date", nullable:true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthday");
        }
    }
}
