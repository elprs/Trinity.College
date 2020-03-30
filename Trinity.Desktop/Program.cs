using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Trinity.Entities;
using Trinity.Database;

namespace Trinity.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {



            MyDatabase db = new MyDatabase();
            foreach (var course in db.Courses.ToList())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Course : " + course.Title);
                

                foreach (var subject in course.Subjects)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\tSubject: " + subject.Title);

                    foreach (var teacher in subject.Teachers)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t\tTeacher : " + teacher.FirstName + " " + teacher.LastName);
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
                            Console.WriteLine(" {0, 40} {1}", "Assignment mark : ", mark.AssignmentMark);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
            }

            Console.ReadKey();

            //using (MyDatabase db = new MyDatabase())
            //{
            //    var subjects = db.Subjects.Include(x => x.Assignment);

            //    foreach (var subject in subjects)
            //    {
            //        Console.WriteLine(subject.Title);
            //        Console.Write("\t");
            //        Console.WriteLine(subject.Assignment.Title);
            //        Console.WriteLine("\n==========");
            //    }
            //}

            //using (MyDatabase db = new MyDatabase())
            //{
            //    var assignments = db.Assignments.Include(x => x.Subject);

            //    foreach (var assignment in assignments)
            //    {
            //        Console.WriteLine(assignment.Title);
            //        Console.Write("\t");
            //        Console.WriteLine(assignment.Subject.Title);
            //        Console.WriteLine("\n==========");
            //    }
            //}




            Console.ReadKey();
        }
    }
}
