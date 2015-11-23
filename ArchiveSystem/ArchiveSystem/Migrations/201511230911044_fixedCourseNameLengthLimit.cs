namespace ArchiveSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedCourseNameLengthLimit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "CourseName", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "CourseName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
