using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trinity.Database;
using System.Threading.Tasks;
using Trinity.Entities;
using System.Data.Entity;

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

        //Insert
        public void Insert(Course c)
        {
            db.Entry(c).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update
        public void Update(Course c)
        {
            db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();
        }

        //Delete
        public void Delete(Course c)
        {
            db.Entry(c).State = EntityState.Deleted;
            db.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
