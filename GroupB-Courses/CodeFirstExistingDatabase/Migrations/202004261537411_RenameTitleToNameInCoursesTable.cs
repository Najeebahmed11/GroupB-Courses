namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleToNameInCoursesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cours", "Name", c => c.String(nullable:false));
            Sql("UPDATE Cours SET Name=Title");
            DropColumn("dbo.Cours", "Title");
         
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cours", "Title", c => c.String(nullable:false));
            Sql("UPDATE Cours SET Title=Name");
            DropColumn("dbo.Cours", "Name");
        }
    }
}
