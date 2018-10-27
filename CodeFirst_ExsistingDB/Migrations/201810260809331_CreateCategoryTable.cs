namespace CodeFirst_ExsistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
  
        }

        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
