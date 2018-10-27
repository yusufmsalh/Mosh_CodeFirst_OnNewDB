namespace CodeFirst_ExsistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDatePublishedColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "DataPublished", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "DataPublished");
        }
    }
}
