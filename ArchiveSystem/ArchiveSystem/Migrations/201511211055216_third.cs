namespace ArchiveSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Course_ID = c.Int(nullable: false),
                        Program_ID = c.Int(nullable: false),
                        AcademicYear = c.String(),
                        AcademicTerm = c.String(),
                        Course_ID1 = c.Int(),
                        Program_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.Course_ID1)
                .ForeignKey("dbo.Programs", t => t.Program_ID1)
                .Index(t => t.Course_ID1)
                .Index(t => t.Program_ID1);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Professors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Account_ID = c.Int(nullable: false),
                        Class_ID = c.Int(nullable: false),
                        Account_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.Account_ID1)
                .Index(t => t.Account_ID1);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProgramName = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        section = c.String(),
                        Class_ID = c.Int(nullable: false),
                        Class_ID1 = c.Int(),
                        Student_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classes", t => t.Class_ID1)
                .ForeignKey("dbo.Students", t => t.Student_ID)
                .Index(t => t.Class_ID1)
                .Index(t => t.Student_ID);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroupName = c.String(nullable: false, maxLength: 250),
                        Section_ID = c.Int(nullable: false),
                        Student_ID = c.Int(),
                        Section_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.Student_ID)
                .ForeignKey("dbo.Sections", t => t.Section_ID1)
                .Index(t => t.Student_ID)
                .Index(t => t.Section_ID1);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Filename = c.String(nullable: false, maxLength: 250),
                        Title = c.String(nullable: false, maxLength: 300),
                        Author = c.String(nullable: false, maxLength: 250),
                        YearPublished = c.Int(nullable: false),
                        DateUploaded = c.DateTime(nullable: false),
                        StudentID = c.Int(nullable: false),
                        Status = c.String(nullable: false, maxLength: 10),
                        DateUpdated = c.DateTime(),
                        Remarks = c.String(maxLength: 500),
                        SoftCat_ID = c.Int(nullable: false),
                        SoftCat_ID1 = c.Int(),
                        Group_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SoftCats", t => t.SoftCat_ID1)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.Group_ID)
                .Index(t => t.StudentID)
                .Index(t => t.SoftCat_ID1)
                .Index(t => t.Group_ID);
            
            CreateTable(
                "dbo.SoftCats",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        softCat = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Account_ID = c.Int(nullable: false),
                        Class_ID = c.Int(nullable: false),
                        Account_ID1 = c.Int(),
                        Class_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.Account_ID1)
                .ForeignKey("dbo.Classes", t => t.Class_ID1)
                .Index(t => t.Account_ID1)
                .Index(t => t.Class_ID1);
            
            CreateTable(
                "dbo.ProfessorClasses",
                c => new
                    {
                        Professor_ID = c.Int(nullable: false),
                        Class_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Professor_ID, t.Class_ID })
                .ForeignKey("dbo.Professors", t => t.Professor_ID, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Class_ID, cascadeDelete: true)
                .Index(t => t.Professor_ID)
                .Index(t => t.Class_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Class_ID1", "dbo.Classes");
            DropForeignKey("dbo.Groups", "Section_ID1", "dbo.Sections");
            DropForeignKey("dbo.Documents", "Group_ID", "dbo.Groups");
            DropForeignKey("dbo.Sections", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.Groups", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.Documents", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Students", "Account_ID1", "dbo.Accounts");
            DropForeignKey("dbo.Documents", "SoftCat_ID1", "dbo.SoftCats");
            DropForeignKey("dbo.Sections", "Class_ID1", "dbo.Classes");
            DropForeignKey("dbo.Classes", "Program_ID1", "dbo.Programs");
            DropForeignKey("dbo.ProfessorClasses", "Class_ID", "dbo.Classes");
            DropForeignKey("dbo.ProfessorClasses", "Professor_ID", "dbo.Professors");
            DropForeignKey("dbo.Professors", "Account_ID1", "dbo.Accounts");
            DropForeignKey("dbo.Classes", "Course_ID1", "dbo.Courses");
            DropIndex("dbo.ProfessorClasses", new[] { "Class_ID" });
            DropIndex("dbo.ProfessorClasses", new[] { "Professor_ID" });
            DropIndex("dbo.Students", new[] { "Class_ID1" });
            DropIndex("dbo.Students", new[] { "Account_ID1" });
            DropIndex("dbo.Documents", new[] { "Group_ID" });
            DropIndex("dbo.Documents", new[] { "SoftCat_ID1" });
            DropIndex("dbo.Documents", new[] { "StudentID" });
            DropIndex("dbo.Groups", new[] { "Section_ID1" });
            DropIndex("dbo.Groups", new[] { "Student_ID" });
            DropIndex("dbo.Sections", new[] { "Student_ID" });
            DropIndex("dbo.Sections", new[] { "Class_ID1" });
            DropIndex("dbo.Professors", new[] { "Account_ID1" });
            DropIndex("dbo.Classes", new[] { "Program_ID1" });
            DropIndex("dbo.Classes", new[] { "Course_ID1" });
            DropTable("dbo.ProfessorClasses");
            DropTable("dbo.Students");
            DropTable("dbo.SoftCats");
            DropTable("dbo.Documents");
            DropTable("dbo.Groups");
            DropTable("dbo.Sections");
            DropTable("dbo.Programs");
            DropTable("dbo.Professors");
            DropTable("dbo.Courses");
            DropTable("dbo.Classes");
        }
    }
}
