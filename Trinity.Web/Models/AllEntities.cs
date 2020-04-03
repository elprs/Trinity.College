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

        //  Unfruitfull attemts ---  Learning Area  ( to be continued ) ... ===================================================
        public IEnumerable<IGrouping<ICollection<CourseStudent>, Course>> StudentsPerCourse { get; set; }
        public double StudentsAverageMarkPerSubject { get; set; }
        public double StudentsAverageMarkPerAssignment { get; set; }
        public double StudentsAverageMarkPerAssignmentPerCourse { get; set; }



        //ΓIA TON CONTROLLER KAI TO VIEW ( to be continued ) 
        //Unfruitfull attemts ---  Learning Area
        #region ====== no luck ========================
        //vm.StudentsPerCourse = from course in students
        //             group course by course.CourseStudents into y
        //             select y;

        //vm.StudentsPerCourse = from course in courseStudents.Select(x=>x.Student)
        //                       group course by courseStudents into y
        //                       select y;



        //var result = from actor in actors
        //             group actor by actor.Country into y
        //             select y;
        //IEnumerable<IGrouping<Country, Actor>>
        // eg.
        //x1 ====================>  Australia(key) ---- new List<Actors>()(a1, a78);
        // ... x1 krataei ena zeugaraki
        // List<Key, lista> y 
        //y.add(x1) etc
        //     epestrepse mas ti lista y meta zeygarakia





        //foreach (var student in courseStudents.Select(x=>x.Student))
        //{
        //    vm.StudentsPerCourse.ToList().Add(student);

        //                string name =  student.FirstName;
        //    int number = student.CourseStudents.Count();// Ε

        //foreach (var course in courses)
        //{


        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("{0, 20} : {1, -20}", "Course title", course.Title);
        //    Console.WriteLine("{0, 20} : {1:D}", "Course start date", course.StartDate);
        //    Console.WriteLine("{0, 20} : {1, -20:C0}", "Course fee", course.Fee);
        //    Console.WriteLine("{0, 20} : {1, -20}", "Course description", course.Description);
        //    Console.WriteLine("{0, 20} : {1, -20}", "Course type", course.Type);
        //    Console.WriteLine();



        //    foreach (var subject in course.Subjects)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine("Subject: " + subject.Title);

        //        foreach (var teacher in subject.Teachers)
        //        {
        //            Console.ForegroundColor = ConsoleColor.White;
        //            Console.WriteLine("\tTeacher : " + teacher.FirstName + " " + teacher.LastName);
        //        }

        //        foreach (var assignment in subject.Assignments)
        //        {
        //            Console.ForegroundColor = ConsoleColor.DarkGreen;
        //            Console.WriteLine(" {0, 40} {1}", "Assignment title : ", assignment.Title);
        //            foreach (var mark in assignment.Marks)
        //            {
        //                Console.ForegroundColor = ConsoleColor.DarkYellow;
        //                Console.WriteLine(" {0, 40} {1} {2}", "Student : ", mark.Student.FirstName, mark.Student.LastName);
        //                Console.ForegroundColor = ConsoleColor.White;
        //                Console.WriteLine(" {0, 40} {1}", "Mark : ", mark.AssignmentMark);
        //                Console.ForegroundColor = ConsoleColor.White;

        //            }

        //        }
        //    }

        //    Console.WriteLine("``````````````````````````````````````````````````````````````````````````````````````````");
        //}







        //<!-- #region name Unfruitfull attemts ---  Learning Area ============================================-->
        //@*<div>
        //        @foreach(var Student in Model.StudentsPerCourse)
        //        {
        //            < tr >

        //                < td > @Html.ActionLink((string.Format("{0} ", Student.Key), "SimpleDetails", "Student", new { id = Student.StudentId }, null) </ td >


        //                < td >< button >< a href = "/Student/SimpleDetails/@Student" > Details </ button ></ td >

        //            </ tr >
        //        }
        //    </div>*@



        //<!-- #endregion -->

        #endregion

    }
}