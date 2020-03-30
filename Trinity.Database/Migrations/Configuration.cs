namespace Trinity.Database.Migrations
{
    using System.Data.Entity.Migrations;
    using Trinity.Entities;
    using System;
    using Trinity.Entities.CustomValidations;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyDatabase context)
        {
            // Μain Entities Seeding

            
            #region Courses' seeding ==========================
            Course c1 = new Course() { Title = "BootCamp 1", Description = "C#", Type = Entities.Type.Part_Time, StartDate = new DateTime(2019, 11, 11), EndDate = new DateTime(2020, 06, 11), Fee = 900D };
            Course c2 = new Course() { Title = "BootCamp 2", Description = "Java", Type = Entities.Type.Full_Time, StartDate = new DateTime(2019, 11, 11), EndDate = new DateTime(2020, 03, 11), Fee = 900D };
            Course c3 = new Course() { Title = "BootCamp 3", Description = "Python", Type = Entities.Type.Full_Time, StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 06, 1), Fee = 1500D };
            #endregion

            #region Subjects' seeding ==========================
            Subject su1 = new Subject() { Title = "HTML &  C#", PhotoURL = "#", CourseId = 1 };
            Subject su2 = new Subject() { Title = "JS & C#", PhotoURL = "#", CourseId = 1 }; //+
            Subject su4 = new Subject() { Title = "Java Architecture", PhotoURL = "#", CourseId = 2 };
            Subject su5 = new Subject() { Title = "Python Architecture", PhotoURL = "#", CourseId = 3 };

            #endregion

            #region Teachers' seeding ==========================
            Teacher t1 = new Teacher() { LastName = "Gatsos", FirstName = "Hektor", Email = "gatsos@gmail.com", Salary = 50000, Telephone = "1234567891" };
            Teacher t2 = new Teacher() { LastName = "Pasparakis", FirstName = "Giorgos", Email = "Pasparakis@gmail.com", Salary = 90000, Telephone = "1234567892" };
            Teacher t3 = new Teacher() { LastName = "Tzelepidis", FirstName = "Basilis", Email = "Tzelepidis@gmail.com", Salary = 30000, Telephone = "1234567893" };
            Teacher t4 = new Teacher() { LastName = "Panou", FirstName = "Panos", Email = "Panou@gmail.com", Salary = 40000, Telephone = "1234567894" };
            Teacher t5 = new Teacher() { LastName = "Minaidis", FirstName = "Georgios", Email = "Minaidis@gmail.com", Salary = 45000, Telephone = "1234567895" };


            su1.Teachers = new List<Teacher> { t1, t5 };
            su2.Teachers = new List<Teacher> { t1, t5 };
            //                      su3.Teachers = new List<Teacher> { t1, t5 };
            su4.Teachers = new List<Teacher> { t2 };
            su5.Teachers = new List<Teacher> { t3, t4 };

            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~





            #region Students' seeding ==========================
            Student s1 = new Student() { LastName = "Parisi", FirstName = "Eleni", Email = "parisi@gmail.com", Telephone = "1234567810" };
            Student s2 = new Student() { LastName = "Periklidis", FirstName = "Mixalis", Email = "Periklidis@gmail.com", Telephone = "1234567811" };
            Student s3 = new Student() { LastName = "Papadopoulos", FirstName = "Vaso", Email = "Papadopoulos@gmail.com", Telephone = "1234567812" };
            Student s4 = new Student() { LastName = "Kanellis", FirstName = "Stathis", Email = "Kanellis@gmail.com", Telephone = "1234567813" };
            Student s5 = new Student() { LastName = "katrakis", FirstName = "Thanos", Email = "katrakis@gmail.com", Telephone = "1234567814" };
             #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            #region CourseStudents==============================
            CourseStudent cs1 = new CourseStudent() { Course = c1, Student = s1, IsFeePayed = true };
            CourseStudent cs2 = new CourseStudent() { Course = c1, Student = s2, IsFeePayed = true };
            CourseStudent cs3 = new CourseStudent() { Course = c1, Student = s3, IsFeePayed = true };
            c1.CourseStudents = new List<CourseStudent>() { cs1, cs2, cs3};

            CourseStudent cs31 = new CourseStudent() { Course = c2, Student = s2, IsFeePayed = true };
            CourseStudent cs32 = new CourseStudent() { Course = c2, Student = s3, IsFeePayed = false };
            c2.CourseStudents = new List<CourseStudent>() { cs31, cs32 };

            CourseStudent cs37 = new CourseStudent() { Course = c3, Student = s3, IsFeePayed = false };
            c3.CourseStudents = new List<CourseStudent>() {  cs37 };
            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


            #region Assignment==============================
            Assignment a2 = new Assignment() { Title = "First Java Assignment", SubDate = new DateTime(2020, 04, 01)};
            Assignment a3 = new Assignment() { Title = "First Python Assignment", SubDate = new DateTime(2020, 05, 01)};
            Assignment a4 = new Assignment() { Title = "Functionlity to HTML", SubDate = new DateTime(2020, 04, 05), }; //+
            Assignment a5 = new Assignment() { Title = "Provide Structure to WebSites", SubDate = new DateTime(2020, 05, 05)};

            su1.Assignments = new List<Assignment> { a5 };
            su2.Assignments = new List<Assignment> { a4 };//+
            su4.Assignments = new List<Assignment> { a2 };
            su5.Assignments = new List<Assignment> { a3 };


            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            #region Marks' seeding ======================
            //////Για το assignment 1 (tou c1, s3 pou to exoun oloi oi mathites)
            ///
            Mark m31 = new Mark() { Student = s2, UniqueCode = 90, OralMark = 100 };
            Mark m32 = new Mark() { Student = s3, UniqueCode = 91, OralMark = 100 };
            a2.Marks = new List<Mark>() { m31, m32 };


            // The UPDATE statement conflicted with the FOREIGN KEY constraint "FK_dbo.Marks_dbo.Assignments_AssignmentId".The //conflict occurred in database "TrinityDatabase", table "dbo.Assignments", column 'AssignmentId'.
            /*
            //Για το assignment 2 (tou c2, s4 pou to exoun 6  mathites)
            Mark m31 = new Mark() { Student = s2, UniqueCode = 90, Assignment = a2, OralMark = 100 };
            Mark m32 = new Mark() { Student = s3, UniqueCode = 91, Assignment = a2, OralMark = 100 };
            a2.Marks = new List<Mark>() { m31, m32 };

            //Για το assignment 3 (tou c3, s5 pou to exoun 3 mathites)
            Mark m37 = new Mark() { Student = s3, UniqueCode = 96, Assignment = a3, OralMark = 80 };
            a3.Marks = new List<Mark>() { m37};

            //Για το assignment 4 (tou c1, su2 pou to exoun oloi oi mathites)
            Mark m40 = new Mark() { Student = s1, UniqueCode = 10, Assignment = a5, OralMark = 60 };//+
            Mark m41 = new Mark() { Student = s2, UniqueCode = 11, Assignment = a5, OralMark = 73 };//+
            Mark m42 = new Mark() { Student = s3, UniqueCode = 12, Assignment = a5, OralMark = 63 };//+
            Mark m43 = new Mark() { Student = s4, UniqueCode = 13, Assignment = a5, OralMark = 93 };//+
            Mark m44 = new Mark() { Student = s5, UniqueCode = 14, Assignment = a5, OralMark = 68}; //+
            a4.Marks = new List<Mark>() { m40, m41, m42, m43, m44};

            //Για το assignment 5 (tou c1, su1 pou to exoun oloi oi mathites)

            Mark m71 = new Mark() { Student = s1, UniqueCode = 40.9, Assignment = a5, OralMark = 60 };
            Mark m72 = new Mark() { Student = s2, UniqueCode = 41.9, Assignment = a5, OralMark = 63 };
            Mark m73 = new Mark() { Student = s3, UniqueCode = 42.9, Assignment = a5, OralMark = 87 };
            Mark m74 = new Mark() { Student = s4, UniqueCode = 43.9, Assignment = a5, OralMark = 60 };
            Mark m75 = new Mark() { Student = s5, UniqueCode = 44.9, Assignment = a5, OralMark = 64 };
            a5.Marks = new List<Mark>() { m71, m72, m73, m74, m75};
            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            */
            //Conflicting changes to the role 'Teacher_SubjectTeachers_Source' of the relationship 'Trinity.Database.Teacher_SubjectTeachers' have been detected.
            //+   //Conflicting changes to the role 'Mark_Assignment_Target' of the relationship 'Trinity.Database.Mark_Assignment' have been detected. 
            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            context.Courses.AddOrUpdate(x => x.Title, c1, c2, c3);
            context.Subjects.AddOrUpdate(x => x.Title, su1, su2, su4, su5);
            context.Teachers.AddOrUpdate(x => x.FirstName, t1, t2, t3, t4, t5);
            context.Students.AddOrUpdate(x => x.LastName, s1, s2, s3, s4, s5);
            context.Assignments.AddOrUpdate(x => x.Title, a5, a2, a3, a4);
            context.SaveChanges();





        }                                          
    }                                              
}                                                  
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   

 