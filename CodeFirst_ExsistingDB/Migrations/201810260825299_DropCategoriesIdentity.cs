namespace CodeFirst_ExsistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropCategoriesIdentity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Categories","ID",null);
            Sql("Insert into Categories Values (1,'C# Begginer')");
            Sql("Insert into Categories Values (2,'C# intermediate')");
        }
        
        public override void Down()
        {
        }
    }
}
