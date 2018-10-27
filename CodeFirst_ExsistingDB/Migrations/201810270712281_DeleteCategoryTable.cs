namespace CodeFirst_ExsistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class DeleteCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                        "dbo._Categories",
                        c => new
                        {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            Sql("Insert into _Categories(Name) Select Name from Categories");//Back up data
            DropTable("dbo.Categories");
        }

        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.ID);

            Sql("Insert into Categories(Name) Select Name from _Categories");//Restore up data

            DropTable("dbo._Categories");

        }
    }
}
