namespace CodeFirst_ExsistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCategoryFromCourses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Category_ID", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Category_ID" });
            AddColumn("dbo.Courses", "Name", c => c.String());
            DropColumn("dbo.Courses", "Title");
            DropColumn("dbo.Courses", "Category_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Category_ID", c => c.Int());
            AddColumn("dbo.Courses", "Title", c => c.String());
            DropColumn("dbo.Courses", "Name");
            CreateIndex("dbo.Courses", "Category_ID");
            AddForeignKey("dbo.Courses", "Category_ID", "dbo.Categories", "ID");
        }
    }
}
