namespace MovieRentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreNameDataAnnotationsAndChangeMovieNumberInStockToByte : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
        }
    }
}
