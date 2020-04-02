using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trinity.Entities;
using Trinity.Services;
using Trinity.Web.Models;

namespace Trinity.Web.Controllers
{
    public class StatsController : Controller
    {
        // GET: Stats
        public ActionResult Index()
        {
            StatsViewModel vm = new StatsViewModel();

            CourseRepository cr = new CourseRepository();
            StudentRepository sr = new StudentRepository();
            SubjectRepository sur = new SubjectRepository();
            TeacherRepository tr = new TeacherRepository();
            AssignmentRepository ar = new AssignmentRepository();
            MarkRepository mr = new MarkRepository();
         
            

            var courses = cr.GetAll();
            var students = sr.GetAll();
            var subjects = sur.GetAll();
            var teachers = tr.GetAll();
            var assignments = ar.GetAll();
            var marks = mr.GetAll();
            
            vm.CoursesCount = courses.Count();
            vm.StudentsCount = students.Count();
            vm.SubjectsCount = subjects.Count();
            vm.TeachersCount = teachers.Count();
            vm.AssignmentsCount = assignments.Count();
            vm.MarksCount = marks.Count();


          








            //foreach (var course in courses)
            //{

            //    vm.StudentsCountPerSubject = course.CourseStudents.Count();// Εφοσον στην παραδοχη μου καθε subject προερχετα απο 1 course, o αριθμος των μαθητων ανα course συνεπαγεται τον αριθμο των μαθητων ανα subject. 
            //}

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

            return View(vm);
        }
    }
}