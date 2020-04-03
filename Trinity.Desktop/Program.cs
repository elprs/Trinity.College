using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Trinity.Entities;
using Trinity.Database;
using System.Globalization;
using Trinity.Services;

namespace Trinity.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {

            //Τεστιng Repository 
            CourseRepository cr = new CourseRepository();
            CourseStudentRepository csr = new CourseStudentRepository();
            StudentRepository s = new StudentRepository();
           TeacherRepository tr = new TeacherRepository();
            SubjectRepository sur = new SubjectRepository();
            AssignmentRepository ar = new AssignmentRepository();
            MarkRepository mr = new MarkRepository();
           

           var lista =  cr.GetAll();
            foreach (var item in lista)
            {
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Subjects.Count);

                foreach (var subject in item.Subjects)
                {
                    Console.WriteLine(subject.Title);
                    Console.WriteLine(subject.Teachers.Count);
                }
            }
            foreach (var item in csr.GetAll())
            {
                Console.WriteLine(item.CourseId);
            }
            foreach (var item in s.GetAll())
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.CourseStudents.Count);

                
            }

            cr.Dispose();


            Console.WriteLine("-------------------------------------------------");


            //Testing requirements 
            Console.OutputEncoding = Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("gr-GR");
            using (MyDatabase db = new MyDatabase())
            {
                foreach (var course in db.Courses.ToList())
                {


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0, 20} : {1, -20}", "Course title", course.Title);
                    Console.WriteLine("{0, 20} : {1:D}", "Course start date", course.StartDate);
                    Console.WriteLine("{0, 20} : {1, -20:C0}", "Course fee", course.Fee);
                    Console.WriteLine("{0, 20} : {1, -20}", "Course description", course.Description);
                    Console.WriteLine("{0, 20} : {1, -20}", "Course type", course.Type);
                    Console.WriteLine();



                    foreach (var subject in course.Subjects)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Subject: " + subject.Title);

                        foreach (var teacher in subject.Teachers)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\tTeacher : " + teacher.FirstName + " " + teacher.LastName);
                        }

                        foreach (var assignment in subject.Assignments)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(" {0, 40} {1}", "Assignment title : ", assignment.Title);
                            foreach (var mark in assignment.Marks)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(" {0, 40} {1} {2}", "Student : ", mark.Student.FirstName, mark.Student.LastName);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(" {0, 40} {1}", "Mark : ", mark.AssignmentMark);
                                Console.ForegroundColor = ConsoleColor.White;

                            }

                        }
                    }

                    Console.WriteLine("``````````````````````````````````````````````````````````````````````````````````````````");
                }
            }

            Console.ReadKey();

          
        }
    }
}
