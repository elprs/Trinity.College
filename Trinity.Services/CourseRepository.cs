using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trinity.Database;
using System.Threading.Tasks;
using Trinity.Entities;

namespace Trinity.Services
{
   public class CourseRepository
    {

        MyDatabase db = new MyDatabase();

        //GetAll()
        public IEnumerable<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        //GetByID
        public Course GetById(int? id)
        {

            return db.Courses.Find(id);
        }
    }
}
