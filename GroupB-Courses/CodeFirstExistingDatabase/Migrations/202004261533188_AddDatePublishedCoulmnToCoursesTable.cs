namespace CodeFirstExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatePublishedCoulmnToCoursesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cours", "DatePublished", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cours", "DatePublished");
        }
    }
}
