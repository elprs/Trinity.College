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
    public class CourseStudentRepository
    {

        MyDatabase db = new MyDatabase();

        //GetAll()
        public IEnumerable<CourseStudent> GetAll()
        {
            return db.CourseStudents.ToList();
        }

        //GetByID
        public CourseStudent GetById(int? id)
        {

            return db.CourseStudents.Find(id);
        }

        //Insert
        public void Insert(CourseStudent cs)
        {
            db.Entry(cs).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update
        public void Update(CourseStudent cs)
        {
            db.Entry(cs).State = EntityState.Modified;
            db.SaveChanges();
        }

        //Delete
        public void Delete(CourseStudent cs)
        {
            db.Entry(cs).State = EntityState.Deleted;
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
