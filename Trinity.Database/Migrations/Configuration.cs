namespace Trinity.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Trinity.Entities;
    using Trinity.Database;
    using System.Collections.Generic;
    using System.Collections;

    internal sealed class Configuration : DbMigrationsConfiguration<Trinity.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Trinity.Database.MyDatabase context)
        {
            // Μain Entities Seeding
            #region Courses' seeding ==========================
            Course c1 = new Course() { Title = "C#" };
            Course c2 = new Course() { Title = "Java" };
            Course c3 = new Course() { Title = "Python" };
            #endregion

            #region Subjects' seeding ==========================
            Subject su1 = new Subject() { Title = "HTML &  C#" };
            Subject su2 = new Subject() { Title = "JS & C#" };
            Subject su3 = new Subject() { Title = "C# Architecture" };
            Subject su4 = new Subject() { Title = "Java Architecture" };
            Subject su5 = new Subject() { Title = "Python Architecture" };
            Subject su6 = new Subject() { Title = "HTML & java" };
            Subject su7 = new Subject() { Title = "JS & java" };
            Subject su8 = new Subject() { Title = "C# Entity" };
            Subject su9 = new Subject() { Title = "Java & Algorithms" };
            Subject su10 = new Subject() { Title = "C# - MVC" };
            Subject su11 = new Subject() { Title = "Java - A full java system" };
            Subject su12 = new Subject() { Title = "Python - A full application" };
            #endregion

            #region Assignments' seeding ==========================

            Assignment a1 = new Assignment() { Title = "First C# Assignment" };
            Assignment a2 = new Assignment() { Title = "First Java Assignment" };
            Assignment a3 = new Assignment() { Title = "First Python Assignment" };
            Assignment a4 = new Assignment() { Title = "Add functionlity to HTML" };
            Assignment a5 = new Assignment() { Title = "Provide Structure to web" };
            Assignment a6 = new Assignment() { Title = "Well presented data with Java" };
            Assignment a7 = new Assignment() { Title = "Java & Javascript" };
            Assignment a8 = new Assignment() { Title = "Entity Assignment" };
            Assignment a9 = new Assignment() { Title = "Assignment - Java & Algorithms" };
            Assignment a10 = new Assignment() { Title = "MVC project" };
            Assignment a11 = new Assignment() { Title = " Java Team Project" };
            Assignment a12 = new Assignment() { Title = "Python - Team Project" };
            #endregion

            #region Teachers' seeding ==========================
            Teacher t1 = new Teacher() { FirstName = "Hektor" };
            Teacher t2 = new Teacher() { FirstName = "Giorgos" };
            Teacher t3 = new Teacher() { FirstName = "Basilis" };
            Teacher t4 = new Teacher() { FirstName = "Panos" };
            Teacher t5 = new Teacher() { FirstName = "Nikos" };

            #endregion

            #region Students' seeding ==========================
            Student s1 = new Student() { FirstName = "Eleni" };
            Student s2 = new Student() { FirstName = "Mixalis" };
            Student s3 = new Student() { FirstName = "Vaso" };
            Student s4 = new Student() { FirstName = "Stathis" };
            Student s5 = new Student() { FirstName = "Thanos" };
            Student s6 = new Student() { FirstName = "Thanasis" };
            Student s7 = new Student() { FirstName = "Athanasios" };
            Student s8 = new Student() { FirstName = "Giannis" };
            Student s9 = new Student() { FirstName = "Ioannis" };
            Student s10 = new Student() { FirstName = "Giorgos" };
            Student s11 = new Student() { FirstName = "Xenofontas" };
            Student s12 = new Student() { FirstName = "Panagiotis" };
            Student s13 = new Student() { FirstName = "Karolos" };
            Student s14 = new Student() { FirstName = "Adam" };
            Student s15 = new Student() { FirstName = "Albi" };
            Student s16 = new Student() { FirstName = "Alex" };
            Student s17 = new Student() { FirstName = "Bagggelis" };
            Student s18 = new Student() { FirstName = "Xristos" };
            Student s19 = new Student() { FirstName = "Dionusis" };
            Student s20 = new Student() { FirstName = "Zaxarias" };

            #endregion


            #region Συσχετισεις============================
            // Assignment.Subject=Subject;
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

            su1.Assignment = a1;
            su2.Assignment = a2;
            su3.Assignment = a3;

            // Subject.Cource=Course;

            su1.Course = c1;
            su2.Course = c1;
            su3.Course = c1;
            su8.Course = c1;
            su10.Course = c1;
            su4.Course = c2;
            su6.Course = c2;
            su7.Course = c2;
            su9.Course = c2;
            su11.Course = c2;
            su5.Course = c3;
            su12.Course = c3;


            su1.Teachers = new List<Teacher>() { t1, t2, t3, t4, t5 };

            s1.Courses = new List<Course>() { c1 };
            s2.Courses = new List<Course>() { c1, c2 };
            s3.Courses = new List<Course>() { c1, c2, c3 };
            s4.Courses = new List<Course>() { c1 };
            s5.Courses = new List<Course>() { c1 };
            s6.Courses = new List<Course>() { c1 };
            s7.Courses = new List<Course>() { c1 };
            s8.Courses = new List<Course>() { c1 };
            s9.Courses = new List<Course>() { c1 };
            s10.Courses = new List<Course>() { c1 };
            s11.Courses = new List<Course>() { c1 };
            s12.Courses = new List<Course>() { c1, c2 };
            s13.Courses = new List<Course>() { c1, c2, c3 };
            s14.Courses = new List<Course>() { c1 };
            s15.Courses = new List<Course>() { c1 };
            s16.Courses = new List<Course>() { c1 };
            s17.Courses = new List<Course>() { c1 };
            s18.Courses = new List<Course>() { c1 };
            s19.Courses = new List<Course>() { c1 };
            s20.Courses = new List<Course>() { c3 };


            // Assignment.Subject=Subject 
            #endregion





            context.Teachers.AddOrUpdate(x => x.FirstName, t1, t2, t3, t4, t5);
            //context.Assignments.AddOrUpdate(x => x.Title, a1, a2, a3, a4, a5, a6, a7, a8, a8, a9, a10, a11, a12);
            context.Subjects.AddOrUpdate(x => x.Title, su1, su2, su3, su4, su5, su6, su7, su8, su9, su10, su11, su12);

            context.SaveChanges();







        }
    }
}
