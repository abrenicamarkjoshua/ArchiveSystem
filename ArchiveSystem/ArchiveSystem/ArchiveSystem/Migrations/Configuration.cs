namespace ArchiveSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ArchiveSystem.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ArchiveSystem.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            try
            {
                context.AccountRoles.AddOrUpdate(
                    p => p.role,
                    new Models.Role { role = "professor" },
                    new Models.Role { role = "student"}
                    );
                var programCS = new Models.Program { ProgramName = "CS" };
                var programIS = new Models.Program { ProgramName = "IS" };
                var programIT = new Models.Program { ProgramName = "IT" };
                context.Program.AddOrUpdate(
                    p => p.ProgramName,
                    programCS,
                    programIS,
                    programIT    
                );
                var courseSE1 = new Models.Course { CourseName = "Software Engineering 1" };
                var courseSE2 = new Models.Course { CourseName = "Software Engineering @" };
                context.Course.AddOrUpdate(
                    c => c.CourseName,
                    courseSE1,
                    courseSE2
                );
                var sem1st = "1st SEMESTER";
                var sem2nd = "2nd SEMESTER";
                var academicYear = "2015-2016";
                var ClassCS = new Models.Class()
                {
                     AcademicTerm = sem1st,
                      Course = courseSE1,
                       Program = programCS,
                        AcademicYear = academicYear
                          
                             
                };
                var sectionA = new Models.Section { section = "A", Class = ClassCS};
                var sectionB = new Models.Section { section = "B", Class = ClassCS };
                var sectionC = new Models.Section { section = "C", Class = ClassCS};

                context.Section.AddOrUpdate(
                   p => p.section,
                   sectionA, sectionB, sectionC
                );
                context.SoftCat.AddOrUpdate(
                    sc => sc.softCat,
                    new Models.SoftCat { softCat = "Astrology software" },
                    new Models.SoftCat { softCat = "Business software" },
                    new Models.SoftCat { softCat = "Chemical engineering software" },
                    new Models.SoftCat { softCat = "Software for children" },
                    new Models.SoftCat { softCat = "Communication software" },
                    new Models.SoftCat { softCat = "Computer-aided manufacturing software" },
                    new Models.SoftCat { softCat = "Data management software" },
                    new Models.SoftCat { softCat = "Desktop widgets" },
                    new Models.SoftCat { softCat = "Editing software" },
                    new Models.SoftCat { softCat = "Educational software" },
                    new Models.SoftCat { softCat = "Entertainment software" },
                    new Models.SoftCat { softCat = "Government software" },
                    new Models.SoftCat { softCat = "Graphics software" },
                    new Models.SoftCat { softCat = "Industrial software" },
                    new Models.SoftCat { softCat = "Language software" },
                    new Models.SoftCat { softCat = "Legal software" },
                    new Models.SoftCat { softCat = "Library and information science software" },
                    new Models.SoftCat { softCat = "Multimedia software" },
                    new Models.SoftCat { softCat = "Music software" },
                    new Models.SoftCat { softCat = "Religious software" },
                    new Models.SoftCat { softCat = "Science software" },
                    new Models.SoftCat { softCat = "Transport software" },
                    new Models.SoftCat { softCat = "Video games" },
                    new Models.SoftCat { softCat = "Video software" },
                    new Models.SoftCat { softCat = "Word processors" },
                    new Models.SoftCat { softCat = "Workflow software" },
                    new Models.SoftCat { softCat = "Graphical user interfaces" },
                    new Models.SoftCat { softCat = "Middleware" },
                    new Models.SoftCat { softCat = "Operating systems" },
                    new Models.SoftCat { softCat = "Windows systems" },
                    new Models.SoftCat { softCat = "Utility software" }
                );
                var group1 = new Models.Group {Section = sectionA,
                     GroupName = "group1"
                };
                var group2 = new Models.Group
                {
                    
                    Section = sectionA,
                    GroupName = "group2"
                };
                var group3 = new Models.Group
                {
                   
                    Section = sectionA,
                    GroupName = "group3"
                };
                context.Group.AddOrUpdate(
                    g => g.GroupName,
                    group1, group2, group3                     
                );
               

            }
            catch (Exception ex)
            {
                throw new Exception("Error Seeding Privileges: " + ex.InnerException.Message);
            }
        }
    }
}
