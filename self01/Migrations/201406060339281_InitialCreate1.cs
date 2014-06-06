namespace self01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Location", "topLocationID", c => c.Int());
            CreateIndex("dbo.Location", "topLocationID");
            //AddForeignKey("dbo.Location", "topLocationID", "dbo.Location", "id");
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Location", "topLocationID", "dbo.Location");
            DropIndex("dbo.Location", new[] { "topLocationID" });
            DropColumn("dbo.Location", "topLocationID");
        }
    }
}
