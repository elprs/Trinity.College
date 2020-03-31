namespace Trinity.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        AssignmentId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        SubDate = c.DateTime(nullable: false),
                        Subject_SubjectId = c.Int(),
                    })
                .PrimaryKey(t => t.AssignmentId)
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectId)
                .Index(t => t.Subject_SubjectId);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        MarkId = c.Int(nullable: false, identity: true),
                        UniqueCode = c.Double(nullable: false),
                        AssignmentMark = c.Double(nullable: false),
                        OralMark = c.Double(nullable: false),
                        StudentId = c.Int(nullable: false),
                        AssignmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MarkId)
                .ForeignKey("dbo.Assignments", t => t.AssignmentId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.AssignmentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Telephone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhotoURL = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.CourseStudents",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        IsFeePayed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.StudentId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        Type = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 50),
                        PhotoURL = c.String(),
                        Fee = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        PhotoURL = c.String(),
                        Course_CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .Index(t => t.Course_CourseId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Telephone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Salary = c.Double(nullable: false),
                        VideoURL = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            CreateTable(
                "dbo.TeacherSubjects",
                c => new
                    {
                        Teacher_TeacherId = c.Int(nullable: false),
                        Subject_SubjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_TeacherId, t.Subject_SubjectId })
                .ForeignKey("dbo.Teachers", t => t.Teacher_TeacherId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectId, cascadeDelete: true)
                .Index(t => t.Teacher_TeacherId)
                .Index(t => t.Subject_SubjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Marks", "StudentId", "dbo.Students");
            DropForeignKey("dbo.CourseStudents", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Subjects", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.TeacherSubjects", "Subject_SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.TeacherSubjects", "Teacher_TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Assignments", "Subject_SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.CourseStudents", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Marks", "AssignmentId", "dbo.Assignments");
            DropIndex("dbo.TeacherSubjects", new[] { "Subject_SubjectId" });
            DropIndex("dbo.TeacherSubjects", new[] { "Teacher_TeacherId" });
            DropIndex("dbo.Subjects", new[] { "Course_CourseId" });
            DropIndex("dbo.CourseStudents", new[] { "StudentId" });
            DropIndex("dbo.CourseStudents", new[] { "CourseId" });
            DropIndex("dbo.Marks", new[] { "AssignmentId" });
            DropIndex("dbo.Marks", new[] { "StudentId" });
            DropIndex("dbo.Assignments", new[] { "Subject_SubjectId" });
            DropTable("dbo.TeacherSubjects");
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Courses");
            DropTable("dbo.CourseStudents");
            DropTable("dbo.Students");
            DropTable("dbo.Marks");
            DropTable("dbo.Assignments");
        }
    }
}
