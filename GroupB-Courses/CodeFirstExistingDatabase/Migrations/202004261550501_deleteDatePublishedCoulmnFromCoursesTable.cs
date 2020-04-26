namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteDatePublishedCoulmnFromCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cours", "DatePublished");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cours", "DatePublished", c => c.DateTime());
        }
    }
}
