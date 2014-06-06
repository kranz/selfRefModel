namespace self01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewNavigationInLocation : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("dbo.Location", "topLocationID", "dbo.Location", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Location", "topLocationID", "dbo.Location");
        }
    }
}
