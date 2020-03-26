using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Trinity.Entities;

namespace Trinity.Database
{
    public class MyDatabase : DbContext
    {
        public MyDatabase() : base("Link")
        {

        }

            public DbSet<Course> Courses { get; set; }
            public DbSet<Student> Students { get; set; }
            public DbSet<Payment> Payments { get; set; }
            public DbSet<Subject> Subjects { get; set; }
            public DbSet<Assignment> Assignments { get; set; }
            public DbSet<Teacher> Teachers { get; set; }
    }
}
