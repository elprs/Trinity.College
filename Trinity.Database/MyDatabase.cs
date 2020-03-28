using System.Data.Entity;
using Trinity.Entities;

namespace Trinity.Database
{
    public class MyDatabase : DbContext
    {
        public MyDatabase() : base("Link")
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }
        //public DbSet<Student> Students { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        //public DbSet<Mark> Marks { get; set; }
        //public DbSet<CourseStudent> CourseStudents { get; set; }
        //public DbSet<SubjectTeacher> SubjectTeachers { get; set; }

    }
}
