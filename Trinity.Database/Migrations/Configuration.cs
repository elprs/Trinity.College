namespace Trinity.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Trinity.Entities;
    using Trinity.Database;

    internal sealed class Configuration : DbMigrationsConfiguration<Trinity.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Trinity.Database.MyDatabase context)
        {
            //#region Courses' seeding ==========================
            //Course c1 = new Course() { Title = "C#" };
            //Course c2 = new Course() { Title = "Java" };
            //Course c3 = new Course() { Title = "Python" };
            //#endregion

            //#region Subjects' seeding ==========================
            //Subject su1 = new Subject() { Title = "HTML &  C#" };
            //Subject su2 = new Subject() { Title = "JS & C#" };
            //Subject su3 = new Subject() { Title = "C# Architecture" };
            //Subject su4 = new Subject() { Title = "Java Architecture" };
            //Subject su5 = new Subject() { Title = "Python Architecture" };
            //Subject su6 = new Subject() { Title = "HTML & java" };
            //Subject su7 = new Subject() { Title = "JS & java" };
            //Subject su8 = new Subject() { Title = "C# Entity" };
            //Subject su9 = new Subject() { Title = "Java & Algorithms" };
            //Subject su10 = new Subject() { Title = "C# - MVC" };
            //Subject su11 = new Subject() { Title = "Java - A full java system" };
            //Subject su12 = new Subject() { Title = "Python - A full application" };
            //#endregion

            //#region Assignments' seeding ==========================

            //Assignment a1 = new Assignment() { Title = "First C# Assignment" };
            //Assignment a2 = new Assignment() { Title = "First Java Assignment" };
            //Assignment a3 = new Assignment() { Title = "First Python Assignment" };
            //Assignment a4 = new Assignment() { Title = "Add functionlity to HTML" };
            //Assignment a5 = new Assignment() { Title = "Provide Structure to web" };
            //Assignment a6 = new Assignment() { Title = "Well presented data with Java" };
            //Assignment a7 = new Assignment() { Title = "Java & Javascript" };
            //Assignment a8 = new Assignment() { Title = "Entity Assignment" };
            //Assignment a9 = new Assignment() { Title = "Assignment - Java & Algorithms" };
            //Assignment a10 = new Assignment() { Title = "MVC project" };
            //Assignment a11 = new Assignment() { Title = " Java Team Project" };
            //Assignment a12 = new Assignment() { Title = "Python - Team Project" };
            //#endregion

            //#region Teachers' seeding ==========================
            //Teacher t1 = new Teacher() { FirstName = "Hektor" };
            //Teacher t2 = new Teacher() { FirstName = "Giorgos" };
            //Teacher t3 = new Teacher() { FirstName = "Basilis" };
            //Teacher t4 = new Teacher() { FirstName = "Panos" };
            //Teacher t5 = new Teacher() { FirstName = "Giorgos" };

            //#endregion

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


            //context.Assignments.AddOrUpdate(x => x.Title, a1, a2, a3, a4, a5);
            //context.SaveChanges();







        }
    }
}
