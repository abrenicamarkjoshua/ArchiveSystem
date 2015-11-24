namespace ArchiveSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedForeignKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Documents", "StudentID", "dbo.Students");
            DropIndex("dbo.Classes", new[] { "Course_ID1" });
            DropIndex("dbo.Classes", new[] { "Program_ID1" });
            DropIndex("dbo.Professors", new[] { "Account_ID1" });
            DropIndex("dbo.Sections", new[] { "Class_ID1" });
            DropIndex("dbo.Groups", new[] { "Section_ID1" });
            DropIndex("dbo.Documents", new[] { "StudentID" });
            DropIndex("dbo.Documents", new[] { "SoftCat_ID1" });
            DropColumn("dbo.Classes", "Course_ID");
            DropColumn("dbo.Classes", "Program_ID");
            DropColumn("dbo.Professors", "Account_ID");
            DropColumn("dbo.Sections", "Class_ID");
            DropColumn("dbo.Groups", "Section_ID");
            DropColumn("dbo.Documents", "SoftCat_ID");
            RenameColumn(table: "dbo.Classes", name: "Course_ID1", newName: "Course_ID");
            RenameColumn(table: "dbo.Classes", name: "Program_ID1", newName: "Program_ID");
            RenameColumn(table: "dbo.Sections", name: "Class_ID1", newName: "Class_ID");
            RenameColumn(table: "dbo.Professors", name: "Account_ID1", newName: "Account_ID");
            RenameColumn(table: "dbo.Groups", name: "Section_ID1", newName: "Section_ID");
            RenameColumn(table: "dbo.Documents", name: "SoftCat_ID1", newName: "SoftCat_ID");
            RenameColumn(table: "dbo.Documents", name: "StudentID", newName: "student_ID");
            AlterColumn("dbo.Classes", "Course_ID", c => c.Int());
            AlterColumn("dbo.Classes", "Program_ID", c => c.Int());
            AlterColumn("dbo.Professors", "Account_ID", c => c.Int());
            AlterColumn("dbo.Sections", "Class_ID", c => c.Int());
            AlterColumn("dbo.Groups", "Section_ID", c => c.Int());
            AlterColumn("dbo.Documents", "student_ID", c => c.Int());
            AlterColumn("dbo.Documents", "SoftCat_ID", c => c.Int());
            CreateIndex("dbo.Classes", "Course_ID");
            CreateIndex("dbo.Classes", "Program_ID");
            CreateIndex("dbo.Professors", "Account_ID");
            CreateIndex("dbo.Sections", "Class_ID");
            CreateIndex("dbo.Groups", "Section_ID");
            CreateIndex("dbo.Documents", "SoftCat_ID");
            CreateIndex("dbo.Documents", "student_ID");
            AddForeignKey("dbo.Documents", "student_ID", "dbo.Students", "ID");
            DropColumn("dbo.Professors", "Class_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Professors", "Class_ID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Documents", "student_ID", "dbo.Students");
            DropIndex("dbo.Documents", new[] { "student_ID" });
            DropIndex("dbo.Documents", new[] { "SoftCat_ID" });
            DropIndex("dbo.Groups", new[] { "Section_ID" });
            DropIndex("dbo.Sections", new[] { "Class_ID" });
            DropIndex("dbo.Professors", new[] { "Account_ID" });
            DropIndex("dbo.Classes", new[] { "Program_ID" });
            DropIndex("dbo.Classes", new[] { "Course_ID" });
            AlterColumn("dbo.Documents", "SoftCat_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Documents", "student_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Groups", "Section_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Sections", "Class_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Professors", "Account_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Classes", "Program_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Classes", "Course_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Documents", name: "student_ID", newName: "StudentID");
            RenameColumn(table: "dbo.Documents", name: "SoftCat_ID", newName: "SoftCat_ID1");
            RenameColumn(table: "dbo.Groups", name: "Section_ID", newName: "Section_ID1");
            RenameColumn(table: "dbo.Professors", name: "Account_ID", newName: "Account_ID1");
            RenameColumn(table: "dbo.Sections", name: "Class_ID", newName: "Class_ID1");
            RenameColumn(table: "dbo.Classes", name: "Program_ID", newName: "Program_ID1");
            RenameColumn(table: "dbo.Classes", name: "Course_ID", newName: "Course_ID1");
            AddColumn("dbo.Documents", "SoftCat_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Groups", "Section_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Sections", "Class_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Professors", "Account_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "Program_ID", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "Course_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Documents", "SoftCat_ID1");
            CreateIndex("dbo.Documents", "StudentID");
            CreateIndex("dbo.Groups", "Section_ID1");
            CreateIndex("dbo.Sections", "Class_ID1");
            CreateIndex("dbo.Professors", "Account_ID1");
            CreateIndex("dbo.Classes", "Program_ID1");
            CreateIndex("dbo.Classes", "Course_ID1");
            AddForeignKey("dbo.Documents", "StudentID", "dbo.Students", "ID", cascadeDelete: true);
        }
    }
}
