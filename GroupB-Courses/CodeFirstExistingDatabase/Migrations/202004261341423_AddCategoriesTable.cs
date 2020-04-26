namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO CATEGORIES VALUES (1,'WEB DEVEOLOPMENT')");
            Sql("INSERT INTO CATEGORIES VALUES (2,'WEB ')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
