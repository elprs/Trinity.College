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
            Subject su3 = new Subject() { Title = "C# Architecture", PhotoURL = "#", CourseId = 1 };
            Subject su4 = new Subject() { Title = "Java Architecture", PhotoURL = "#", CourseId = 2 };
            Subject su5 = new Subject() { Title = "Python Architecture", PhotoURL = "#", CourseId = 3 };
            Subject su6 = new Subject() { Title = "HTML & java", PhotoURL = "#", CourseId = 2 };
            Subject su7 = new Subject() { Title = "JS & java", PhotoURL = "#", CourseId = 2 };
            Subject su8 = new Subject() { Title = "C# Entity", PhotoURL = "#", CourseId = 1 };
            Subject su9 = new Subject() { Title = "Java & Algorithms", PhotoURL = "#", CourseId = 2 };
            Subject su10 = new Subject() { Title = "C# - MVC", PhotoURL = "#", CourseId = 1 };
            Subject su11 = new Subject() { Title = "Java - A full java system", PhotoURL = "#", CourseId = 2 };
            Subject su12 = new Subject() { Title = "Python - A full application", PhotoURL = "#", CourseId = 3 };

            #endregion

            #region Teachers' seeding ==========================
            Teacher t1 = new Teacher() { LastName = "Gatsos", FirstName = "Hektor", Email = "gatsos@gmail.com", Salary = 50000, Telephone = "1234567891" };
            Teacher t2 = new Teacher() { LastName = "Pasparakis", FirstName = "Giorgos", Email = "Pasparakis@gmail.com", Salary = 90000, Telephone = "1234567892" };
            Teacher t3 = new Teacher() { LastName = "Tzelepidis", FirstName = "Basilis", Email = "Tzelepidis@gmail.com", Salary = 30000, Telephone = "1234567893" };
            Teacher t4 = new Teacher() { LastName = "Panou", FirstName = "Panos", Email = "Panou@gmail.com", Salary = 40000, Telephone = "1234567894" };
            Teacher t5 = new Teacher() { LastName = "Minaidis", FirstName = "Georgios", Email = "Minaidis@gmail.com", Salary = 45000, Telephone = "1234567895" };


            su1.Teachers = new List<Teacher> { t1, t5 };
            su2.Teachers = new List<Teacher> { t1, t5 };
            su3.Teachers = new List<Teacher> { t1 };
            su4.Teachers = new List<Teacher> { t2 };
            su5.Teachers = new List<Teacher> { t3, t4 };
            su6.Teachers = new List<Teacher> {  t2 };
            su7.Teachers = new List<Teacher> {  t2 };
            su8.Teachers = new List<Teacher> { t1 };
            su9.Teachers = new List<Teacher> { t2 };
            su10.Teachers = new List<Teacher> { t1, t4 };
            su11.Teachers = new List<Teacher> { t2, t4 };
            su12.Teachers = new List<Teacher> { t3, t4 };

            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            #region Students' seeding ==========================
            Student s1 = new Student() { LastName = "Parisi", FirstName = "Eleni", Email = "parisi@gmail.com", Telephone = "1234567810" };
            Student s2 = new Student() { LastName = "Periklidis", FirstName = "Mixalis", Email = "Periklidis@gmail.com", Telephone = "1234567811" };
            Student s3 = new Student() { LastName = "Papadopoulos", FirstName = "Vaso", Email = "Papadopoulos@gmail.com", Telephone = "1234567812" };
            Student s4 = new Student() { LastName = "Kanellis", FirstName = "Stathis", Email = "Kanellis@gmail.com", Telephone = "1234567813" };
            Student s5 = new Student() { LastName = "katrakis", FirstName = "Thanos", Email = "katrakis@gmail.com", Telephone = "1234567814" };
            Student s6 = new Student() { LastName = "Veggos", FirstName = "Thanasis", Email = "Veggos@gmail.com", Telephone = "1234567815" };
            Student s7 = new Student() { LastName = "Papatrexas", FirstName = "Athanasios", Email = "Papatrexas@gmail.com", Telephone = "1234567816" };
            Student s8 = new Student() { LastName = "Elefsiniotis", FirstName = "Giannis", Email = "Elefsiniotis@gmail.com", Telephone = "1234567817" };
            Student s9 = new Student() { LastName = "Saris", FirstName = "Ioannis", Email = "Saris@gmail.com", Telephone = "1234567818" };
            Student s10 = new Student() { LastName = "Poulakos", FirstName = "Giorgos", Email = "Poulakos@gmail.com", Telephone = "1234567819" };
            Student s11 = new Student() { LastName = "Vlaxogiannis", FirstName = "Xenofontas", Email = "Vlaxogiannis@gmail.com", Telephone = "1234567820" };
            Student s12 = new Student() { LastName = "Sakarakas", FirstName = "Panagiotis", Email = "Sakarakas@gmail.com", Telephone = "1234567821" };
            Student s13 = new Student() { LastName = "Karowich", FirstName = "Karolos", Email = "Karowich@gmail.com", Telephone = "1234567822" };
            Student s14 = new Student() { LastName = "Kuriakou", FirstName = "Adam", Email = "Kuriakou@gmail.com", Telephone = "1234567823" };
            Student s15 = new Student() { LastName = "Papandreou", FirstName = "Albi", Email = "Papandreou@gmail.com", Telephone = "1234567824" };
            Student s16 = new Student() { LastName = "Perikleoys", FirstName = "Alex", Email = "Perikleoys@gmail.com", Telephone = "1234567825" };
            Student s17 = new Student() { LastName = "Kontodimas", FirstName = "Bagggelis", Email = "Kontodimas@gmail.com", Telephone = "1234567826" };
            Student s18 = new Student() { LastName = "Makrys", FirstName = "Xristos", Email = "Makrys@gmail.com", Telephone = "1234567827" };
            Student s19 = new Student() { LastName = "Sxoinas", FirstName = "Dionusis", Email = "Sxoinas@gmail.com", Telephone = "1234567828" };
            Student s20 = new Student() { LastName = "Xatzixristou", FirstName = "Maria", Email = "Xatzixristou@gmail.com", Telephone = "1234567829" };
            Student s21 = new Student() { LastName = "Fotiou", FirstName = "Fotis", Email = "Fotiou@gmail.com", Telephone = "1234567830" };
            Student s22 = new Student() { LastName = "Karampas", FirstName = "Takis", Email = "Karampas@gmail.com", Telephone = "1234567831" };
            Student s23 = new Student() { LastName = "Telopoulos", FirstName = "Periklis", Email = "Telopoulos@gmail.com", Telephone = "1234567832" };
            Student s24 = new Student() { LastName = "Katsaros", FirstName = "Kosta", Email = "Katsaros@gmail.com", Telephone = "1234567833" };
            Student s25 = new Student() { LastName = "Dimitriou", FirstName = "Dimitris", Email = "Dimitriou@gmail.com", Telephone = "1234567834" };
            Student s26 = new Student() { LastName = "Katerinaki", FirstName = "Katerina", Email = "Katerinaki@gmail.com", Telephone = "1234567835" };
            Student s27 = new Student() { LastName = "Sofianou", FirstName = "Sofia", Email = "Sofianou@gmail.com", Telephone = "1234567836" };
            Student s28 = new Student() { LastName = "Karakosta", FirstName = "Mairi", Email = "Karakosta@gmail.com", Telephone = "1234567837" };
            Student s29 = new Student() { LastName = "Marikaki", FirstName = "Meni", Email = "Marikaki@gmail.com", Telephone = "1234567838" };
            Student s30 = new Student() { LastName = "Lyraki", FirstName = "Lina", Email = "Lyraki@gmail.com", Telephone = "1234567839" };

            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            #region CourseStudents==============================
            CourseStudent cs1 = new CourseStudent() { Course = c1, Student = s1, IsFeePayed = true };
            CourseStudent cs2 = new CourseStudent() { Course = c1, Student = s2, IsFeePayed = true };
            CourseStudent cs3 = new CourseStudent() { Course = c1, Student = s3, IsFeePayed = true };
            CourseStudent cs4 = new CourseStudent() { Course = c1, Student = s4, IsFeePayed = true };
            CourseStudent cs5 = new CourseStudent() { Course = c1, Student = s5, IsFeePayed = false };
            CourseStudent cs6 = new CourseStudent() { Course = c1, Student = s6, IsFeePayed = true };
            CourseStudent cs7 = new CourseStudent() { Course = c1, Student = s7, IsFeePayed = false };
            CourseStudent cs8 = new CourseStudent() { Course = c1, Student = s8, IsFeePayed = true };
            CourseStudent cs9 = new CourseStudent() { Course = c1, Student = s9, IsFeePayed = false };
            CourseStudent cs10 = new CourseStudent() { Course = c1, Student = s10, IsFeePayed = false };
            CourseStudent cs11 = new CourseStudent() { Course = c1, Student = s11, IsFeePayed = false };
            CourseStudent cs12 = new CourseStudent() { Course = c1, Student = s12, IsFeePayed = false };
            CourseStudent cs13 = new CourseStudent() { Course = c1, Student = s13, IsFeePayed = true };
            CourseStudent cs14 = new CourseStudent() { Course = c1, Student = s14, IsFeePayed = true };
            CourseStudent cs15 = new CourseStudent() { Course = c1, Student = s15, IsFeePayed = false };
            CourseStudent cs16 = new CourseStudent() { Course = c1, Student = s16, IsFeePayed = true };
            CourseStudent cs17 = new CourseStudent() { Course = c1, Student = s17, IsFeePayed = false };
            CourseStudent cs18 = new CourseStudent() { Course = c1, Student = s18, IsFeePayed = true };
            CourseStudent cs19 = new CourseStudent() { Course = c1, Student = s19, IsFeePayed = false };
            CourseStudent cs20 = new CourseStudent() { Course = c1, Student = s20, IsFeePayed = false };
            CourseStudent cs21 = new CourseStudent() { Course = c1, Student = s21, IsFeePayed = false };
            CourseStudent cs22 = new CourseStudent() { Course = c1, Student = s22, IsFeePayed = false };
            CourseStudent cs23 = new CourseStudent() { Course = c1, Student = s23, IsFeePayed = true };
            CourseStudent cs24 = new CourseStudent() { Course = c1, Student = s24, IsFeePayed = true };
            CourseStudent cs25 = new CourseStudent() { Course = c1, Student = s25, IsFeePayed = false };
            CourseStudent cs26 = new CourseStudent() { Course = c1, Student = s26, IsFeePayed = true };
            CourseStudent cs27 = new CourseStudent() { Course = c1, Student = s27, IsFeePayed = false };
            CourseStudent cs28 = new CourseStudent() { Course = c1, Student = s28, IsFeePayed = true };
            CourseStudent cs29 = new CourseStudent() { Course = c1, Student = s29, IsFeePayed = false };
            c1.CourseStudents = new List<CourseStudent>() { cs1, cs2, cs3, cs4, cs5, cs6, cs7, cs8, cs9, cs10, cs11, cs12, cs13, cs14, cs15, cs16, cs17, cs18, cs19, cs20, cs21, cs22, cs23, cs24, cs25, cs26, cs27, cs28, cs29 };


            CourseStudent cs31 = new CourseStudent() { Course = c2, Student = s2, IsFeePayed = true };
            CourseStudent cs32 = new CourseStudent() { Course = c2, Student = s3, IsFeePayed = false };
            CourseStudent cs33 = new CourseStudent() { Course = c2, Student = s12, IsFeePayed = true };
            CourseStudent cs34 = new CourseStudent() { Course = c2, Student = s13, IsFeePayed = true };
            CourseStudent cs35 = new CourseStudent() { Course = c2, Student = s22, IsFeePayed = false };
            CourseStudent cs36 = new CourseStudent() { Course = c2, Student = s23, IsFeePayed = true };
            c2.CourseStudents = new List<CourseStudent>() { cs31, cs32, cs33, cs34, cs35, cs36 };

            CourseStudent cs37 = new CourseStudent() { Course = c3, Student = s3, IsFeePayed = false };
            CourseStudent cs30 = new CourseStudent() { Course = c3, Student = s9, IsFeePayed = false };
            CourseStudent cs38 = new CourseStudent() { Course = c3, Student = s13, IsFeePayed = true };
            CourseStudent cs39 = new CourseStudent() { Course = c3, Student = s23, IsFeePayed = true };
            c3.CourseStudents = new List<CourseStudent>() { cs30, cs37, cs38, cs39 };
            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            #region Assignment's seeding==============================

            Assignment a1 = new Assignment() { Title = "First C# Assignment", SubDate = new DateTime(2020, 03, 01) };
            Assignment a2 = new Assignment() { Title = "First Java Assignment", SubDate = new DateTime(2020, 04, 01)};
            Assignment a3 = new Assignment() { Title = "First Python Assignment", SubDate = new DateTime(2020, 05, 01)};
            Assignment a4 = new Assignment() { Title = "Functionlity to HTML", SubDate = new DateTime(2020, 04, 05), }; //+
            Assignment a5 = new Assignment() { Title = "Provide Structure to WebSites", SubDate = new DateTime(2020, 05, 05)};
            Assignment a6 = new Assignment() { Title = "Well presented data with Java", SubDate = new DateTime(2020, 06, 02) };
            Assignment a7 = new Assignment() { Title = "Java & Javascript", SubDate = new DateTime(2020, 07, 25)};
            Assignment a8 = new Assignment() { Title = "Entity Assignment", SubDate = new DateTime(2020, 02, 25)};
            Assignment a9 = new Assignment() { Title = "Assignment - Java & Algorithms", SubDate = new DateTime(2020, 03, 02) };
            Assignment a10 = new Assignment() { Title = "MVC project", SubDate = new DateTime(2020, 04, 15)};
            Assignment a11 = new Assignment() { Title = " Java Team Project", SubDate = new DateTime(2020, 02, 15)};
            Assignment a12 = new Assignment() { Title = "Python - Team Project", SubDate = new DateTime(2020, 12, 16) };


            su1.Assignments = new List<Assignment>() { a5 };
            su2.Assignments = new List<Assignment>() { a4 };
            su3.Assignments = new List<Assignment>() { a1 };
            su4.Assignments = new List<Assignment>() { a2 };
            su5.Assignments = new List<Assignment>() { a3 };
            su6.Assignments = new List<Assignment>() { a6};
            su7.Assignments = new List<Assignment>() { a7};
            su8.Assignments = new List<Assignment>() { a8};
            su9.Assignments = new List<Assignment>() { a9 };
            su10.Assignments = new List<Assignment>() { a10 };
            su11.Assignments = new List<Assignment>() { a11};
            su12.Assignments = new List<Assignment>() { a12};


            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            #region Marks' seeding ======================
            //////Για το assignment 1 (tou c1, s3 pou to exoun oloi oi mathites)
            ///
            Mark m31 = new Mark() { Student = s2, UniqueCode = 90, OralMark = 100 };
            Mark m32 = new Mark() { Student = s3, UniqueCode = 91, OralMark = 100 };
            a2.Marks = new List<Mark>() { m31, m32 };


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
            context.Subjects.AddOrUpdate(x => x.Title, su1, su2, su3, su4, su5, su6, su7, su8, su9, su10, su11, su12);

            context.Teachers.AddOrUpdate(x => x.FirstName, t1, t2, t3, t4, t5);
            context.Students.AddOrUpdate(x => x.LastName, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30);

            context.Assignments.AddOrUpdate(x => x.Title, a5, a2, a3, a4);
            context.SaveChanges();





        }
    }                                              
}                                                  
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   

 