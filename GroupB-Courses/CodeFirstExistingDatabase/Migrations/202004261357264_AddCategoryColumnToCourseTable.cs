namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryColumnToCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cours", "Category_Id", c => c.Int());
            CreateIndex("dbo.Cours", "Category_Id");
            AddForeignKey("dbo.Cours", "Category_Id", "dbo.Categories", "Id");
            Sql("UPDATE Cours SET Category_Id = 1");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cours", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Cours", new[] { "Category_Id" });
            DropColumn("dbo.Cours", "Category_Id");
        }
    }
}
