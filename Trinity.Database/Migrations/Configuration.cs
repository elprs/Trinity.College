namespace Trinity.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Trinity.Entities;
    using Trinity.Database;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Trinity.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Trinity.Database.MyDatabase context)
        {
            #region=================  SEEDING  ==========================
            Course c1 = new Course() { Title = "BootCamp 1", Description = "C#", Type = Entities.Type.Part_Time, StartDate = new DateTime(2019, 11, 11), EndDate = new DateTime(2020, 06, 11), Fee = 900D };
            Course c2 = new Course() { Title = "BootCamp 2", Description = "Java", Type = Entities.Type.Full_Time, StartDate = new DateTime(2019, 11, 11), EndDate = new DateTime(2020, 03, 11), Fee = 800D };
            Course c3 = new Course() { Title = "BootCamp 3", Description = "Python", Type = Entities.Type.Full_Time, StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 06, 1), Fee = 1500D };


            Subject su1 = new Subject() { Title = "HTML &  C#", PhotoURL = "#" };
            Subject su2 = new Subject() { Title = "JS & C#", PhotoURL = "#" };
            Subject su3 = new Subject() { Title = "C# Architecture", PhotoURL = "#" };
            Subject su4 = new Subject() { Title = "Java Architecture", PhotoURL = "#" };
            Subject su5 = new Subject() { Title = "Python Architecture", PhotoURL = "#" };
            Subject su6 = new Subject() { Title = "HTML & java", PhotoURL = "#" };
            Subject su7 = new Subject() { Title = "JS & java", PhotoURL = "#" };
            Subject su8 = new Subject() { Title = "C# Entity", PhotoURL = "#" };
            Subject su9 = new Subject() { Title = "Java & Algorithms", PhotoURL = "#" };
            Subject su10 = new Subject() { Title = "C# - MVC", PhotoURL = "#" };
            Subject su11 = new Subject() { Title = "Java - A full java system", PhotoURL = "#" };
            Subject su12 = new Subject() { Title = "Python - A full application", PhotoURL = "#" };

            c1.Subjects = new List<Subject>() { su1, su2, su3, su8, su10 };
            c2.Subjects = new List<Subject>() { su4, su6, su7, su9, su11 };
            c3.Subjects = new List<Subject>() { su5, su12 };


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
            su6.Teachers = new List<Teacher> { t2 };
            su7.Teachers = new List<Teacher> { t2 };
            su8.Teachers = new List<Teacher> { t1 };
            su9.Teachers = new List<Teacher> { t2 };
            su10.Teachers = new List<Teacher> { t1, t4 };
            su11.Teachers = new List<Teacher> { t2, t4 };
            su12.Teachers = new List<Teacher> { t3, t4 };




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
            CourseStudent cs30 = new CourseStudent() { Course = c1, Student = s30, IsFeePayed = true };
            c1.CourseStudents = new List<CourseStudent>() { cs1, cs2, cs3, cs4, cs5, cs6, cs7, cs8, cs9, cs10, cs11, cs12, cs13, cs14, cs15, cs16, cs17, cs18, cs19, cs20, cs21, cs22, cs23, cs24, cs25, cs26, cs27, cs28, cs29, cs30 };


            CourseStudent cs31 = new CourseStudent() { Course = c2, Student = s2, IsFeePayed = true };
            CourseStudent cs32 = new CourseStudent() { Course = c2, Student = s3, IsFeePayed = false };
            CourseStudent cs33 = new CourseStudent() { Course = c2, Student = s12, IsFeePayed = true };
            CourseStudent cs34 = new CourseStudent() { Course = c2, Student = s13, IsFeePayed = true };
            CourseStudent cs35 = new CourseStudent() { Course = c2, Student = s22, IsFeePayed = false };
            CourseStudent cs36 = new CourseStudent() { Course = c2, Student = s23, IsFeePayed = true };
            c2.CourseStudents = new List<CourseStudent>() { cs31, cs32, cs33, cs34, cs35, cs36 };

            CourseStudent cs37 = new CourseStudent() { Course = c3, Student = s3, IsFeePayed = false };
            CourseStudent cs38 = new CourseStudent() { Course = c3, Student = s13, IsFeePayed = true };
            CourseStudent cs39 = new CourseStudent() { Course = c3, Student = s23, IsFeePayed = true };
            c3.CourseStudents = new List<CourseStudent>() { cs37, cs38, cs39 };




            Assignment a1 = new Assignment() { Title = "First C# Assignment", SubDate = new DateTime(2020, 03, 01) };
            Assignment a2 = new Assignment() { Title = "First Java Assignment", SubDate = new DateTime(2020, 04, 01) };
            Assignment a3 = new Assignment() { Title = "First Python Assignment", SubDate = new DateTime(2020, 05, 01) };
            Assignment a4 = new Assignment() { Title = "Functionlity to HTML", SubDate = new DateTime(2020, 04, 05), };
            Assignment a5 = new Assignment() { Title = "Provide Structure to WebSites", SubDate = new DateTime(2020, 05, 05) };
            Assignment a6 = new Assignment() { Title = "Well presented data with Java", SubDate = new DateTime(2020, 06, 02) };
            Assignment a7 = new Assignment() { Title = "Java & Javascript", SubDate = new DateTime(2020, 07, 25) };
            Assignment a8 = new Assignment() { Title = "Entity Assignment", SubDate = new DateTime(2020, 02, 25) };
            Assignment a9 = new Assignment() { Title = "Assignment - Java & Algorithms", SubDate = new DateTime(2020, 03, 02) };
            Assignment a10 = new Assignment() { Title = "MVC project", SubDate = new DateTime(2020, 04, 15) };
            Assignment a11 = new Assignment() { Title = " Java Team Project", SubDate = new DateTime(2020, 02, 15) };
            Assignment a12 = new Assignment() { Title = "Python - Team Project", SubDate = new DateTime(2020, 12, 16) };


            su1.Assignments = new List<Assignment>() { a5 };
            su2.Assignments = new List<Assignment>() { a4 };
            su3.Assignments = new List<Assignment>() { a1 };
            su4.Assignments = new List<Assignment>() { a2 };
            su5.Assignments = new List<Assignment>() { a3 };
            su6.Assignments = new List<Assignment>() { a6 };
            su7.Assignments = new List<Assignment>() { a7 };
            su8.Assignments = new List<Assignment>() { a8 };
            su9.Assignments = new List<Assignment>() { a9 };
            su10.Assignments = new List<Assignment>() { a10 };
            su11.Assignments = new List<Assignment>() { a11 };
            su12.Assignments = new List<Assignment>() { a12 };


            //////Για το assignment 1 (tou c1, s3 pou to exoun oloi oi mathites)

            Mark m1 = new Mark() { UniqueCode = 60.5, Student = s1, OralMark = 100, AssignmentMark = 88 };
            Mark m2 = new Mark() { UniqueCode = 61.5, Student = s2, OralMark = 90, AssignmentMark = 77 };
            Mark m3 = new Mark() { Student = s3, UniqueCode = 62.5, OralMark = 80, AssignmentMark = 77 };
            Mark m4 = new Mark() { Student = s4, UniqueCode = 63.5, OralMark = 80, AssignmentMark = 77 };
            Mark m5 = new Mark() { Student = s5, UniqueCode = 64.5, OralMark = 82, AssignmentMark = 77 };
            Mark m6 = new Mark() { Student = s6, UniqueCode = 65.5, OralMark = 82, AssignmentMark = 88 };
            Mark m7 = new Mark() { Student = s7, UniqueCode = 66.5, OralMark = 82, AssignmentMark = 88 };
            Mark m8 = new Mark() { Student = s8, UniqueCode = 67.5, OralMark = 85, AssignmentMark = 98 };
            Mark m9 = new Mark() { Student = s9, UniqueCode = 68.5, OralMark = 80, AssignmentMark = 100 };
            Mark m10 = new Mark() { Student = s10, UniqueCode = 69.5, OralMark = 90, AssignmentMark = 68 };
            Mark m11 = new Mark() { Student = s11, UniqueCode = 70.5, OralMark = 90, AssignmentMark = 68 };
            Mark m12 = new Mark() { Student = s12, UniqueCode = 71.5, OralMark = 97, AssignmentMark = 68 };
            Mark m13 = new Mark() { Student = s13, UniqueCode = 72.5, OralMark = 86, AssignmentMark = 60 };
            Mark m14 = new Mark() { Student = s14, UniqueCode = 73.5, OralMark = 87, AssignmentMark = 65 };
            Mark m15 = new Mark() { Student = s15, UniqueCode = 74.5, OralMark = 87, AssignmentMark = 64 };
            Mark m16 = new Mark() { Student = s16, UniqueCode = 75.5, OralMark = 87, AssignmentMark = 68 };
            Mark m17 = new Mark() { Student = s17, UniqueCode = 76.5, OralMark = 100, AssignmentMark = 68 };
            Mark m18 = new Mark() { Student = s18, UniqueCode = 77.5, OralMark = 100, AssignmentMark = 68 };
            Mark m19 = new Mark() { Student = s19, UniqueCode = 78.5, OralMark = 100, AssignmentMark = 68 };
            Mark m20 = new Mark() { Student = s20, UniqueCode = 79.5, OralMark = 90, AssignmentMark = 68 };
            Mark m21 = new Mark() { Student = s21, UniqueCode = 80.5, OralMark = 97, AssignmentMark = 100 };
            Mark m22 = new Mark() { Student = s22, UniqueCode = 81.5, OralMark = 97, AssignmentMark = 90 };
            Mark m23 = new Mark() { Student = s23, UniqueCode = 82.5, OralMark = 97, AssignmentMark = 77 };
            Mark m24 = new Mark() { Student = s24, UniqueCode = 83.5, OralMark = 97, AssignmentMark = 87 };
            Mark m25 = new Mark() { Student = s25, UniqueCode = 84.5, OralMark = 99, AssignmentMark = 57 };
            Mark m26 = new Mark() { Student = s26, UniqueCode = 85.5, OralMark = 98, AssignmentMark = 44 };
            Mark m27 = new Mark() { Student = s27, UniqueCode = 86.5, OralMark = 68, AssignmentMark = 75 };
            Mark m28 = new Mark() { Student = s28, UniqueCode = 87.5, OralMark = 78, AssignmentMark = 76 };
            Mark m29 = new Mark() { Student = s29, UniqueCode = 88.5, OralMark = 70, AssignmentMark = 77 };
            Mark m30 = new Mark() { Student = s30, UniqueCode = 89.5, OralMark = 60, AssignmentMark = 77 };

            a1.Marks = new List<Mark>() { m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16, m17, m18, m19, m20, m21, m22, m23, m24, m25, m26, m27, m28, m29, m30 };

            //Για το assignment 2 (tou c2, s4 pou to exoun 6  mathites)
            Mark m31 = new Mark() { StudentId = 2, UniqueCode = 90, OralMark = 90, AssignmentMark = 89 };
            Mark m32 = new Mark() { StudentId = 3, UniqueCode = 91, OralMark = 90, AssignmentMark = 89 };
            Mark m33 = new Mark() { StudentId = 12, UniqueCode = 92, OralMark = 50, AssignmentMark = 79 };
            Mark m34 = new Mark() { StudentId = 13, UniqueCode = 93, OralMark = 50, AssignmentMark = 79 };
            Mark m35 = new Mark() { StudentId = 22, UniqueCode = 94, OralMark = 50, AssignmentMark = 79 };
            Mark m36 = new Mark() { StudentId = 23, UniqueCode = 95, OralMark = 50, AssignmentMark = 79 };
            a2.Marks = new List<Mark>() { m31, m32, m33, m34, m35, m36 };

            //Για το assignment 3 (tou c3, s5 pou to exoun 3 mathites)
            Mark m37 = new Mark() { StudentId = 3, UniqueCode = 96, OralMark = 90, AssignmentMark = 100 };
            Mark m38 = new Mark() { StudentId = 13, UniqueCode = 97, OralMark = 77, AssignmentMark = 71 };
            Mark m39 = new Mark() { StudentId = 23, UniqueCode = 98, OralMark = 90, AssignmentMark = 71 };
            a3.Marks = new List<Mark>() { m37, m38, m39 };

            //Για το assignment 4 (tou c1, su2 pou to exoun oloi oi mathites)
            Mark m40 = new Mark() { Student = s1, UniqueCode = 10, OralMark = 60, AssignmentMark = 71 };
            Mark m41 = new Mark() { Student = s2, UniqueCode = 11, OralMark = 73, AssignmentMark = 71 };
            Mark m42 = new Mark() { Student = s3, UniqueCode = 12, OralMark = 63, AssignmentMark = 61 };
            Mark m43 = new Mark() { Student = s4, UniqueCode = 13, OralMark = 93, AssignmentMark = 61 };
            Mark m44 = new Mark() { Student = s5, UniqueCode = 14, OralMark = 68, AssignmentMark = 61 };
            Mark m45 = new Mark() { Student = s6, UniqueCode = 15, OralMark = 90, AssignmentMark = 61 };
            Mark m46 = new Mark() { Student = s7, UniqueCode = 16, OralMark = 90, AssignmentMark = 61 };
            Mark m47 = new Mark() { Student = s8, UniqueCode = 17, OralMark = 90, AssignmentMark = 71 };
            Mark m48 = new Mark() { Student = s9, UniqueCode = 18, OralMark = 90, AssignmentMark = 82 };
            Mark m49 = new Mark() { Student = s10, UniqueCode = 19, OralMark = 90, AssignmentMark = 82 };
            Mark m50 = new Mark() { Student = s11, UniqueCode = 20, OralMark = 66, AssignmentMark = 82 };
            Mark m51 = new Mark() { Student = s12, UniqueCode = 21, OralMark = 66, AssignmentMark = 88 };
            Mark m52 = new Mark() { Student = s13, UniqueCode = 22, OralMark = 66, AssignmentMark = 38 };
            Mark m53 = new Mark() { Student = s14, UniqueCode = 23, OralMark = 66, AssignmentMark = 38 };
            Mark m54 = new Mark() { Student = s15, UniqueCode = 24, OralMark = 66, AssignmentMark = 38 };
            Mark m55 = new Mark() { Student = s16, UniqueCode = 25, OralMark = 76, AssignmentMark = 62 };
            Mark m56 = new Mark() { Student = s17, UniqueCode = 26, OralMark = 70, AssignmentMark = 82 };
            Mark m57 = new Mark() { Student = s18, UniqueCode = 27, OralMark = 70, AssignmentMark = 82 };
            Mark m58 = new Mark() { Student = s19, UniqueCode = 28, OralMark = 70, AssignmentMark = 100 };
            Mark m59 = new Mark() { Student = s20, UniqueCode = 29, OralMark = 90, AssignmentMark = 100 };
            Mark m60 = new Mark() { Student = s21, UniqueCode = 30, OralMark = 90, AssignmentMark = 96 };
            Mark m61 = new Mark() { Student = s22, UniqueCode = 31, OralMark = 92, AssignmentMark = 96 };
            Mark m62 = new Mark() { Student = s23, UniqueCode = 32, OralMark = 92, AssignmentMark = 76 };
            Mark m63 = new Mark() { Student = s24, UniqueCode = 33, OralMark = 92, AssignmentMark = 76 };
            Mark m64 = new Mark() { Student = s25, UniqueCode = 34, OralMark = 90, AssignmentMark = 96 };
            Mark m65 = new Mark() { Student = s26, UniqueCode = 35, OralMark = 90, AssignmentMark = 76 };
            Mark m66 = new Mark() { Student = s27, UniqueCode = 36, OralMark = 91, AssignmentMark = 96 };
            Mark m67 = new Mark() { Student = s28, UniqueCode = 37, OralMark = 91, AssignmentMark = 96 };
            Mark m68 = new Mark() { Student = s29, UniqueCode = 38, OralMark = 91, AssignmentMark = 96 };
            Mark m69 = new Mark() { Student = s30, UniqueCode = 39, OralMark = 91, AssignmentMark = 100 };
            a4.Marks = new List<Mark>() { m40, m41, m42, m43, m44, m45, m46, m47, m48, m49, m50, m51, m52, m53, m54, m55, m56, m57, m58, m59, m60, m61, m62, m63, m64, m65, m66, m67, m68, m69 };



            //Για το assignment 5 (tou c1, su1 pou to exoun oloi oi mathites)
            Mark m70 = new Mark() { Student = s30, UniqueCode = 9.9, OralMark = 80, AssignmentMark = 85 };
            Mark m71 = new Mark() { Student = s1, UniqueCode = 40.9, OralMark = 90, AssignmentMark = 100 };
            Mark m72 = new Mark() { Student = s2, UniqueCode = 41.9, OralMark = 93, AssignmentMark = 100 };
            Mark m73 = new Mark() { Student = s3, UniqueCode = 42.9, OralMark = 93, AssignmentMark = 57 };
            Mark m74 = new Mark() { Student = s4, UniqueCode = 43.9, OralMark = 93, AssignmentMark = 57 };
            Mark m75 = new Mark() { Student = s5, UniqueCode = 44.9, OralMark = 93, AssignmentMark = 67 };
            Mark m76 = new Mark() { Student = s6, UniqueCode = 45.9, OralMark = 93, AssignmentMark = 67 };
            Mark m77 = new Mark() { Student = s7, UniqueCode = 46.9, OralMark = 93, AssignmentMark = 67 };
            Mark m78 = new Mark() { Student = s8, UniqueCode = 47.9, OralMark = 90, AssignmentMark = 57 };
            Mark m79 = new Mark() { Student = s9, UniqueCode = 48.9, OralMark = 80, AssignmentMark = 57 };
            Mark m80 = new Mark() { Student = s10, UniqueCode = 49.9, OralMark = 90, AssignmentMark = 57 };
            Mark m81 = new Mark() { Student = s11, UniqueCode = 50.9, OralMark = 90, AssignmentMark = 57 };
            Mark m82 = new Mark() { Student = s12, UniqueCode = 51.9, OralMark = 80, AssignmentMark = 100 };
            Mark m83 = new Mark() { Student = s13, UniqueCode = 52.9, OralMark = 50, AssignmentMark = 100 };
            Mark m84 = new Mark() { Student = s14, UniqueCode = 53.9, OralMark = 100, AssignmentMark = 100 };
            Mark m85 = new Mark() { Student = s15, UniqueCode = 54.9, OralMark = 50, AssignmentMark = 61 };
            Mark m86 = new Mark() { Student = s16, UniqueCode = 55.9, OralMark = 50, AssignmentMark = 61 };
            Mark m87 = new Mark() { Student = s17, UniqueCode = 56.9, OralMark = 90, AssignmentMark = 71 };
            Mark m88 = new Mark() { Student = s18, UniqueCode = 57.9, OralMark = 90, AssignmentMark = 71 };
            Mark m89 = new Mark() { Student = s19, UniqueCode = 58.9, OralMark = 90, AssignmentMark = 71 };
            Mark m90 = new Mark() { Student = s20, UniqueCode = 59.9, OralMark = 90, AssignmentMark = 61 };
            Mark m91 = new Mark() { Student = s21, UniqueCode = 0.9, OralMark = 90, AssignmentMark = 100 };
            Mark m92 = new Mark() { Student = s22, UniqueCode = 1.9, OralMark = 100, AssignmentMark = 99 };
            Mark m93 = new Mark() { Student = s23, UniqueCode = 2.9, OralMark = 59, AssignmentMark = 99 };
            Mark m94 = new Mark() { Student = s24, UniqueCode = 3.9, OralMark = 59, AssignmentMark = 98 };
            Mark m95 = new Mark() { Student = s25, UniqueCode = 4.9, OralMark = 59, AssignmentMark = 98 };
            Mark m96 = new Mark() { Student = s26, UniqueCode = 5.9, OralMark = 99, AssignmentMark = 98 };
            Mark m97 = new Mark() { Student = s27, UniqueCode = 6.9, OralMark = 99, AssignmentMark = 100 };
            Mark m98 = new Mark() { Student = s28, UniqueCode = 7.9, OralMark = 89, AssignmentMark = 89 };
            Mark m99 = new Mark() { Student = s29, UniqueCode = 8.9, OralMark = 89, AssignmentMark = 85 };

            a5.Marks = new List<Mark>() { m71, m72, m73, m74, m75, m76, m77, m78, m79, m80, m81, m82, m83, m84, m85, m86, m87, m88, m89, m90, m91, m92, m93, m94, m95, m96, m97, m98, m99, m70 };


            //Για το assignment 6 (tou c2, su6 pou to exoun 6  mathites)
            Mark m100 = new Mark() { Student = s2, UniqueCode = 90.9, OralMark = 90, AssignmentMark = 100 };
            Mark m101 = new Mark() { Student = s2, UniqueCode = 90.9, OralMark = 99, AssignmentMark = 84 };
            Mark m102 = new Mark() { Student = s3, UniqueCode = 91.9, OralMark = 50, AssignmentMark = 84 };
            Mark m103 = new Mark() { Student = s12, UniqueCode = 92.9, OralMark = 100, AssignmentMark = 100 };
            Mark m104 = new Mark() { Student = s13, UniqueCode = 93.9, OralMark = 100, AssignmentMark = 93 };
            Mark m105 = new Mark() { Student = s22, UniqueCode = 94.9, OralMark = 93, AssignmentMark = 93 };
            a6.Marks = new List<Mark>() { m101, m102, m103, m104, m105, m100 };



            //Για το assignment 7 (tou c2, su7 pou to exoun 6 mathites)
            Mark m106 = new Mark() { Student = s23, UniqueCode = 95.9, OralMark = 90, AssignmentMark = 100 };
            Mark m107 = new Mark() { Student = s3, UniqueCode = 96.9, OralMark = 90, AssignmentMark = 65 };
            Mark m108 = new Mark() { Student = s13, UniqueCode = 97.9, OralMark = 93, AssignmentMark = 65 };
            Mark m109 = new Mark() { Student = s23, UniqueCode = 98.9, OralMark = 93, AssignmentMark = 65 };
            Mark m110 = new Mark() { Student = s1, UniqueCode = 10.9, OralMark = 90, AssignmentMark = 100 };
            Mark m111 = new Mark() { Student = s2, UniqueCode = 11.9, OralMark = 90, AssignmentMark = 91 };
            Mark m112 = new Mark() { Student = s3, UniqueCode = 12.9, OralMark = 88, AssignmentMark = 91 };
            a7.Marks = new List<Mark>() { m106, m107, m108, m109, m110, m111, m112 };


            //Για το assignment 8 (tou c1, su8 pou to exoun 3 mathites)            
            Mark m113 = new Mark() { Student = s1, UniqueCode = 13.7, OralMark = 50, AssignmentMark = 100 };
            Mark m114 = new Mark() { Student = s2, UniqueCode = 14.7, OralMark = 50, AssignmentMark = 91 };
            Mark m115 = new Mark() { Student = s3, UniqueCode = 15.7, OralMark = 57, AssignmentMark = 91 };
            Mark m116 = new Mark() { Student = s4, UniqueCode = 16.7, OralMark = 57, AssignmentMark = 81 };
            Mark m117 = new Mark() { Student = s5, UniqueCode = 17.7, OralMark = 57, AssignmentMark = 99 };
            Mark m118 = new Mark() { Student = s6, UniqueCode = 18.7, OralMark = 57, AssignmentMark = 81 };
            Mark m119 = new Mark() { Student = s7, UniqueCode = 19.7, OralMark = 87, AssignmentMark = 91 };
            Mark m120 = new Mark() { Student = s8, UniqueCode = 20.7, OralMark = 87, AssignmentMark = 91 };
            Mark m121 = new Mark() { Student = s9, UniqueCode = 21.7, OralMark = 80, AssignmentMark = 100 };
            Mark m122 = new Mark() { Student = s10, UniqueCode = 22.7, OralMark = 77, AssignmentMark = 88 };
            Mark m123 = new Mark() { Student = s11, UniqueCode = 23.7, OralMark = 77, AssignmentMark = 88 };
            Mark m124 = new Mark() { Student = s12, UniqueCode = 24.7, OralMark = 77, AssignmentMark = 71 };
            Mark m125 = new Mark() { Student = s13, UniqueCode = 25.7, OralMark = 90, AssignmentMark = 81 };
            Mark m126 = new Mark() { Student = s14, UniqueCode = 26.7, OralMark = 80, AssignmentMark = 71 };
            Mark m127 = new Mark() { Student = s15, UniqueCode = 27.7, OralMark = 80, AssignmentMark = 88 };
            Mark m128 = new Mark() { Student = s16, UniqueCode = 28.7, OralMark = 89, AssignmentMark = 88 };
            Mark m129 = new Mark() { Student = s17, UniqueCode = 29.7, OralMark = 89, AssignmentMark = 100 };
            Mark m130 = new Mark() { Student = s18, UniqueCode = 30.7, OralMark = 89, AssignmentMark = 100 };
            Mark m131 = new Mark() { Student = s19, UniqueCode = 31.7, OralMark = 99, AssignmentMark = 100 };
            Mark m132 = new Mark() { Student = s20, UniqueCode = 32.7, OralMark = 99, AssignmentMark = 90 };
            Mark m133 = new Mark() { Student = s21, UniqueCode = 33.7, OralMark = 59, AssignmentMark = 77 };
            Mark m134 = new Mark() { Student = s22, UniqueCode = 34.7, OralMark = 57, AssignmentMark = 77 };
            Mark m135 = new Mark() { Student = s23, UniqueCode = 35.7, OralMark = 57, AssignmentMark = 100 };
            Mark m136 = new Mark() { Student = s24, UniqueCode = 36.7, OralMark = 57, AssignmentMark = 100 };
            Mark m137 = new Mark() { Student = s25, UniqueCode = 37.7, OralMark = 67, AssignmentMark = 64 };
            Mark m138 = new Mark() { Student = s26, UniqueCode = 38.7, OralMark = 68, AssignmentMark = 74 };
            Mark m139 = new Mark() { Student = s27, UniqueCode = 69.9, OralMark = 68, AssignmentMark = 64 };
            Mark m140 = new Mark() { Student = s28, UniqueCode = 79.9, OralMark = 68, AssignmentMark = 100 };
            Mark m141 = new Mark() { Student = s29, UniqueCode = 89.9, OralMark = 98, AssignmentMark = 87 };
            Mark m142 = new Mark() { Student = s30, UniqueCode = 99.9, OralMark = 90, AssignmentMark = 87 };
            a8.Marks = new List<Mark>() { m113, m114, m115, m116, m117, m118, m119, m120, m121, m122, m123, m124, m125, m126, m127, m128, m129, m130, m131, m132, m133, m134, m135, m136, m137, m138, m139, m140, m141, m142 };

            //Για το assignment 9 (tou c2, su9 pou to exoun 6  mathites)
            Mark m143 = new Mark() { Student = s2, UniqueCode = 90.8, OralMark = 90, AssignmentMark = 100 };
            Mark m144 = new Mark() { Student = s2, UniqueCode = 90.8, OralMark = 100, AssignmentMark = 100 };
            Mark m145 = new Mark() { Student = s3, UniqueCode = 91.8, OralMark = 90, AssignmentMark = 78 };
            Mark m146 = new Mark() { Student = s12, UniqueCode = 92.8, OralMark = 98, AssignmentMark = 78 };
            Mark m147 = new Mark() { Student = s13, UniqueCode = 93.8, OralMark = 100, AssignmentMark = 80 };
            Mark m148 = new Mark() { Student = s22, UniqueCode = 94.8, OralMark = 99, AssignmentMark = 89 };
            a9.Marks = new List<Mark>() { m143, m144, m145, m146, m147, m148 };


            //Για το assignment 10 (tou c1, su10 pou to exoun oloi oi  mathites)            
            Mark m149 = new Mark() { Student = s1, UniqueCode = 13.3, OralMark = 100, AssignmentMark = 100 };
            Mark m150 = new Mark() { Student = s2, UniqueCode = 14.3, OralMark = 100, AssignmentMark = 76 };
            Mark m151 = new Mark() { Student = s3, UniqueCode = 15.3, OralMark = 76, AssignmentMark = 76 };
            Mark m152 = new Mark() { Student = s4, UniqueCode = 16.3, OralMark = 96, AssignmentMark = 76 };
            Mark m153 = new Mark() { Student = s5, UniqueCode = 17.3, OralMark = 96, AssignmentMark = 79 };
            Mark m154 = new Mark() { Student = s6, UniqueCode = 18.3, OralMark = 96, AssignmentMark = 76 };
            Mark m155 = new Mark() { Student = s7, UniqueCode = 19.3, OralMark = 96, AssignmentMark = 78 };
            Mark m156 = new Mark() { Student = s8, UniqueCode = 20.3, OralMark = 90, AssignmentMark = 76 };
            Mark m157 = new Mark() { Student = s9, UniqueCode = 21.3, OralMark = 50, AssignmentMark = 78 };
            Mark m158 = new Mark() { Student = s10, UniqueCode = 82.3, OralMark = 66, AssignmentMark = 98 };
            Mark m159 = new Mark() { Student = s11, UniqueCode = 83.3, OralMark = 66, AssignmentMark = 98 };
            Mark m160 = new Mark() { Student = s12, UniqueCode = 84.3, OralMark = 66, AssignmentMark = 98 };
            Mark m161 = new Mark() { Student = s13, UniqueCode = 85.3, OralMark = 66, AssignmentMark = 98 };
            Mark m162 = new Mark() { Student = s14, UniqueCode = 86.3, OralMark = 76, AssignmentMark = 100 };
            Mark m163 = new Mark() { Student = s15, UniqueCode = 87.3, OralMark = 76, AssignmentMark = 19 };
            Mark m164 = new Mark() { Student = s16, UniqueCode = 88.3, OralMark = 70, AssignmentMark = 100 };
            Mark m165 = new Mark() { Student = s17, UniqueCode = 89.3, OralMark = 70, AssignmentMark = 100 };
            Mark m166 = new Mark() { Student = s18, UniqueCode = 80.3, OralMark = 70, AssignmentMark = 56 };
            Mark m167 = new Mark() { Student = s19, UniqueCode = 81.3, OralMark = 77, AssignmentMark = 56 };
            Mark m168 = new Mark() { Student = s20, UniqueCode = 82.3, OralMark = 97, AssignmentMark = 100 };
            Mark m169 = new Mark() { Student = s21, UniqueCode = 83.3, OralMark = 97, AssignmentMark = 100 };
            Mark m170 = new Mark() { Student = s22, UniqueCode = 84.3, OralMark = 97, AssignmentMark = 80 };
            Mark m171 = new Mark() { Student = s23, UniqueCode = 85.3, OralMark = 97, AssignmentMark = 100 };
            Mark m172 = new Mark() { Student = s24, UniqueCode = 86.3, OralMark = 88, AssignmentMark = 65 };
            Mark m173 = new Mark() { Student = s25, UniqueCode = 87.3, OralMark = 88, AssignmentMark = 65 };
            Mark m174 = new Mark() { Student = s26, UniqueCode = 88.3, OralMark = 88, AssignmentMark = 100 };
            Mark m175 = new Mark() { Student = s27, UniqueCode = 89.3, OralMark = 88, AssignmentMark = 100 };
            Mark m176 = new Mark() { Student = s28, UniqueCode = 89.3, OralMark = 100, AssignmentMark = 72 };
            Mark m177 = new Mark() { Student = s29, UniqueCode = 89.3, OralMark = 90, AssignmentMark = 79 };
            Mark m178 = new Mark() { Student = s30, UniqueCode = 89.3, OralMark = 90, AssignmentMark = 100 };
            a10.Marks = new List<Mark>() { m149, m150, m151, m152, m153, m154, m155, m156, m157, m158, m159, m160, m161, m162, m163, m164, m165, m166, m167, m168, m169, m170, m171, m172, m173, m174, m175, m176, m177, m178 };

            //Για το assignment 11 (tou c2, su11 pou to exoun 6 mathites)
            Mark m179 = new Mark() { Student = s23, UniqueCode = 95.4, OralMark = 90, AssignmentMark = 100 };
            Mark m180 = new Mark() { Student = s3, UniqueCode = 96.4, OralMark = 100, AssignmentMark = 100 };
            Mark m181 = new Mark() { Student = s13, UniqueCode = 97.4, OralMark = 90, AssignmentMark = 82 };
            Mark m182 = new Mark() { Student = s23, UniqueCode = 98.4, OralMark = 90, AssignmentMark = 78 };
            Mark m183 = new Mark() { Student = s1, UniqueCode = 10.4, OralMark = 80, AssignmentMark = 100 };
            Mark m184 = new Mark() { Student = s2, UniqueCode = 11.4, OralMark = 80, AssignmentMark = 100 };
            a11.Marks = new List<Mark>() { m179, m180, m181, m182, m183, m184 };


            //Για το assignment 12 (tou c3, s12 pou to exoun 3 mathites)
            Mark m185 = new Mark() { Student = s3, UniqueCode = 96.6, OralMark = 100, AssignmentMark = 100 };
            Mark m186 = new Mark() { Student = s13, UniqueCode = 97.6, OralMark = 98, AssignmentMark = 77 };
            Mark m187 = new Mark() { Student = s23, UniqueCode = 98.6, OralMark = 97, AssignmentMark = 100 };
            a12.Marks = new List<Mark>() { m185, m186, m187 };




            context.Courses.AddOrUpdate(x => x.Title, c1, c2, c3);
            context.Subjects.AddOrUpdate(x => x.Title, su1, su2, su3, su4, su5, su6, su7, su8, su9, su10, su11, su12);
            context.Teachers.AddOrUpdate(x => x.FirstName, t1, t2, t3, t4, t5);
            context.Students.AddOrUpdate(x => x.LastName, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30);
            context.Assignments.AddOrUpdate(x => x.Title, a1, a2, a3, a4, a5, a6, a7, a8, a8, a9, a10, a11, a12);
            context.SaveChanges();






            ////context.Marks.AddOrUpdate(x => x.AssignmentMark, m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16, m17, m18, m19, m20, m21, m22, m23, m24, m25, m26, m27, m28, m29, m30, m31, m32, m33, m34, m35, m36, m37, m38, m39, m40, m41, m42, m43, m44, m45, m46, m47, m48, m49, m50, m51, m52, m53, m54, m55, m56, m57, m58, m59, m60, m61, m62, m63, m64, m65, m66, m67, m68, m69, m70, m71, m72, m73, m74, m75, m76, m77, m78, m79, m80, m81, m82, m83, m84, m85, m86, m87, m88, m89, m90, m91, m92, m93, m94, m95, m96, m97, m98, m99, m100, m101, m102, m103, m104, m105, m106, m107, m108, m109, m110, m111, m112, m113, m114, m115, m116, m117, m118, m119, m120, m121, m122, m123, m124, m125, m126, m127, m128, m129, m130, m131, m132, m133, m134, m135, m136, m137, m138, m139, m140, m141, m142, m143, m144, m145, m146, m147, m148, m149, m150, m151, m152, m153, m154, m155, m156, m157, m158, m159, m160, m161, m162, m163, m164, m165, m166, m167, m168, m169, m170, m171, m172, m173, m174, m175, m176, m177, m178, m179, m180, m181, m182, m183, m184, m185, m186, m187

            //// );


            #endregion~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        }

    }
}
