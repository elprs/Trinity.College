using System.Collections.Generic;
using System.Linq;
using Trinity.Entities;
using Trinity.Services;

namespace Trinity.Web.Models
{
    public class AllEntities
    {
        public IEnumerable<Subject> Subjects { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<CourseStudent> CourseStudents { get; set; }
        public IEnumerable<Mark> Marks { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Assignment> Assignments { get; set; }

        public AllEntities()
        {
            SubjectRepository subjectRepository = new SubjectRepository();
            CourseRepository courseRepository = new CourseRepository();
            StudentRepository studentRepository = new StudentRepository();
            MarkRepository markRepository = new MarkRepository();
            TeacherRepository teacherRepository = new TeacherRepository();
            CourseStudentRepository courseStudentRepository = new CourseStudentRepository();
            AssignmentRepository assignmentRepository = new AssignmentRepository();

            Subjects = subjectRepository.GetAll();
            Courses = courseRepository.GetAll();
            Students = studentRepository.GetAll();
            Teachers = teacherRepository.GetAll();
            CourseStudents = courseStudentRepository.GetAll();
            Marks = markRepository.GetAll();
            Assignments = assignmentRepository.GetAll();
           
        }

    }
}