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


            //===================Testing requirements ==============================================================
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
                            double sumStudentAssignmentMark = 0;
                            double sumOfTotalMarksofAllAstudensperSubject = 0;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(" {0, 40} {1}", "Assignment title : ", assignment.Title);
                            foreach (var mark in assignment.Marks)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(" {0, 40} {1} {2}", "Student : ", mark.Student.FirstName, mark.Student.LastName);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(" {0, 40} {1}", "Assignement Mark : ", mark.AssignmentMark);
                                Console.WriteLine(" {0, 40} {1}", "Total Mark : ", mark.TotalMark);
                                sumStudentAssignmentMark += mark.AssignmentMark;
                                sumOfTotalMarksofAllAstudensperSubject += mark.TotalMark;
                                Console.ForegroundColor = ConsoleColor.White;
                                
                            }

                            //=========testing Average of all students per Subject(=per Assignment) =====================================
                            Console.WriteLine("================ AVERAGE of all students per Subject - Assignment =========================="); 
                            Console.WriteLine(" {0, 40} {1}", "Sum of Assignment Marks : ", sumStudentAssignmentMark);
                            Console.WriteLine(" {0, 40} {1}", "Sum of Total Marks : ", sumOfTotalMarksofAllAstudensperSubject);
                            Console.WriteLine(" {0, 40} {1}", "Count of Assignments marked : ", assignment.Marks.Count());
                            double avg = sumOfTotalMarksofAllAstudensperSubject / assignment.Marks.Count();
                            double avgAssignment = sumStudentAssignmentMark / assignment.Marks.Count();
                            Console.WriteLine(" {0, 40} {1}", "Average of assignment Marks : ", avgAssignment);
                            Console.WriteLine(" {0, 40} {1}", "Average of Total Marks : ", avg);
                            Console.WriteLine();
                            Console.WriteLine("=======================================================================");
                            Console.WriteLine("=======================================================================");
                            Console.WriteLine("=======================================================================");
                            Console.WriteLine("=======================================================================");
                            Console.WriteLine();


                        }

                        //=======testing Average per student per course==================================================
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        Console.WriteLine("***************************************************************************");
                        Console.WriteLine("******************** Average Mark per Student per Course ******************" );
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("{0, 20} : {1, -20}", "Course title =========================================>  ", course.Title);
                        
                        foreach (var courseStudent in course.CourseStudents)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine();
                            Console.WriteLine(" {0, 40} {1} {2}", "Student : ", courseStudent.Student.FirstName, courseStudent.Student.LastName);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            double sumStudentTotalMark = 0;
                            double sumStudentAssignmentMark = 0;
                            foreach (var mark in courseStudent.Student.Marks)
                            {
                                Console.WriteLine("{0, 20} : {1, -20}", "Total Mark per subject ", mark.TotalMark);
                                Console.WriteLine("{0, 60} : {1, -20}", "Total Mark per assignment ", mark.AssignmentMark);
                                
                                sumStudentTotalMark += mark.TotalMark;
                                sumStudentAssignmentMark += mark.AssignmentMark;
                            }
                            Console.WriteLine();
                            Console.WriteLine("================ AVERAGE per student per course ==========================");
                            Console.WriteLine();
                            Console.WriteLine(" {0, 40} {1}", "Sum of Total Assignment Marks : ", sumStudentAssignmentMark);
                            Console.WriteLine(" {0, 40} {1}", "Count of Assignments marked : ", courseStudent.Student.Marks.Count());
                            double avgAssignment = sumStudentAssignmentMark / courseStudent.Student.Marks.Count();
                            Console.WriteLine(" {0, 40} {1}", "Average of student's assignment Marks per course: ", avgAssignment);
                            Console.WriteLine();
                            Console.WriteLine(" {0, 40} {1}", "Sum of Total Marks : ", sumStudentTotalMark);
                            Console.WriteLine(" {0, 40} {1}", "Count of marks : ", courseStudent.Student.Marks.Count());
                            double avg = sumStudentTotalMark / courseStudent.Student.Marks.Count();
                            Console.WriteLine(" {0, 40} {1}", "Average of student's Total Marks per course: ", avg);

                        }
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("***************************************************************************");
                        Console.WriteLine("***************************************************************************");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                        Console.WriteLine("``````````````````````````````````````````````````````````````````````````````````````````");
                }
            }

            Console.ReadKey();

          
        }
    }
}
