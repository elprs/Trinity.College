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
