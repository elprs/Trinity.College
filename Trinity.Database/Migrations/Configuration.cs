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
            Subject su2 = new Subject() { Title = "JS & C#", PhotoURL = "#", CourseId = 1 };
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

            //////// Subject.Cource=Course;

            //////su1.Course = c1;
            //////su2.Course = c1;
            //////su3.Course = c1;
            //////su8.Course = c1;
            //////su10.Course = c1;
            //////su4.Course = c2;
            //////su6.Course = c2;
            //////su7.Course = c2;
            //////su9.Course = c2;
            //////su11.Course = c2;
            //////su5.Course = c3;
            //////su12.Course = c3;


            #endregion

            #region Teachers' seeding ==========================
            Teacher t1 = new Teacher() { LastName = "Gatsos", FirstName = "Hektor", Email = "gatsos@gmail.com", Salary = 50000, Telephone = "1234567891" };
            Teacher t2 = new Teacher() { LastName = "Pasparakis", FirstName = "Giorgos", Email = "Pasparakis@gmail.com", Salary = 90000, Telephone = "1234567892" };
            Teacher t3 = new Teacher() { LastName = "Tzelepidis", FirstName = "Basilis", Email = "Tzelepidis@gmail.com", Salary = 30000, Telephone = "1234567893" };
            Teacher t4 = new Teacher() { LastName = "Panou", FirstName = "Panos", Email = "Panou@gmail.com", Salary = 40000, Telephone = "1234567894" };
            Teacher t5 = new Teacher() { LastName = "Minaidis", FirstName = "Georgios", Email = "Minaidis@gmail.com", Salary = 45000, Telephone = "1234567895" };

            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            #region SubjectTeachers=======================

            SubjectTeacher suT1 = new SubjectTeacher() { Subject = su1, Teacher = t1 };
            SubjectTeacher suT2 = new SubjectTeacher() { Subject = su2, Teacher = t1 };
            SubjectTeacher suT3 = new SubjectTeacher() { Subject = su3, Teacher = t1 };
            SubjectTeacher suT8 = new SubjectTeacher() { Subject = su8, Teacher = t1 };
            SubjectTeacher suT10 = new SubjectTeacher() { Subject = su10, Teacher = t1 };
            t1.SubjectTeachers = new List<SubjectTeacher>() { suT1, suT2, suT3, suT8, suT10 };

            SubjectTeacher suT4 = new SubjectTeacher() { Subject = su4, Teacher = t2 };
            SubjectTeacher suT6 = new SubjectTeacher() { Subject = su6, Teacher = t2 };
            SubjectTeacher suT7 = new SubjectTeacher() { Subject = su7, Teacher = t2 };
            SubjectTeacher suT9 = new SubjectTeacher() { Subject = su9, Teacher = t2 };
            SubjectTeacher suT11 = new SubjectTeacher() { Subject = su11, Teacher = t2 };
            t2.SubjectTeachers = new List<SubjectTeacher>() { suT4, suT6, suT7, suT9, suT11 };

            SubjectTeacher suT5 = new SubjectTeacher() { Subject = su5, Teacher = t3 };
            SubjectTeacher suT12 = new SubjectTeacher() { Subject = su12, Teacher = t3 };
            t3.SubjectTeachers = new List<SubjectTeacher>() { suT5, suT12 };

            SubjectTeacher suT13 = new SubjectTeacher() { Subject = su5, Teacher = t4 };
            SubjectTeacher suT14 = new SubjectTeacher() { Subject = su12, Teacher = t4 };
            t4.SubjectTeachers = new List<SubjectTeacher>() { suT13, suT14 };


            SubjectTeacher suT15 = new SubjectTeacher() { Subject = su1, Teacher = t5 };
            SubjectTeacher suT16 = new SubjectTeacher() { Subject = su2, Teacher = t5 };
            t5.SubjectTeachers = new List<SubjectTeacher>() { suT15, suT16 };


            ////su1.Teachers = new List<Teacher>() { t1, t2, t3, t4, t5 };
            #endregion

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

            #region StudentCourses==============================

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


            CourseStudent cs30 = new CourseStudent() { Course = c3, Student = s9, IsFeePayed = false };
            CourseStudent cs37 = new CourseStudent() { Course = c3, Student = s3, IsFeePayed = false };
            CourseStudent cs38 = new CourseStudent() { Course = c3, Student = s13, IsFeePayed = true };
            CourseStudent cs39 = new CourseStudent() { Course = c3, Student = s23, IsFeePayed = true };
            c3.CourseStudents = new List<CourseStudent>() { cs30, cs37, cs38, cs39 };

            // s1.Courses = new List<Course>() { c1 };
            //s2.Courses = new List<Course>() { c1, c2 };
            //s3.Courses = new List<Course>() { c1, c2, c3 };
            //s4.Courses = new List<Course>() { c1 };
            //s5.Courses = new List<Course>() { c1 };
            //s6.Courses = new List<Course>() { c1 };
            //s7.Courses = new List<Course>() { c1 };
            //s8.Courses = new List<Course>() { c1 };
            //s9.Courses = new List<Course>() { c1 };
            //s10.Courses = new List<Course>() { c1 };
            //s11.Courses = new List<Course>() { c1 };
            //s12.Courses = new List<Course>() { c1, c2 };
            //s13.Courses = new List<Course>() { c1, c2, c3 };
            //s14.Courses = new List<Course>() { c1 };
            //s15.Courses = new List<Course>() { c1 };
            //s16.Courses = new List<Course>() { c1 };
            //s17.Courses = new List<Course>() { c1 };
            //s18.Courses = new List<Course>() { c1 };
            //s19.Courses = new List<Course>() { c1 };
            //s20.Courses = new List<Course>() { c3 };
            //s21.Courses = new List<Course>() { c1 };
            //s22.Courses = new List<Course>() { c1, c2 };
            //s23.Courses = new List<Course>() { c1, c2, c3 };
            //s24.Courses = new List<Course>() { c1 };
            //s25.Courses = new List<Course>() { c1 };
            //s26.Courses = new List<Course>() { c1 };
            //s27.Courses = new List<Course>() { c1 };
            //s28.Courses = new List<Course>() { c1 };
            //s29.Courses = new List<Course>() { c1 };
            //s30.Courses = new List<Course>() { c3 };


            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            #region Assignments' seeding ==========================




            Assignment a1 = new Assignment() { Title = "First C# Assignment", SubDate = new DateTime(2020, 03, 01), SubjectId = 3};
            Assignment a2 = new Assignment() { Title = "First Java Assignment", SubDate = new DateTime(2020, 04, 01), SubjectId = 4 };
            Assignment a3 = new Assignment() { Title = "First Python Assignment", SubDate = new DateTime(2020, 05, 01), SubjectId = 5};
            Assignment a4 = new Assignment() { Title = "Functionlity to HTML", SubDate = new DateTime(2020, 04, 05), SubjectId = 2 };
            Assignment a5 = new Assignment() { Title = "Provide Structure to WebSites", SubDate = new DateTime(2020, 05, 05), SubjectId = 1 };
            Assignment a6 = new Assignment() { Title = "Well presented data with Java", SubDate = new DateTime(2020, 06, 02), SubjectId = 6 };
            Assignment a7 = new Assignment() { Title = "Java & Javascript", SubDate = new DateTime(2020, 07, 25), SubjectId = 7};
            Assignment a8 = new Assignment() { Title = "Entity Assignment", SubDate = new DateTime(2020, 02, 25), SubjectId = 8 };
            Assignment a9 = new Assignment() { Title = "Assignment - Java & Algorithms", SubDate = new DateTime(2020, 03, 02), SubjectId = 9 };
            Assignment a10 = new Assignment() { Title = "MVC project", SubDate = new DateTime(2020, 04, 15), SubjectId = 10 };
            Assignment a11 = new Assignment() { Title = " Java Team Project", SubDate = new DateTime(2020, 02, 15), SubjectId = 11 };
            Assignment a12 = new Assignment() { Title = "Python - Team Project", SubDate = new DateTime(2020, 12, 15), SubjectId = 12 };

            su1.Assignment = a5;
            su2.Assignment = a4;
            su3.Assignment = a1;
            su4.Assignment = a2;
            su5.Assignment = a3;
            su6.Assignment = a6;
            su7.Assignment = a7;
            su8.Assignment = a8;
            su9.Assignment = a9;
            su10.Assignment = a10;
            su11.Assignment = a11;
            su12.Assignment = a12;


            //Assignment a1 = new Assignment() { Title = "First C# Assignment", SubDate = new DateTime(2020, 04, 02), Subject = su3};
            //Assignment a2 = new Assignment() { Title = "First Java Assignment", SubDate = new DateTime(2020, 04, 02), Subject = su4};
            //Assignment a3 = new Assignment() { Title = "First Python Assignment", SubDate = new DateTime(2020, 04, 02), Subject = su5 };
            //Assignment a4 = new Assignment() { Title = "Functionlity to HTML", SubDate = new DateTime(2020, 04, 02), Subject = su2 };
            //Assignment a5 = new Assignment() { Title = "Provide Structure to WebSites", SubDate = new DateTime(2020, 04, 02), Subject = su1 };
            //Assignment a6 = new Assignment() { Title = "Well presented data with Java", SubDate = new DateTime(2020, 04, 02), Subject = su6 };
            //Assignment a7 = new Assignment() { Title = "Java & Javascript", SubDate = new DateTime(2020, 04, 02), Subject = su7 };
            //Assignment a8 = new Assignment() { Title = "Entity Assignment", SubDate = new DateTime(2020, 04, 02), Subject = su8 };
            //Assignment a9 = new Assignment() { Title = "Assignment - Java & Algorithms", SubDate = new DateTime(2020, 04, 02), Subject = su9};
            //Assignment a10 = new Assignment() { Title = "MVC project", SubDate = new DateTime(2020, 04, 02), Subject = su10 };
            //Assignment a11 = new Assignment() { Title = " Java Team Project", SubDate = new DateTime(2020, 04, 02), Subject = su11 };
            //Assignment a12 = new Assignment() { Title = "Python - Team Project", SubDate = new DateTime(2020, 04, 02), Subject = su12};


            //a1.Subject = su3;
            //a2.Subject = su4;
            //a3.Subject = su5;
            //a4.Subject = su2;
            //a5.Subject = su1;
            //a6.Subject = su6;
            //a7.Subject = su7;
            //a8.Subject = su8;
            //a9.Subject = su9;
            //a10.Subject = su10;
            //a11.Subject = su11;
            //a12.Subject = su12;



            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            #region Marks' seeding ======================
            //Για το assignment 1 (tou c1, s3 pou to exoun oloi oi mathites)
            Mark m1 = new Mark() { StudentId = 1, AssignmentMark = 60 };
            Mark m2 = new Mark() { StudentId = 2, AssignmentMark = 61 };
            Mark m3 = new Mark() { StudentId = 3, AssignmentMark = 62 };
            Mark m4 = new Mark() { StudentId = 4, AssignmentMark = 63 };
            Mark m5 = new Mark() { StudentId = 5, AssignmentMark = 64 };
            Mark m6 = new Mark() { StudentId = 6, AssignmentMark = 65 };
            Mark m7 = new Mark() { StudentId = 7, AssignmentMark = 66 };
            Mark m8 = new Mark() { StudentId = 8, AssignmentMark = 67 };
            Mark m9 = new Mark() { StudentId = 9, AssignmentMark = 68 };
            Mark m10 = new Mark() { StudentId = 10, AssignmentMark = 69 };
            Mark m11 = new Mark() { StudentId = 11, AssignmentMark = 70 };
            Mark m12 = new Mark() { StudentId = 12, AssignmentMark = 71 };
            Mark m13 = new Mark() { StudentId = 13, AssignmentMark = 72 };
            Mark m14 = new Mark() { StudentId = 14, AssignmentMark = 73 };
            Mark m15 = new Mark() { StudentId = 15, AssignmentMark = 74 };
            Mark m16 = new Mark() { StudentId = 16, AssignmentMark = 75 };
            Mark m17 = new Mark() { StudentId = 17, AssignmentMark = 76 };
            Mark m18 = new Mark() { StudentId = 18, AssignmentMark = 77 };
            Mark m19 = new Mark() { StudentId = 19, AssignmentMark = 78 };
            Mark m20 = new Mark() { StudentId = 20, AssignmentMark = 79 };
            Mark m21 = new Mark() { StudentId = 21, AssignmentMark = 80 };
            Mark m22 = new Mark() { StudentId = 22, AssignmentMark = 81 };
            Mark m23 = new Mark() { StudentId = 23, AssignmentMark = 82 };
            Mark m24 = new Mark() { StudentId = 24, AssignmentMark = 83 };
            Mark m25 = new Mark() { StudentId = 25, AssignmentMark = 84 };
            Mark m26 = new Mark() { StudentId = 26, AssignmentMark = 85 };
            Mark m27 = new Mark() { StudentId = 27, AssignmentMark = 86 };
            Mark m28 = new Mark() { StudentId = 28, AssignmentMark = 87 };
            Mark m29 = new Mark() { StudentId = 29, AssignmentMark = 88 };
            Mark m30 = new Mark() { StudentId = 30, AssignmentMark = 89 };
            a1.Marks = new List<Mark>() { m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16, m17, m18, m19, m20, m21, m22, m23, m24, m25, m26, m27, m28, m29, m30 };


            //Για το assignment 2 (tou c2, s4 pou to exoun 6  mathites)
            Mark m31 = new Mark() { StudentId = 2, AssignmentMark = 90 };
            Mark m32 = new Mark() { StudentId = 3, AssignmentMark = 91 };
            Mark m33 = new Mark() { StudentId = 12, AssignmentMark = 92 };
            Mark m34 = new Mark() { StudentId = 13, AssignmentMark = 93 };
            Mark m35 = new Mark() { StudentId = 22, AssignmentMark = 94 };
            Mark m36 = new Mark() { StudentId = 23, AssignmentMark = 95 };
            a2.Marks = new List<Mark>() { m31, m32, m33, m34, m35, m36 };



            //Για το assignment 3 (tou c3, s5 pou to exoun 3 mathites)
            Mark m37 = new Mark() { StudentId = 3, AssignmentMark = 96 };
            Mark m38 = new Mark() { StudentId = 13, AssignmentMark = 97 };
            Mark m39 = new Mark() { StudentId = 23, AssignmentMark = 98 };
            a3.Marks = new List<Mark>() { m37, m38, m39 };

            //Για το assignment 4 (tou c1, s2 pou to exoun oloi oi mathites)
            Mark m40 = new Mark() { StudentId = 1, AssignmentMark = 10 };
            Mark m41 = new Mark() { StudentId = 2, AssignmentMark = 11 };
            Mark m42 = new Mark() { StudentId = 3, AssignmentMark = 12 };
            Mark m43 = new Mark() { StudentId = 4, AssignmentMark = 13 };
            Mark m44 = new Mark() { StudentId = 5, AssignmentMark = 14 };
            Mark m45 = new Mark() { StudentId = 6, AssignmentMark = 15 };
            Mark m46 = new Mark() { StudentId = 7, AssignmentMark = 16 };
            Mark m47 = new Mark() { StudentId = 8, AssignmentMark = 17 };
            Mark m48 = new Mark() { StudentId = 9, AssignmentMark = 18 };
            Mark m49 = new Mark() { StudentId = 10, AssignmentMark = 19 };
            Mark m50 = new Mark() { StudentId = 11, AssignmentMark = 20 };
            Mark m51 = new Mark() { StudentId = 12, AssignmentMark = 21 };
            Mark m52 = new Mark() { StudentId = 13, AssignmentMark = 22 };
            Mark m53 = new Mark() { StudentId = 14, AssignmentMark = 23 };
            Mark m54 = new Mark() { StudentId = 15, AssignmentMark = 24 };
            Mark m55 = new Mark() { StudentId = 16, AssignmentMark = 25 };
            Mark m56 = new Mark() { StudentId = 17, AssignmentMark = 26 };
            Mark m57 = new Mark() { StudentId = 18, AssignmentMark = 27 };
            Mark m58 = new Mark() { StudentId = 19, AssignmentMark = 28 };
            Mark m59 = new Mark() { StudentId = 20, AssignmentMark = 29 };
            Mark m60 = new Mark() { StudentId = 21, AssignmentMark = 30 };
            Mark m61 = new Mark() { StudentId = 22, AssignmentMark = 31 };
            Mark m62 = new Mark() { StudentId = 23, AssignmentMark = 32 };
            Mark m63 = new Mark() { StudentId = 24, AssignmentMark = 33 };
            Mark m64 = new Mark() { StudentId = 25, AssignmentMark = 34 };
            Mark m65 = new Mark() { StudentId = 26, AssignmentMark = 35 };
            Mark m66 = new Mark() { StudentId = 27, AssignmentMark = 36 };
            Mark m67 = new Mark() { StudentId = 28, AssignmentMark = 37 };
            Mark m68 = new Mark() { StudentId = 29, AssignmentMark = 38 };
            Mark m69 = new Mark() { StudentId = 30, AssignmentMark = 39 };
            a4.Marks = new List<Mark>() { m40, m41, m42, m43, m44, m45, m46, m47, m48, m49, m50, m51, m52, m53, m54, m55, m56, m57, m58, m59, m60, m61, m62, m63, m64, m65, m66, m67, m68, m69 };



         
            //a5.Subject = su1;
            //a6.Subject = su6;
            //a7.Subject = su7;
            //a8.Subject = su8;
            //a9.Subject = su9;
            //a10.Subject = su10;
            //a11.Subject = su11;
            //a12.Subject = su12;


            //Για το assignment 5 (tou c1, su1 pou to exoun oloi oi mathites)
            Mark m70 = new Mark() { StudentId = 30, AssignmentMark = 89 };
            Mark m71 = new Mark() { StudentId = 1, AssignmentMark = 60 };
            Mark m72 = new Mark() { StudentId = 2, AssignmentMark = 61 };
            Mark m73 = new Mark() { StudentId = 3, AssignmentMark = 62 };
            Mark m74 = new Mark() { StudentId = 4, AssignmentMark = 63 };
            Mark m75 = new Mark() { StudentId = 5, AssignmentMark = 64 };
            Mark m76 = new Mark() { StudentId = 6, AssignmentMark = 65 };
            Mark m77 = new Mark() { StudentId = 7, AssignmentMark = 66 };
            Mark m78 = new Mark() { StudentId = 8, AssignmentMark = 67 };
            Mark m79 = new Mark() { StudentId = 9, AssignmentMark = 68 };
            Mark m80 = new Mark() { StudentId = 10, AssignmentMark = 69 };
            Mark m81 = new Mark() { StudentId = 11, AssignmentMark = 70 };
            Mark m82 = new Mark() { StudentId = 12, AssignmentMark = 71 };
            Mark m83 = new Mark() { StudentId = 13, AssignmentMark = 72 };
            Mark m84 = new Mark() { StudentId = 14, AssignmentMark = 73 };
            Mark m85 = new Mark() { StudentId = 15, AssignmentMark = 74 };
            Mark m86 = new Mark() { StudentId = 16, AssignmentMark = 75 };
            Mark m87 = new Mark() { StudentId = 17, AssignmentMark = 76 };
            Mark m88 = new Mark() { StudentId = 18, AssignmentMark = 77 };
            Mark m89 = new Mark() { StudentId = 19, AssignmentMark = 78 };
            Mark m90 = new Mark() { StudentId = 20, AssignmentMark = 79 };
            Mark m91 = new Mark() { StudentId = 21, AssignmentMark = 80 };
            Mark m92 = new Mark() { StudentId = 22, AssignmentMark = 81 };
            Mark m93 = new Mark() { StudentId = 23, AssignmentMark = 82 };
            Mark m94 = new Mark() { StudentId = 24, AssignmentMark = 83 };
            Mark m95 = new Mark() { StudentId = 25, AssignmentMark = 84 };
            Mark m96 = new Mark() { StudentId = 26, AssignmentMark = 85 };
            Mark m97 = new Mark() { StudentId = 27, AssignmentMark = 86 };
            Mark m98 = new Mark() { StudentId = 28, AssignmentMark = 87 };
            Mark m99 = new Mark() { StudentId = 29, AssignmentMark = 88 };
            a1.Marks = new List<Mark>() { m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16, m17, m18, m19, m20, m21, m22, m23, m24, m25, m26, m27, m28, m29, m30 };


            //Για το assignment 2 (tou c2, s4 pou to exoun 6  mathites)
            Mark m100 = new Mark() { StudentId = 2, AssignmentMark = 90 };
            Mark m101 = new Mark() { StudentId = 2, AssignmentMark = 90 };
            Mark m102 = new Mark() { StudentId = 3, AssignmentMark = 91 };
            Mark m103 = new Mark() { StudentId = 12, AssignmentMark = 92 };
            Mark m104 = new Mark() { StudentId = 13, AssignmentMark = 93 };
            Mark m105 = new Mark() { StudentId = 22, AssignmentMark = 94 };
            Mark m106 = new Mark() { StudentId = 23, AssignmentMark = 95 };
            a2.Marks = new List<Mark>() { m31, m32, m33, m34, m35, m36 };



            //Για το assignment 3 (tou c3, s5 pou to exoun 3 mathites)
            Mark m107 = new Mark() { StudentId = 3, AssignmentMark = 96 };
            Mark m108 = new Mark() { StudentId = 13, AssignmentMark = 97 };
            Mark m109 = new Mark() { StudentId = 23, AssignmentMark = 98 };
            a3.Marks = new List<Mark>() { m37, m38, m39 };

            //Για το assignment 4 (tou c1, s2 pou to exoun oloi oi mathites)
            Mark m110 = new Mark() { StudentId = 1, AssignmentMark = 10 };
            Mark m111 = new Mark() { StudentId = 2, AssignmentMark = 11 };
            Mark m112 = new Mark() { StudentId = 3, AssignmentMark = 12 };
            Mark m113 = new Mark() { StudentId = 4, AssignmentMark = 13 };
            Mark m114 = new Mark() { StudentId = 5, AssignmentMark = 14 };
            Mark m115 = new Mark() { StudentId = 6, AssignmentMark = 15 };
            Mark m116 = new Mark() { StudentId = 7, AssignmentMark = 16 };
            Mark m117 = new Mark() { StudentId = 8, AssignmentMark = 17 };
            Mark m118 = new Mark() { StudentId = 9, AssignmentMark = 18 };
            Mark m119 = new Mark() { StudentId = 10, AssignmentMark = 19 };
            Mark m120 = new Mark() { StudentId = 11, AssignmentMark = 20 };
            Mark m121 = new Mark() { StudentId = 12, AssignmentMark = 21 };
            Mark m122 = new Mark() { StudentId = 13, AssignmentMark = 22 };
            Mark m123 = new Mark() { StudentId = 14, AssignmentMark = 23 };
            Mark m124 = new Mark() { StudentId = 15, AssignmentMark = 24 };
            Mark m125 = new Mark() { StudentId = 16, AssignmentMark = 25 };
            Mark m126 = new Mark() { StudentId = 17, AssignmentMark = 26 };
            Mark m127 = new Mark() { StudentId = 18, AssignmentMark = 27 };
            Mark m128 = new Mark() { StudentId = 19, AssignmentMark = 28 };
            Mark m129 = new Mark() { StudentId = 20, AssignmentMark = 29 };
            Mark m130 = new Mark() { StudentId = 21, AssignmentMark = 30 };
            Mark m131 = new Mark() { StudentId = 22, AssignmentMark = 31 };
            Mark m132 = new Mark() { StudentId = 23, AssignmentMark = 32 };
            Mark m133 = new Mark() { StudentId = 24, AssignmentMark = 33 };
            Mark m134 = new Mark() { StudentId = 25, AssignmentMark = 34 };
            Mark m135 = new Mark() { StudentId = 26, AssignmentMark = 35 };
            Mark m136 = new Mark() { StudentId = 27, AssignmentMark = 36 };
            Mark m137 = new Mark() { StudentId = 28, AssignmentMark = 37 };
            Mark m138 = new Mark() { StudentId = 29, AssignmentMark = 38 };
            Mark m139 = new Mark() { StudentId = 30, AssignmentMark = 39 };
            a4.Marks = new List<Mark>() { m40, m41, m42, m43, m44, m45, m46, m47, m48, m49, m50, m51, m52, m53, m54, m55, m56, m57, m58, m59, m60, m61, m62, m63, m64, m65, m66, m67, m68, m69 };



            ////a5.Marks =
            ////a6.Marks = 
            ////a7.Marks = 
            ////a8.Marks = 
            ////a9.Marks = 
            ////a10.Marks = 
            ////a11.Marks = 
            ////a12.Marks = 

            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



            context.Courses.AddOrUpdate(x => x.Title, c1, c2, c3);
            context.Subjects.AddOrUpdate(x => x.Title, su1, su2, su3, su4, su5, su6, su7, su8, su9, su10, su11, su12);
            context.Teachers.AddOrUpdate(x => x.FirstName, t1, t2, t3, t4, t5);
            context.Students.AddOrUpdate(x => x.LastName, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30);
            context.Assignments.AddOrUpdate(x => x.Title, a1, a2, a3, a4, a5, a6, a7, a8, a8, a9, a10, a11, a12);
            context.Marks.AddOrUpdate(x => x.AssignmentMark, m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16, m17, m18, m19, m20, m21, m22, m23, m24, m25, m26, m27, m28, m29, m30, m31, m32, m33, m34, m35, m36, m37, m38, m39, m40, m41, m42, m43, m44, m45, m46, m47, m48, m49, m50, m51, m52, m53, m54, m55, m56, m57, m58, m59, m60, m61, m62, m63, m64, m65, m66, m67, m68, m69);


            context.SaveChanges();

        }                                          
    }                                              
}                                                  
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   

 