namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        AuthorID = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Price = c.Short(nullable: false),
                        LevelString = c.String(),
                        Level = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .Index(t => t.AuthorID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TagID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cours", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Cours", new[] { "AuthorID" });
            DropTable("dbo.Tags");
            DropTable("dbo.Cours");
            DropTable("dbo.Authors");
        }
    }
}
