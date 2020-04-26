namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteCategryColumnFromCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cours", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Cours", new[] { "Category_Id" });
            DropColumn("dbo.Cours", "Category_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cours", "Category_Id", c => c.Int());
            CreateIndex("dbo.Cours", "Category_Id");
            AddForeignKey("dbo.Cours", "Category_Id", "dbo.Categories", "Id");
        }
    }
}
